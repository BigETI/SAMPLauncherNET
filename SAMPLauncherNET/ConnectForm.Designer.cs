namespace SAMPLauncherNET
{
    partial class ConnectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectForm));
            this.usernameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.usernameLabel = new MetroFramework.Controls.MetroLabel();
            this.connectButton = new MetroFramework.Controls.MetroButton();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.tempUsernameCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.serverPasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.serverPasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.usernameTextBox.CustomButton.Image = null;
            this.usernameTextBox.CustomButton.Location = new System.Drawing.Point(404, 1);
            this.usernameTextBox.CustomButton.Name = "";
            this.usernameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.usernameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.usernameTextBox.CustomButton.TabIndex = 1;
            this.usernameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usernameTextBox.CustomButton.UseSelectable = true;
            this.usernameTextBox.CustomButton.Visible = false;
            this.usernameTextBox.Lines = new string[0];
            this.usernameTextBox.Location = new System.Drawing.Point(23, 86);
            this.usernameTextBox.MaxLength = 32767;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PasswordChar = '\0';
            this.usernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.SelectionLength = 0;
            this.usernameTextBox.SelectionStart = 0;
            this.usernameTextBox.ShortcutsEnabled = true;
            this.usernameTextBox.Size = new System.Drawing.Size(426, 23);
            this.usernameTextBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.UseSelectable = true;
            this.usernameTextBox.WaterMark = "{$INSERT_USERNAME_HERE$}";
            this.usernameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usernameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.usernameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.usernameTextBox_KeyUp);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLabel.Location = new System.Drawing.Point(23, 60);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(426, 23);
            this.usernameLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "{$USERNAME$}";
            // 
            // connectButton
            // 
            this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.connectButton.Location = new System.Drawing.Point(23, 188);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(200, 23);
            this.connectButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "{$CONNECT_NOW$}";
            this.connectButton.UseSelectable = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(229, 188);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(220, 23);
            this.cancelButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "{$CANCEL$}";
            this.cancelButton.UseSelectable = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // tempUsernameCheckBox
            // 
            this.tempUsernameCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tempUsernameCheckBox.Location = new System.Drawing.Point(23, 115);
            this.tempUsernameCheckBox.Name = "tempUsernameCheckBox";
            this.tempUsernameCheckBox.Size = new System.Drawing.Size(426, 15);
            this.tempUsernameCheckBox.TabIndex = 2;
            this.tempUsernameCheckBox.Text = "{$TEMPORARY_USERNAME$}";
            this.tempUsernameCheckBox.UseSelectable = true;
            // 
            // serverPasswordTextBox
            // 
            this.serverPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.serverPasswordTextBox.CustomButton.Image = null;
            this.serverPasswordTextBox.CustomButton.Location = new System.Drawing.Point(404, 1);
            this.serverPasswordTextBox.CustomButton.Name = "";
            this.serverPasswordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.serverPasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.serverPasswordTextBox.CustomButton.TabIndex = 1;
            this.serverPasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.serverPasswordTextBox.CustomButton.UseSelectable = true;
            this.serverPasswordTextBox.CustomButton.Visible = false;
            this.serverPasswordTextBox.Lines = new string[0];
            this.serverPasswordTextBox.Location = new System.Drawing.Point(23, 159);
            this.serverPasswordTextBox.MaxLength = 32767;
            this.serverPasswordTextBox.Name = "serverPasswordTextBox";
            this.serverPasswordTextBox.PasswordChar = '\0';
            this.serverPasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.serverPasswordTextBox.SelectedText = "";
            this.serverPasswordTextBox.SelectionLength = 0;
            this.serverPasswordTextBox.SelectionStart = 0;
            this.serverPasswordTextBox.ShortcutsEnabled = true;
            this.serverPasswordTextBox.Size = new System.Drawing.Size(426, 23);
            this.serverPasswordTextBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.serverPasswordTextBox.TabIndex = 4;
            this.serverPasswordTextBox.UseSelectable = true;
            this.serverPasswordTextBox.WaterMark = "{$INSERT_SERVER_PASSWORD_HERE$}";
            this.serverPasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.serverPasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // serverPasswordLabel
            // 
            this.serverPasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverPasswordLabel.Location = new System.Drawing.Point(23, 133);
            this.serverPasswordLabel.Name = "serverPasswordLabel";
            this.serverPasswordLabel.Size = new System.Drawing.Size(426, 23);
            this.serverPasswordLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.serverPasswordLabel.TabIndex = 3;
            this.serverPasswordLabel.Text = "{$SERVER_PASSWORD$}";
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 234);
            this.Controls.Add(this.serverPasswordLabel);
            this.Controls.Add(this.serverPasswordTextBox);
            this.Controls.Add(this.tempUsernameCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(472, 234);
            this.Name = "ConnectForm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "{$CONNECT_TITLE$}";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox usernameTextBox;
        private MetroFramework.Controls.MetroLabel usernameLabel;
        private MetroFramework.Controls.MetroButton connectButton;
        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroCheckBox tempUsernameCheckBox;
        private MetroFramework.Controls.MetroTextBox serverPasswordTextBox;
        private MetroFramework.Controls.MetroLabel serverPasswordLabel;
    }
}