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
            this.rconPasswordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.rconPasswordTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.connectButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cancelButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // rconPasswordLabel
            // 
            this.rconPasswordLabel.AutoSize = true;
            this.rconPasswordLabel.Depth = 0;
            this.rconPasswordLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.rconPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rconPasswordLabel.Location = new System.Drawing.Point(12, 70);
            this.rconPasswordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.rconPasswordLabel.Name = "rconPasswordLabel";
            this.rconPasswordLabel.Size = new System.Drawing.Size(161, 19);
            this.rconPasswordLabel.TabIndex = 0;
            this.rconPasswordLabel.Text = "{$RCON_PASSWORD$}";
            // 
            // rconPasswordTextBox
            // 
            this.rconPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rconPasswordTextBox.Depth = 0;
            this.rconPasswordTextBox.Hint = "";
            this.rconPasswordTextBox.Location = new System.Drawing.Point(16, 92);
            this.rconPasswordTextBox.MaxLength = 32767;
            this.rconPasswordTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.rconPasswordTextBox.Name = "rconPasswordTextBox";
            this.rconPasswordTextBox.PasswordChar = '\0';
            this.rconPasswordTextBox.SelectedText = "";
            this.rconPasswordTextBox.SelectionLength = 0;
            this.rconPasswordTextBox.SelectionStart = 0;
            this.rconPasswordTextBox.Size = new System.Drawing.Size(472, 23);
            this.rconPasswordTextBox.TabIndex = 1;
            this.rconPasswordTextBox.TabStop = false;
            this.rconPasswordTextBox.Text = "...";
            this.rconPasswordTextBox.UseSystemPasswordChar = false;
            this.rconPasswordTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rconPasswordTextBox_KeyUp);
            // 
            // connectButton
            // 
            this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.connectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.connectButton.Depth = 0;
            this.connectButton.Icon = null;
            this.connectButton.Location = new System.Drawing.Point(12, 121);
            this.connectButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.connectButton.Name = "connectButton";
            this.connectButton.Primary = true;
            this.connectButton.Size = new System.Drawing.Size(200, 36);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "{$CONNECT$}";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelButton.Depth = 0;
            this.cancelButton.Icon = null;
            this.cancelButton.Location = new System.Drawing.Point(218, 121);
            this.cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Primary = true;
            this.cancelButton.Size = new System.Drawing.Size(270, 36);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "{$CANCEL$}";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // RCONPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 169);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.rconPasswordTextBox);
            this.Controls.Add(this.rconPasswordLabel);
            this.Name = "RCONPasswordForm";
            this.Sizable = false;
            this.Text = "{$RCON_PASSWORD_TITLE$}";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel rconPasswordLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField rconPasswordTextBox;
        private MaterialSkin.Controls.MaterialRaisedButton connectButton;
        private MaterialSkin.Controls.MaterialRaisedButton cancelButton;
    }
}