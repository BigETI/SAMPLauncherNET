namespace SAMPLauncherNET
{
    partial class ConnectHostForm
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
            this.mainFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addressLabel = new MaterialSkin.Controls.MaterialLabel();
            this.hostAndPortSingleLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.connectToAddressButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mainFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFlowLayoutPanel
            // 
            this.mainFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.mainFlowLayoutPanel.Controls.Add(this.addressLabel);
            this.mainFlowLayoutPanel.Controls.Add(this.hostAndPortSingleLineTextField);
            this.mainFlowLayoutPanel.Controls.Add(this.connectToAddressButton);
            this.mainFlowLayoutPanel.Location = new System.Drawing.Point(12, 64);
            this.mainFlowLayoutPanel.Name = "mainFlowLayoutPanel";
            this.mainFlowLayoutPanel.Size = new System.Drawing.Size(448, 96);
            this.mainFlowLayoutPanel.TabIndex = 0;
            // 
            // addressLabel
            // 
            this.addressLabel.Depth = 0;
            this.addressLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.addressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addressLabel.Location = new System.Drawing.Point(3, 0);
            this.addressLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(445, 23);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "{$HOST_AND_PORT$}";
            // 
            // hostAndPortSingleLineTextField
            // 
            this.hostAndPortSingleLineTextField.Depth = 0;
            this.hostAndPortSingleLineTextField.Hint = "...";
            this.hostAndPortSingleLineTextField.Location = new System.Drawing.Point(3, 26);
            this.hostAndPortSingleLineTextField.MaxLength = 32767;
            this.hostAndPortSingleLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.hostAndPortSingleLineTextField.Name = "hostAndPortSingleLineTextField";
            this.hostAndPortSingleLineTextField.PasswordChar = '\0';
            this.hostAndPortSingleLineTextField.SelectedText = "";
            this.hostAndPortSingleLineTextField.SelectionLength = 0;
            this.hostAndPortSingleLineTextField.SelectionStart = 0;
            this.hostAndPortSingleLineTextField.Size = new System.Drawing.Size(445, 23);
            this.hostAndPortSingleLineTextField.TabIndex = 3;
            this.hostAndPortSingleLineTextField.TabStop = false;
            this.hostAndPortSingleLineTextField.UseSystemPasswordChar = false;
            // 
            // connectToAddressButton
            // 
            this.connectToAddressButton.AutoSize = true;
            this.connectToAddressButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.connectToAddressButton.Depth = 0;
            this.connectToAddressButton.Icon = null;
            this.connectToAddressButton.Location = new System.Drawing.Point(3, 55);
            this.connectToAddressButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.connectToAddressButton.Name = "connectToAddressButton";
            this.connectToAddressButton.Primary = true;
            this.connectToAddressButton.Size = new System.Drawing.Size(199, 36);
            this.connectToAddressButton.TabIndex = 6;
            this.connectToAddressButton.Text = "{$CONNECT_TO_ADDRESS$}";
            this.connectToAddressButton.UseVisualStyleBackColor = true;
            this.connectToAddressButton.Click += new System.EventHandler(this.connectToAddressButton_Click);
            // 
            // ConnectHostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 172);
            this.Controls.Add(this.mainFlowLayoutPanel);
            this.MaximumSize = new System.Drawing.Size(472, 172);
            this.MinimumSize = new System.Drawing.Size(472, 172);
            this.Name = "ConnectHostForm";
            this.Sizable = false;
            this.Text = "{$CONNECT_TO_ADDRESS_TITLE$}";
            this.mainFlowLayoutPanel.ResumeLayout(false);
            this.mainFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mainFlowLayoutPanel;
        private MaterialSkin.Controls.MaterialLabel addressLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField hostAndPortSingleLineTextField;
        private MaterialSkin.Controls.MaterialRaisedButton connectToAddressButton;
    }
}