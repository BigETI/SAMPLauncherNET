namespace SAMPLauncherNET
{
    partial class RCONPasswordForm
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
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.connectButton = new MetroFramework.Controls.MetroButton();
            this.rconPasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.rconPasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(229, 115);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(220, 23);
            this.cancelButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "{$CANCEL$}";
            this.cancelButton.UseSelectable = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.connectButton.Location = new System.Drawing.Point(23, 115);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(200, 23);
            this.connectButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "{$CONNECT$}";
            this.connectButton.UseSelectable = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // rconPasswordLabel
            // 
            this.rconPasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rconPasswordLabel.Location = new System.Drawing.Point(23, 60);
            this.rconPasswordLabel.Name = "rconPasswordLabel";
            this.rconPasswordLabel.Size = new System.Drawing.Size(426, 23);
            this.rconPasswordLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.rconPasswordLabel.TabIndex = 0;
            this.rconPasswordLabel.Text = "{$RCON_PASSWORD$}";
            // 
            // rconPasswordTextBox
            // 
            this.rconPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.rconPasswordTextBox.CustomButton.Image = null;
            this.rconPasswordTextBox.CustomButton.Location = new System.Drawing.Point(404, 1);
            this.rconPasswordTextBox.CustomButton.Name = "";
            this.rconPasswordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.rconPasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.rconPasswordTextBox.CustomButton.TabIndex = 1;
            this.rconPasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rconPasswordTextBox.CustomButton.UseSelectable = true;
            this.rconPasswordTextBox.CustomButton.Visible = false;
            this.rconPasswordTextBox.Lines = new string[0];
            this.rconPasswordTextBox.Location = new System.Drawing.Point(23, 86);
            this.rconPasswordTextBox.MaxLength = 32767;
            this.rconPasswordTextBox.Name = "rconPasswordTextBox";
            this.rconPasswordTextBox.PasswordChar = '\0';
            this.rconPasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rconPasswordTextBox.SelectedText = "";
            this.rconPasswordTextBox.SelectionLength = 0;
            this.rconPasswordTextBox.SelectionStart = 0;
            this.rconPasswordTextBox.ShortcutsEnabled = true;
            this.rconPasswordTextBox.Size = new System.Drawing.Size(426, 23);
            this.rconPasswordTextBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.rconPasswordTextBox.TabIndex = 1;
            this.rconPasswordTextBox.UseSelectable = true;
            this.rconPasswordTextBox.WaterMark = "{$INSERT_RCON_PASSWORD_HERE$}";
            this.rconPasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.rconPasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.rconPasswordTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rconPasswordTextBox_KeyUp);
            // 
            // RCONPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 161);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.rconPasswordLabel);
            this.Controls.Add(this.rconPasswordTextBox);
            this.MinimumSize = new System.Drawing.Size(472, 161);
            this.Name = "RCONPasswordForm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "{$RCON_PASSWORD_TITLE$}";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroButton connectButton;
        private MetroFramework.Controls.MetroLabel rconPasswordLabel;
        private MetroFramework.Controls.MetroTextBox rconPasswordTextBox;
    }
}