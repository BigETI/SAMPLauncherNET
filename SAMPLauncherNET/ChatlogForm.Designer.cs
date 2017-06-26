namespace SAMPLauncherNET
{
    partial class ChatlogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatlogForm));
            this.chatlogTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // chatlogTextBox
            // 
            this.chatlogTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.chatlogTextBox.CustomButton.Image = null;
            this.chatlogTextBox.CustomButton.Location = new System.Drawing.Point(202, 2);
            this.chatlogTextBox.CustomButton.Name = "";
            this.chatlogTextBox.CustomButton.Size = new System.Drawing.Size(389, 389);
            this.chatlogTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.chatlogTextBox.CustomButton.TabIndex = 1;
            this.chatlogTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.chatlogTextBox.CustomButton.UseSelectable = true;
            this.chatlogTextBox.CustomButton.Visible = false;
            this.chatlogTextBox.Lines = new string[0];
            this.chatlogTextBox.Location = new System.Drawing.Point(23, 63);
            this.chatlogTextBox.MaxLength = 32767;
            this.chatlogTextBox.Multiline = true;
            this.chatlogTextBox.Name = "chatlogTextBox";
            this.chatlogTextBox.PasswordChar = '\0';
            this.chatlogTextBox.ReadOnly = true;
            this.chatlogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.chatlogTextBox.SelectedText = "";
            this.chatlogTextBox.SelectionLength = 0;
            this.chatlogTextBox.SelectionStart = 0;
            this.chatlogTextBox.ShortcutsEnabled = true;
            this.chatlogTextBox.Size = new System.Drawing.Size(594, 394);
            this.chatlogTextBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.chatlogTextBox.TabIndex = 0;
            this.chatlogTextBox.UseSelectable = true;
            this.chatlogTextBox.WaterMark = "{$NO_CHATLOG_FOUND$}";
            this.chatlogTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.chatlogTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ChatlogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.chatlogTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChatlogForm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "{$LAST_CHATLOG_TITLE$}";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox chatlogTextBox;
    }
}