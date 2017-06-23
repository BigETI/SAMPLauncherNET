namespace SAMPLauncherNET
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.disableHeadMoveCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.fpsLimitTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.pageSizeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.fontFaceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.pageSizeLabel = new MetroFramework.Controls.MetroLabel();
            this.fpsLimitLabel = new MetroFramework.Controls.MetroLabel();
            this.timestampCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.imeCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.multiCoreCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.directModeCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.audioMessageOffCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.audioProxyOffCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.noNametagStatusCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.fontFaceLabel = new MetroFramework.Controls.MetroLabel();
            this.fontWeightCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.fpsLimitTextBox = new MetroFramework.Controls.MetroTextBox();
            this.okButton = new MetroFramework.Controls.MetroButton();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // disableHeadMoveCheckBox
            // 
            this.disableHeadMoveCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disableHeadMoveCheckBox.Location = new System.Drawing.Point(23, 118);
            this.disableHeadMoveCheckBox.Name = "disableHeadMoveCheckBox";
            this.disableHeadMoveCheckBox.Size = new System.Drawing.Size(504, 15);
            this.disableHeadMoveCheckBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.disableHeadMoveCheckBox.TabIndex = 5;
            this.disableHeadMoveCheckBox.Text = "{$DISABLE_HEAD_MOVE$}";
            this.disableHeadMoveCheckBox.UseSelectable = true;
            // 
            // fpsLimitTrackBar
            // 
            this.fpsLimitTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpsLimitTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.fpsLimitTrackBar.Location = new System.Drawing.Point(229, 89);
            this.fpsLimitTrackBar.Maximum = 90;
            this.fpsLimitTrackBar.Minimum = 20;
            this.fpsLimitTrackBar.Name = "fpsLimitTrackBar";
            this.fpsLimitTrackBar.Size = new System.Drawing.Size(242, 23);
            this.fpsLimitTrackBar.Style = MetroFramework.MetroColorStyle.Orange;
            this.fpsLimitTrackBar.TabIndex = 3;
            this.fpsLimitTrackBar.ValueChanged += new System.EventHandler(this.fpsLimitTrackBar_ValueChanged);
            // 
            // pageSizeTextBox
            // 
            this.pageSizeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.pageSizeTextBox.CustomButton.Image = null;
            this.pageSizeTextBox.CustomButton.Location = new System.Drawing.Point(276, 1);
            this.pageSizeTextBox.CustomButton.Name = "";
            this.pageSizeTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.pageSizeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pageSizeTextBox.CustomButton.TabIndex = 1;
            this.pageSizeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pageSizeTextBox.CustomButton.UseSelectable = true;
            this.pageSizeTextBox.CustomButton.Visible = false;
            this.pageSizeTextBox.Lines = new string[] {
        "10"};
            this.pageSizeTextBox.Location = new System.Drawing.Point(229, 60);
            this.pageSizeTextBox.MaxLength = 32767;
            this.pageSizeTextBox.Name = "pageSizeTextBox";
            this.pageSizeTextBox.PasswordChar = '\0';
            this.pageSizeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pageSizeTextBox.SelectedText = "";
            this.pageSizeTextBox.SelectionLength = 0;
            this.pageSizeTextBox.SelectionStart = 0;
            this.pageSizeTextBox.ShortcutsEnabled = true;
            this.pageSizeTextBox.Size = new System.Drawing.Size(298, 23);
            this.pageSizeTextBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.pageSizeTextBox.TabIndex = 1;
            this.pageSizeTextBox.Text = "10";
            this.pageSizeTextBox.UseSelectable = true;
            this.pageSizeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pageSizeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.pageSizeTextBox.TextChanged += new System.EventHandler(this.pageSizeTextBox_TextChanged);
            // 
            // fontFaceTextBox
            // 
            this.fontFaceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.fontFaceTextBox.CustomButton.Image = null;
            this.fontFaceTextBox.CustomButton.Location = new System.Drawing.Point(276, 1);
            this.fontFaceTextBox.CustomButton.Name = "";
            this.fontFaceTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.fontFaceTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fontFaceTextBox.CustomButton.TabIndex = 1;
            this.fontFaceTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fontFaceTextBox.CustomButton.UseSelectable = true;
            this.fontFaceTextBox.CustomButton.Visible = false;
            this.fontFaceTextBox.Lines = new string[0];
            this.fontFaceTextBox.Location = new System.Drawing.Point(229, 283);
            this.fontFaceTextBox.MaxLength = 32767;
            this.fontFaceTextBox.Name = "fontFaceTextBox";
            this.fontFaceTextBox.PasswordChar = '\0';
            this.fontFaceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fontFaceTextBox.SelectedText = "";
            this.fontFaceTextBox.SelectionLength = 0;
            this.fontFaceTextBox.SelectionStart = 0;
            this.fontFaceTextBox.ShortcutsEnabled = true;
            this.fontFaceTextBox.Size = new System.Drawing.Size(298, 23);
            this.fontFaceTextBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.fontFaceTextBox.TabIndex = 14;
            this.fontFaceTextBox.UseSelectable = true;
            this.fontFaceTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fontFaceTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pageSizeLabel
            // 
            this.pageSizeLabel.Location = new System.Drawing.Point(23, 60);
            this.pageSizeLabel.Name = "pageSizeLabel";
            this.pageSizeLabel.Size = new System.Drawing.Size(200, 23);
            this.pageSizeLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.pageSizeLabel.TabIndex = 0;
            this.pageSizeLabel.Text = "{$PAGE_SIZE$}";
            this.pageSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fpsLimitLabel
            // 
            this.fpsLimitLabel.Location = new System.Drawing.Point(23, 89);
            this.fpsLimitLabel.Name = "fpsLimitLabel";
            this.fpsLimitLabel.Size = new System.Drawing.Size(200, 23);
            this.fpsLimitLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.fpsLimitLabel.TabIndex = 2;
            this.fpsLimitLabel.Text = "{$FPS_LIMIT$}";
            this.fpsLimitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timestampCheckBox
            // 
            this.timestampCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timestampCheckBox.Location = new System.Drawing.Point(23, 139);
            this.timestampCheckBox.Name = "timestampCheckBox";
            this.timestampCheckBox.Size = new System.Drawing.Size(504, 15);
            this.timestampCheckBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.timestampCheckBox.TabIndex = 6;
            this.timestampCheckBox.Text = "{$TIMESTAMP$}";
            this.timestampCheckBox.UseSelectable = true;
            // 
            // imeCheckBox
            // 
            this.imeCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imeCheckBox.Location = new System.Drawing.Point(23, 160);
            this.imeCheckBox.Name = "imeCheckBox";
            this.imeCheckBox.Size = new System.Drawing.Size(504, 15);
            this.imeCheckBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.imeCheckBox.TabIndex = 7;
            this.imeCheckBox.Text = "{$IME$}";
            this.imeCheckBox.UseSelectable = true;
            // 
            // multiCoreCheckBox
            // 
            this.multiCoreCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.multiCoreCheckBox.Location = new System.Drawing.Point(23, 181);
            this.multiCoreCheckBox.Name = "multiCoreCheckBox";
            this.multiCoreCheckBox.Size = new System.Drawing.Size(504, 15);
            this.multiCoreCheckBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.multiCoreCheckBox.TabIndex = 8;
            this.multiCoreCheckBox.Text = "{$MULTI_CORE$}";
            this.multiCoreCheckBox.UseSelectable = true;
            // 
            // directModeCheckBox
            // 
            this.directModeCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directModeCheckBox.Location = new System.Drawing.Point(23, 202);
            this.directModeCheckBox.Name = "directModeCheckBox";
            this.directModeCheckBox.Size = new System.Drawing.Size(504, 15);
            this.directModeCheckBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.directModeCheckBox.TabIndex = 9;
            this.directModeCheckBox.Text = "{$DIRECT_MODE$}";
            this.directModeCheckBox.UseSelectable = true;
            // 
            // audioMessageOffCheckBox
            // 
            this.audioMessageOffCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.audioMessageOffCheckBox.Location = new System.Drawing.Point(23, 223);
            this.audioMessageOffCheckBox.Name = "audioMessageOffCheckBox";
            this.audioMessageOffCheckBox.Size = new System.Drawing.Size(504, 15);
            this.audioMessageOffCheckBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.audioMessageOffCheckBox.TabIndex = 10;
            this.audioMessageOffCheckBox.Text = "{$AUDIO_MESSAGE_OFF$}";
            this.audioMessageOffCheckBox.UseSelectable = true;
            // 
            // audioProxyOffCheckBox
            // 
            this.audioProxyOffCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.audioProxyOffCheckBox.Location = new System.Drawing.Point(23, 244);
            this.audioProxyOffCheckBox.Name = "audioProxyOffCheckBox";
            this.audioProxyOffCheckBox.Size = new System.Drawing.Size(504, 15);
            this.audioProxyOffCheckBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.audioProxyOffCheckBox.TabIndex = 11;
            this.audioProxyOffCheckBox.Text = "{$AUDIO_PROXY_OFF$}";
            this.audioProxyOffCheckBox.UseSelectable = true;
            // 
            // noNametagStatusCheckBox
            // 
            this.noNametagStatusCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noNametagStatusCheckBox.Location = new System.Drawing.Point(23, 265);
            this.noNametagStatusCheckBox.Name = "noNametagStatusCheckBox";
            this.noNametagStatusCheckBox.Size = new System.Drawing.Size(504, 15);
            this.noNametagStatusCheckBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.noNametagStatusCheckBox.TabIndex = 12;
            this.noNametagStatusCheckBox.Text = "{$NO_NAMETAG_STATUS$}";
            this.noNametagStatusCheckBox.UseSelectable = true;
            // 
            // fontFaceLabel
            // 
            this.fontFaceLabel.Location = new System.Drawing.Point(23, 283);
            this.fontFaceLabel.Name = "fontFaceLabel";
            this.fontFaceLabel.Size = new System.Drawing.Size(200, 23);
            this.fontFaceLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.fontFaceLabel.TabIndex = 13;
            this.fontFaceLabel.Text = "{$FONT_FACE$}";
            this.fontFaceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fontWeightCheckBox
            // 
            this.fontWeightCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fontWeightCheckBox.Location = new System.Drawing.Point(23, 312);
            this.fontWeightCheckBox.Name = "fontWeightCheckBox";
            this.fontWeightCheckBox.Size = new System.Drawing.Size(504, 15);
            this.fontWeightCheckBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.fontWeightCheckBox.TabIndex = 15;
            this.fontWeightCheckBox.Text = "{$FONT_WEIGHT$}";
            this.fontWeightCheckBox.UseSelectable = true;
            // 
            // fpsLimitTextBox
            // 
            this.fpsLimitTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.fpsLimitTextBox.CustomButton.Image = null;
            this.fpsLimitTextBox.CustomButton.Location = new System.Drawing.Point(28, 1);
            this.fpsLimitTextBox.CustomButton.Name = "";
            this.fpsLimitTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.fpsLimitTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fpsLimitTextBox.CustomButton.TabIndex = 1;
            this.fpsLimitTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fpsLimitTextBox.CustomButton.UseSelectable = true;
            this.fpsLimitTextBox.CustomButton.Visible = false;
            this.fpsLimitTextBox.Lines = new string[] {
        "50"};
            this.fpsLimitTextBox.Location = new System.Drawing.Point(477, 89);
            this.fpsLimitTextBox.MaxLength = 32767;
            this.fpsLimitTextBox.Name = "fpsLimitTextBox";
            this.fpsLimitTextBox.PasswordChar = '\0';
            this.fpsLimitTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fpsLimitTextBox.SelectedText = "";
            this.fpsLimitTextBox.SelectionLength = 0;
            this.fpsLimitTextBox.SelectionStart = 0;
            this.fpsLimitTextBox.ShortcutsEnabled = true;
            this.fpsLimitTextBox.Size = new System.Drawing.Size(50, 23);
            this.fpsLimitTextBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.fpsLimitTextBox.TabIndex = 4;
            this.fpsLimitTextBox.Text = "50";
            this.fpsLimitTextBox.UseSelectable = true;
            this.fpsLimitTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fpsLimitTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.fpsLimitTextBox.TextChanged += new System.EventHandler(this.fpsLimitTextBox_TextChanged);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okButton.Location = new System.Drawing.Point(23, 333);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(200, 23);
            this.okButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.okButton.TabIndex = 16;
            this.okButton.Text = "{$OK$}";
            this.okButton.UseSelectable = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(229, 333);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(298, 23);
            this.cancelButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "{$CANCEL$}";
            this.cancelButton.UseSelectable = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 379);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.fpsLimitTextBox);
            this.Controls.Add(this.fontWeightCheckBox);
            this.Controls.Add(this.fontFaceLabel);
            this.Controls.Add(this.noNametagStatusCheckBox);
            this.Controls.Add(this.audioProxyOffCheckBox);
            this.Controls.Add(this.audioMessageOffCheckBox);
            this.Controls.Add(this.directModeCheckBox);
            this.Controls.Add(this.multiCoreCheckBox);
            this.Controls.Add(this.imeCheckBox);
            this.Controls.Add(this.timestampCheckBox);
            this.Controls.Add(this.fpsLimitLabel);
            this.Controls.Add(this.pageSizeLabel);
            this.Controls.Add(this.fontFaceTextBox);
            this.Controls.Add(this.pageSizeTextBox);
            this.Controls.Add(this.fpsLimitTrackBar);
            this.Controls.Add(this.disableHeadMoveCheckBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(550, 379);
            this.Name = "OptionsForm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "{$OPTIONS_TITLE$}";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox disableHeadMoveCheckBox;
        private MetroFramework.Controls.MetroTrackBar fpsLimitTrackBar;
        private MetroFramework.Controls.MetroTextBox pageSizeTextBox;
        private MetroFramework.Controls.MetroTextBox fontFaceTextBox;
        private MetroFramework.Controls.MetroLabel pageSizeLabel;
        private MetroFramework.Controls.MetroLabel fpsLimitLabel;
        private MetroFramework.Controls.MetroCheckBox timestampCheckBox;
        private MetroFramework.Controls.MetroCheckBox imeCheckBox;
        private MetroFramework.Controls.MetroCheckBox multiCoreCheckBox;
        private MetroFramework.Controls.MetroCheckBox directModeCheckBox;
        private MetroFramework.Controls.MetroCheckBox audioMessageOffCheckBox;
        private MetroFramework.Controls.MetroCheckBox audioProxyOffCheckBox;
        private MetroFramework.Controls.MetroCheckBox noNametagStatusCheckBox;
        private MetroFramework.Controls.MetroLabel fontFaceLabel;
        private MetroFramework.Controls.MetroCheckBox fontWeightCheckBox;
        private MetroFramework.Controls.MetroTextBox fpsLimitTextBox;
        private MetroFramework.Controls.MetroButton okButton;
        private MetroFramework.Controls.MetroButton cancelButton;
    }
}