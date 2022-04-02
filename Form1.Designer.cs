
namespace CodecChecker
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvVideoCodec = new System.Windows.Forms.ListView();
            this.tbScanFolderPath = new System.Windows.Forms.TextBox();
            this.bScan = new System.Windows.Forms.Button();
            this.cbFiletypeFilter = new System.Windows.Forms.ComboBox();
            this.cbCodecFilter = new System.Windows.Forms.ComboBox();
            this.lScanFolderPath = new System.Windows.Forms.Label();
            this.lFiletypeFilter = new System.Windows.Forms.Label();
            this.lCodecFilter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvVideoCodec
            // 
            this.lvVideoCodec.FullRowSelect = true;
            this.lvVideoCodec.GridLines = true;
            this.lvVideoCodec.HideSelection = false;
            this.lvVideoCodec.Location = new System.Drawing.Point(12, 38);
            this.lvVideoCodec.Name = "lvVideoCodec";
            this.lvVideoCodec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lvVideoCodec.Size = new System.Drawing.Size(1163, 419);
            this.lvVideoCodec.TabIndex = 0;
            this.lvVideoCodec.UseCompatibleStateImageBehavior = false;
            // 
            // tbScanFolderPath
            // 
            this.tbScanFolderPath.Location = new System.Drawing.Point(76, 12);
            this.tbScanFolderPath.Name = "tbScanFolderPath";
            this.tbScanFolderPath.Size = new System.Drawing.Size(1018, 20);
            this.tbScanFolderPath.TabIndex = 1;
            // 
            // bScan
            // 
            this.bScan.Location = new System.Drawing.Point(1100, 10);
            this.bScan.Name = "bScan";
            this.bScan.Size = new System.Drawing.Size(75, 23);
            this.bScan.TabIndex = 3;
            this.bScan.Text = "Scan";
            this.bScan.UseVisualStyleBackColor = true;
            this.bScan.Click += new System.EventHandler(this.bScan_Click);
            // 
            // cbFiletypeFilter
            // 
            this.cbFiletypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiletypeFilter.Location = new System.Drawing.Point(64, 463);
            this.cbFiletypeFilter.Name = "cbFiletypeFilter";
            this.cbFiletypeFilter.Size = new System.Drawing.Size(121, 21);
            this.cbFiletypeFilter.TabIndex = 4;
            // 
            // cbCodecFilter
            // 
            this.cbCodecFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodecFilter.Location = new System.Drawing.Point(279, 463);
            this.cbCodecFilter.Name = "cbCodecFilter";
            this.cbCodecFilter.Size = new System.Drawing.Size(121, 21);
            this.cbCodecFilter.TabIndex = 5;
            // 
            // lScanFolderPath
            // 
            this.lScanFolderPath.AutoSize = true;
            this.lScanFolderPath.Location = new System.Drawing.Point(9, 15);
            this.lScanFolderPath.Name = "lScanFolderPath";
            this.lScanFolderPath.Size = new System.Drawing.Size(61, 13);
            this.lScanFolderPath.TabIndex = 2;
            this.lScanFolderPath.Text = "Scanfolder:";
            // 
            // lFiletypeFilter
            // 
            this.lFiletypeFilter.AutoSize = true;
            this.lFiletypeFilter.Location = new System.Drawing.Point(12, 466);
            this.lFiletypeFilter.Name = "lFiletypeFilter";
            this.lFiletypeFilter.Size = new System.Drawing.Size(46, 13);
            this.lFiletypeFilter.TabIndex = 6;
            this.lFiletypeFilter.Text = "Filetype:";
            // 
            // lCodecFilter
            // 
            this.lCodecFilter.AutoSize = true;
            this.lCodecFilter.Location = new System.Drawing.Point(232, 466);
            this.lCodecFilter.Name = "lCodecFilter";
            this.lCodecFilter.Size = new System.Drawing.Size(41, 13);
            this.lCodecFilter.TabIndex = 7;
            this.lCodecFilter.Text = "Codec:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 496);
            this.Controls.Add(this.lCodecFilter);
            this.Controls.Add(this.lFiletypeFilter);
            this.Controls.Add(this.cbCodecFilter);
            this.Controls.Add(this.cbFiletypeFilter);
            this.Controls.Add(this.bScan);
            this.Controls.Add(this.lScanFolderPath);
            this.Controls.Add(this.tbScanFolderPath);
            this.Controls.Add(this.lvVideoCodec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvVideoCodec;
        private System.Windows.Forms.TextBox tbScanFolderPath;
        private System.Windows.Forms.Button bScan;
        private System.Windows.Forms.ComboBox cbFiletypeFilter;
        private System.Windows.Forms.ComboBox cbCodecFilter;
        private System.Windows.Forms.Label lScanFolderPath;
        private System.Windows.Forms.Label lFiletypeFilter;
        private System.Windows.Forms.Label lCodecFilter;
    }
}

