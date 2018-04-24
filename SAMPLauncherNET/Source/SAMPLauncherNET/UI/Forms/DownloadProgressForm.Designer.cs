namespace SAMPLauncherNET
{
    partial class DownloadProgressForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadProgressForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.downloadProgressLabel = new MaterialSkin.Controls.MaterialLabel();
            this.downloadProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.mainPanel.Controls.Add(this.downloadProgressLabel);
            this.mainPanel.Controls.Add(this.downloadProgressBar);
            this.mainPanel.Location = new System.Drawing.Point(12, 64);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(276, 44);
            this.mainPanel.TabIndex = 0;
            // 
            // downloadProgressLabel
            // 
            this.downloadProgressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadProgressLabel.Depth = 0;
            this.downloadProgressLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.downloadProgressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.downloadProgressLabel.Location = new System.Drawing.Point(3, 0);
            this.downloadProgressLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.downloadProgressLabel.Name = "downloadProgressLabel";
            this.downloadProgressLabel.Size = new System.Drawing.Size(270, 33);
            this.downloadProgressLabel.TabIndex = 1;
            this.downloadProgressLabel.Text = "{$DOWNLOAD_PROGRESS$}";
            this.downloadProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // downloadProgressBar
            // 
            this.downloadProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadProgressBar.Depth = 0;
            this.downloadProgressBar.Location = new System.Drawing.Point(3, 36);
            this.downloadProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.downloadProgressBar.Name = "downloadProgressBar";
            this.downloadProgressBar.Size = new System.Drawing.Size(270, 5);
            this.downloadProgressBar.TabIndex = 0;
            // 
            // DownloadProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 120);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(10000, 120);
            this.MinimumSize = new System.Drawing.Size(300, 120);
            this.Name = "DownloadProgressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "{$DOWNLOAD_PROGRESS_TITLE$}";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DownloadProgressForm_FormClosing);
            this.Load += new System.EventHandler(this.DownloadProgressForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private MaterialSkin.Controls.MaterialProgressBar downloadProgressBar;
        private MaterialSkin.Controls.MaterialLabel downloadProgressLabel;
    }
}