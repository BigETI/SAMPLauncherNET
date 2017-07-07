namespace SAMPLauncherNET
{
    partial class APIForm
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
            this.apiNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.apiNameSingleLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.apiTypeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.apiTypeComboBox = new System.Windows.Forms.ComboBox();
            this.apiEndpointLabel = new MaterialSkin.Controls.MaterialLabel();
            this.apiEndpointSingleLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.okButton = new MaterialSkin.Controls.MaterialRaisedButton();
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
            this.mainFlowLayoutPanel.Controls.Add(this.apiNameLabel);
            this.mainFlowLayoutPanel.Controls.Add(this.apiNameSingleLineTextField);
            this.mainFlowLayoutPanel.Controls.Add(this.apiTypeLabel);
            this.mainFlowLayoutPanel.Controls.Add(this.apiTypeComboBox);
            this.mainFlowLayoutPanel.Controls.Add(this.apiEndpointLabel);
            this.mainFlowLayoutPanel.Controls.Add(this.apiEndpointSingleLineTextField);
            this.mainFlowLayoutPanel.Controls.Add(this.okButton);
            this.mainFlowLayoutPanel.Controls.Add(this.cancelButton);
            this.mainFlowLayoutPanel.Location = new System.Drawing.Point(5, 64);
            this.mainFlowLayoutPanel.Name = "mainFlowLayoutPanel";
            this.mainFlowLayoutPanel.Size = new System.Drawing.Size(456, 192);
            this.mainFlowLayoutPanel.TabIndex = 0;
            // 
            // apiNameLabel
            // 
            this.apiNameLabel.AutoSize = true;
            this.apiNameLabel.Depth = 0;
            this.apiNameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.apiNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.apiNameLabel.Location = new System.Drawing.Point(3, 0);
            this.apiNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.apiNameLabel.Name = "apiNameLabel";
            this.apiNameLabel.Size = new System.Drawing.Size(108, 19);
            this.apiNameLabel.TabIndex = 0;
            this.apiNameLabel.Text = "{$API_NAME$}";
            // 
            // apiNameSingleLineTextField
            // 
            this.apiNameSingleLineTextField.Depth = 0;
            this.apiNameSingleLineTextField.Hint = "...";
            this.apiNameSingleLineTextField.Location = new System.Drawing.Point(3, 22);
            this.apiNameSingleLineTextField.MaxLength = 32767;
            this.apiNameSingleLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.apiNameSingleLineTextField.Name = "apiNameSingleLineTextField";
            this.apiNameSingleLineTextField.PasswordChar = '\0';
            this.apiNameSingleLineTextField.SelectedText = "";
            this.apiNameSingleLineTextField.SelectionLength = 0;
            this.apiNameSingleLineTextField.SelectionStart = 0;
            this.apiNameSingleLineTextField.Size = new System.Drawing.Size(450, 23);
            this.apiNameSingleLineTextField.TabIndex = 1;
            this.apiNameSingleLineTextField.TabStop = false;
            this.apiNameSingleLineTextField.UseSystemPasswordChar = false;
            this.apiNameSingleLineTextField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.apiNameSingleLineTextField_KeyUp);
            // 
            // apiTypeLabel
            // 
            this.apiTypeLabel.AutoSize = true;
            this.apiTypeLabel.Depth = 0;
            this.apiTypeLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.apiTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.apiTypeLabel.Location = new System.Drawing.Point(3, 48);
            this.apiTypeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.apiTypeLabel.Name = "apiTypeLabel";
            this.apiTypeLabel.Size = new System.Drawing.Size(101, 19);
            this.apiTypeLabel.TabIndex = 2;
            this.apiTypeLabel.Text = "{$API_TYPE$}";
            // 
            // apiTypeComboBox
            // 
            this.apiTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.apiTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.apiTypeComboBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apiTypeComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.apiTypeComboBox.FormattingEnabled = true;
            this.apiTypeComboBox.Location = new System.Drawing.Point(3, 70);
            this.apiTypeComboBox.Name = "apiTypeComboBox";
            this.apiTypeComboBox.Size = new System.Drawing.Size(450, 28);
            this.apiTypeComboBox.TabIndex = 6;
            this.apiTypeComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.apiNameSingleLineTextField_KeyUp);
            // 
            // apiEndpointLabel
            // 
            this.apiEndpointLabel.AutoSize = true;
            this.apiEndpointLabel.Depth = 0;
            this.apiEndpointLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.apiEndpointLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.apiEndpointLabel.Location = new System.Drawing.Point(3, 101);
            this.apiEndpointLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.apiEndpointLabel.Name = "apiEndpointLabel";
            this.apiEndpointLabel.Size = new System.Drawing.Size(138, 19);
            this.apiEndpointLabel.TabIndex = 9;
            this.apiEndpointLabel.Text = "{$API_ENDPOINT$}";
            // 
            // apiEndpointSingleLineTextField
            // 
            this.apiEndpointSingleLineTextField.Depth = 0;
            this.apiEndpointSingleLineTextField.Hint = "...";
            this.apiEndpointSingleLineTextField.Location = new System.Drawing.Point(3, 123);
            this.apiEndpointSingleLineTextField.MaxLength = 32767;
            this.apiEndpointSingleLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.apiEndpointSingleLineTextField.Name = "apiEndpointSingleLineTextField";
            this.apiEndpointSingleLineTextField.PasswordChar = '\0';
            this.apiEndpointSingleLineTextField.SelectedText = "";
            this.apiEndpointSingleLineTextField.SelectionLength = 0;
            this.apiEndpointSingleLineTextField.SelectionStart = 0;
            this.apiEndpointSingleLineTextField.Size = new System.Drawing.Size(450, 23);
            this.apiEndpointSingleLineTextField.TabIndex = 10;
            this.apiEndpointSingleLineTextField.TabStop = false;
            this.apiEndpointSingleLineTextField.UseSystemPasswordChar = false;
            this.apiEndpointSingleLineTextField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.apiNameSingleLineTextField_KeyUp);
            // 
            // okButton
            // 
            this.okButton.AutoSize = true;
            this.okButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.okButton.Depth = 0;
            this.okButton.Icon = null;
            this.okButton.Location = new System.Drawing.Point(3, 152);
            this.okButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.okButton.Name = "okButton";
            this.okButton.Primary = true;
            this.okButton.Size = new System.Drawing.Size(64, 36);
            this.okButton.TabIndex = 11;
            this.okButton.Text = "{$OK$}";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelButton.Depth = 0;
            this.cancelButton.Icon = null;
            this.cancelButton.Location = new System.Drawing.Point(73, 152);
            this.cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Primary = true;
            this.cancelButton.Size = new System.Drawing.Size(98, 36);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "{$CANCEL$}";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // APIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 268);
            this.Controls.Add(this.mainFlowLayoutPanel);
            this.MaximumSize = new System.Drawing.Size(466, 268);
            this.MinimumSize = new System.Drawing.Size(466, 268);
            this.Name = "APIForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "{$NEW_API_TITLE$}";
            this.TopMost = true;
            this.mainFlowLayoutPanel.ResumeLayout(false);
            this.mainFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mainFlowLayoutPanel;
        private MaterialSkin.Controls.MaterialLabel apiNameLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField apiNameSingleLineTextField;
        private MaterialSkin.Controls.MaterialLabel apiTypeLabel;
        private System.Windows.Forms.ComboBox apiTypeComboBox;
        private MaterialSkin.Controls.MaterialLabel apiEndpointLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField apiEndpointSingleLineTextField;
        private MaterialSkin.Controls.MaterialRaisedButton okButton;
        private MaterialSkin.Controls.MaterialRaisedButton cancelButton;
    }
}