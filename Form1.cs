using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NReco.VideoInfo;
using static NReco.VideoInfo.MediaInfo;

namespace CodecChecker
{
    public partial class Form1 : Form
    {
        List<string> _fileTypeFilters = null;
        List<string> _codecNameFilters = null;

        bool _isScanning = false;
        bool _scanCancelRequest = false;

        public Form1()
        {
            InitializeComponent();

            _fileTypeFilters = new List<string>(new string[] {"*.*",
                                                              ".mp4",
                                                              ".mkv",
                                                              ".avi",
                                                              ".wav",
                                                              ".flv",
                                                              ".mov"}); // This list is also used below in "Scan"!!! No method for dynamic check during scan found for now
            foreach (string fileTypeFilter in _fileTypeFilters)
                cbFiletypeFilter.Items.Add(fileTypeFilter);
            cbFiletypeFilter.SelectedIndex = 0;
            _codecNameFilters = new List<string>();
            ClearCodecNameFilters();

            _isScanning = false;
            _scanCancelRequest = false;
            UpdateScanUI(_isScanning);


            double headerScalePath = 0.8;
            double headerScaleCodec = 0.195;

            lvVideoCodec.Sorting = SortOrder.None;
            lvVideoCodec.View = View.Details;
            lvVideoCodec.Columns.Add(new ColumnHeader()); // Dummy
            lvVideoCodec.Columns[0].Width = 0;
            lvVideoCodec.Columns.Add(new ColumnHeader());
            lvVideoCodec.Columns[1].Text = "Videopath";
            lvVideoCodec.Columns[1].Width = (int)(lvVideoCodec.Width * headerScalePath);
            lvVideoCodec.Columns.Add(new ColumnHeader());
            lvVideoCodec.Columns[2].Text = "Codec";
            lvVideoCodec.Columns[2].Width = (int)(lvVideoCodec.Width * headerScaleCodec);
            lvVideoCodec.SuspendLayout();
        }

        private void bScan_Click(object sender, EventArgs e)
        {
            if (_isScanning)
            {
                _isScanning = false;
                _scanCancelRequest = true;
            }
            else
            {
                string sFolder = tbScanFolderPath.Text;
                if (tbScanFolderPath.Text == null)
                    return;

                if (!Directory.Exists(sFolder))
                    return;
                ClearCodecNameFilters();
                lvVideoCodec.Items.Clear();

                _isScanning = true;
                _scanCancelRequest = false;
                ThreadPool.QueueUserWorkItem(state => ScanDirectory(sFolder));
            }
            UpdateScanUI(_isScanning);
        }

        private void UpdateScanUI(bool scanningState)
        {
            if (scanningState)
                bScan.Text = "Cancel";
            else
                bScan.Text = "Scan";
        }

        private void ScanDirectory(string sFolder)
        {
            //var scanDir = "C:\\Users\\XMG\\Downloads\\ScanOrdner";
            var sFiles = Directory.GetFiles(sFolder, "*.*", SearchOption.AllDirectories)
                .Where(s => s.ToLower().EndsWith(".mp4")
                            || s.ToLower().EndsWith(".mkv")
                            || s.ToLower().EndsWith(".avi")
                            || s.ToLower().EndsWith(".wav")
                            || s.ToLower().EndsWith(".flv")
                            || s.ToLower().EndsWith(".mov"));

            var prober = new FFProbe();
            MediaInfo info = null;
            StreamInfo streamNfo = null;
            string codecName = null;
            foreach (var sFile in sFiles)
            {
                if (_scanCancelRequest == true)
                {
                    _scanCancelRequest = false;
                    return;
                }

                info = prober.GetMediaInfo(sFile);
                foreach (var streamInfo in info.Streams)
                {
                    if(_scanCancelRequest == true)
                    {
                        _scanCancelRequest = false;
                        return;
                    }
                        
                    if (streamInfo.CodecType == "video")
                    {
                        codecName = CheckCodecName(streamInfo.CodecName);
                        if (!_codecNameFilters.Contains(codecName))
                            _codecNameFilters.Add(codecName);
                        var lvItem = new ListViewItem();
                        lvItem.SubItems.Add(sFile);
                        lvItem.SubItems.Add(codecName);
                        Invoke(new Action<ListViewItem>(AddToListView), lvItem);
                        //lvVideoCodec.Items.Add(lvItem);
                    }
                }
            }
        }

        private void AddToListView(ListViewItem lvItem)
        {
            lvVideoCodec.Items.Add(lvItem);
        }

        private string CheckCodecName(string CodecName)
        {
            if (CodecName == null)
                return "Unknown";

            switch(CodecName)
            {
                case "hevc":
                    return "hevc/h265";

                default:
                    return CodecName;
            }
        }
        
        private void ClearCodecNameFilters()
        {
            _codecNameFilters.Clear();
            _codecNameFilters.Add("*.*");
            cbCodecFilter.Items.Clear();
            cbCodecFilter.Items.Add(_codecNameFilters[0]);
            cbCodecFilter.SelectedIndex = 0;
        }
    }
}
