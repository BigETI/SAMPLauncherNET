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
            this.mainFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.usernameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.usernameSingleLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tempUsernameCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.serverPasswordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.serverPasswordSingleLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.connectButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cancelButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mainFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFlowLayoutPanel
            // 
            this.mainFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.mainFlowLayoutPanel.Controls.Add(this.usernameLabel);
            this.mainFlowLayoutPanel.Controls.Add(this.usernameSingleLineTextField);
            this.mainFlowLayoutPanel.Controls.Add(this.tempUsernameCheckBox);
            this.mainFlowLayoutPanel.Controls.Add(this.serverPasswordLabel);
            this.mainFlowLayoutPanel.Controls.Add(this.serverPasswordSingleLineTextField);
            this.mainFlowLayoutPanel.Controls.Add(this.connectButton);
            this.mainFlowLayoutPanel.Controls.Add(this.cancelButton);
            this.mainFlowLayoutPanel.Location = new System.Drawing.Point(5, 64);
            this.mainFlowLayoutPanel.Name = "mainFlowLayoutPanel";
            this.mainFlowLayoutPanel.Size = new System.Drawing.Size(462, 172);
            this.mainFlowLayoutPanel.TabIndex = 0;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Depth = 0;
            this.usernameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.usernameLabel.Location = new System.Drawing.Point(3, 0);
            this.usernameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(452, 23);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "{$USERNAME$}";
            // 
            // usernameSingleLineTextField
            // 
            this.usernameSingleLineTextField.Depth = 0;
            this.usernameSingleLineTextField.Hint = "...";
            this.usernameSingleLineTextField.Location = new System.Drawing.Point(3, 26);
            this.usernameSingleLineTextField.MaxLength = 32767;
            this.usernameSingleLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernameSingleLineTextField.Name = "usernameSingleLineTextField";
            this.usernameSingleLineTextField.PasswordChar = '\0';
            this.usernameSingleLineTextField.SelectedText = "";
            this.usernameSingleLineTextField.SelectionLength = 0;
            this.usernameSingleLineTextField.SelectionStart = 0;
            this.usernameSingleLineTextField.Size = new System.Drawing.Size(452, 23);
            this.usernameSingleLineTextField.TabIndex = 1;
            this.usernameSingleLineTextField.TabStop = false;
            this.usernameSingleLineTextField.UseSystemPasswordChar = false;
            this.usernameSingleLineTextField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.genericSingleLineTextField_KeyUp);
            // 
            // tempUsernameCheckBox
            // 
            this.tempUsernameCheckBox.Depth = 0;
            this.tempUsernameCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.tempUsernameCheckBox.Location = new System.Drawing.Point(0, 52);
            this.tempUsernameCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.tempUsernameCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.tempUsernameCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.tempUsernameCheckBox.Name = "tempUsernameCheckBox";
            this.tempUsernameCheckBox.Ripple = true;
            this.tempUsernameCheckBox.Size = new System.Drawing.Size(455, 23);
            this.tempUsernameCheckBox.TabIndex = 2;
            this.tempUsernameCheckBox.Text = "{$TEMPORARY_USERNAME$}";
            this.tempUsernameCheckBox.UseVisualStyleBackColor = true;
            // 
            // serverPasswordLabel
            // 
            this.serverPasswordLabel.Depth = 0;
            this.serverPasswordLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.serverPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.serverPasswordLabel.Location = new System.Drawing.Point(3, 75);
            this.serverPasswordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.serverPasswordLabel.Name = "serverPasswordLabel";
            this.serverPasswordLabel.Size = new System.Drawing.Size(452, 23);
            this.serverPasswordLabel.TabIndex = 3;
            this.serverPasswordLabel.Text = "{$SERVER_PASSWORD$}";
            // 
            // serverPasswordSingleLineTextField
            // 
            this.serverPasswordSingleLineTextField.Depth = 0;
            this.serverPasswordSingleLineTextField.Hint = "...";
            this.serverPasswordSingleLineTextField.Location = new System.Drawing.Point(3, 101);
            this.serverPasswordSingleLineTextField.MaxLength = 32767;
            this.serverPasswordSingleLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.serverPasswordSingleLineTextField.Name = "serverPasswordSingleLineTextField";
            this.serverPasswordSingleLineTextField.PasswordChar = '\0';
            this.serverPasswordSingleLineTextField.SelectedText = "";
            this.serverPasswordSingleLineTextField.SelectionLength = 0;
            this.serverPasswordSingleLineTextField.SelectionStart = 0;
            this.serverPasswordSingleLineTextField.Size = new System.Drawing.Size(452, 23);
            this.serverPasswordSingleLineTextField.TabIndex = 4;
            this.serverPasswordSingleLineTextField.TabStop = false;
            this.serverPasswordSingleLineTextField.UseSystemPasswordChar = false;
            this.serverPasswordSingleLineTextField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.genericSingleLineTextField_KeyUp);
            // 
            // connectButton
            // 
            this.connectButton.AutoSize = true;
            this.connectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.connectButton.Depth = 0;
            this.connectButton.Icon = null;
            this.connectButton.Location = new System.Drawing.Point(3, 130);
            this.connectButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.connectButton.Name = "connectButton";
            this.connectButton.Primary = true;
            this.connectButton.Size = new System.Drawing.Size(146, 36);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "{$CONNECT_NOW$}";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelButton.Depth = 0;
            this.cancelButton.Icon = null;
            this.cancelButton.Location = new System.Drawing.Point(155, 130);
            this.cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Primary = true;
            this.cancelButton.Size = new System.Drawing.Size(98, 36);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "{$CANCEL$}";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 248);
            this.Controls.Add(this.mainFlowLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(472, 248);
            this.MinimumSize = new System.Drawing.Size(472, 248);
            this.Name = "ConnectForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "{$CONNECT_TITLE$}";
            this.TopMost = true;
            this.mainFlowLayoutPanel.ResumeLayout(false);
            this.mainFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mainFlowLayoutPanel;
        private MaterialSkin.Controls.MaterialLabel usernameLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField usernameSingleLineTextField;
        private MaterialSkin.Controls.MaterialCheckBox tempUsernameCheckBox;
        private MaterialSkin.Controls.MaterialLabel serverPasswordLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField serverPasswordSingleLineTextField;
        private MaterialSkin.Controls.MaterialRaisedButton connectButton;
        private MaterialSkin.Controls.MaterialRaisedButton cancelButton;
    }
}