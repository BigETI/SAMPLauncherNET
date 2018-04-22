namespace SAMPLauncherNET
{
    partial class FilterUserControl
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.filterTextSingleLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.filterRadioGroupFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.filterUseRegexCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.deletePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.deletePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // filterTextSingleLineTextField
            // 
            this.filterTextSingleLineTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterTextSingleLineTextField.Depth = 0;
            this.filterTextSingleLineTextField.Hint = "...";
            this.filterTextSingleLineTextField.Location = new System.Drawing.Point(3, 3);
            this.filterTextSingleLineTextField.MaxLength = 32767;
            this.filterTextSingleLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.filterTextSingleLineTextField.Name = "filterTextSingleLineTextField";
            this.filterTextSingleLineTextField.PasswordChar = '\0';
            this.filterTextSingleLineTextField.SelectedText = "";
            this.filterTextSingleLineTextField.SelectionLength = 0;
            this.filterTextSingleLineTextField.SelectionStart = 0;
            this.filterTextSingleLineTextField.Size = new System.Drawing.Size(759, 23);
            this.filterTextSingleLineTextField.TabIndex = 0;
            this.filterTextSingleLineTextField.TabStop = false;
            this.filterTextSingleLineTextField.UseSystemPasswordChar = false;
            this.filterTextSingleLineTextField.TextChanged += new System.EventHandler(this.filterSingleLineTextField_TextChanged);
            // 
            // filterRadioGroupFlowLayoutPanel
            // 
            this.filterRadioGroupFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterRadioGroupFlowLayoutPanel.Location = new System.Drawing.Point(0, 32);
            this.filterRadioGroupFlowLayoutPanel.Name = "filterRadioGroupFlowLayoutPanel";
            this.filterRadioGroupFlowLayoutPanel.Size = new System.Drawing.Size(800, 30);
            this.filterRadioGroupFlowLayoutPanel.TabIndex = 6;
            // 
            // filterUseRegexCheckBox
            // 
            this.filterUseRegexCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.filterUseRegexCheckBox.AutoSize = true;
            this.filterUseRegexCheckBox.Depth = 0;
            this.filterUseRegexCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.filterUseRegexCheckBox.Location = new System.Drawing.Point(0, 65);
            this.filterUseRegexCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.filterUseRegexCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.filterUseRegexCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.filterUseRegexCheckBox.Name = "filterUseRegexCheckBox";
            this.filterUseRegexCheckBox.Ripple = true;
            this.filterUseRegexCheckBox.Size = new System.Drawing.Size(178, 30);
            this.filterUseRegexCheckBox.TabIndex = 7;
            this.filterUseRegexCheckBox.Text = "{$FILTER_USE_REGEX$}";
            this.filterUseRegexCheckBox.UseVisualStyleBackColor = true;
            this.filterUseRegexCheckBox.CheckedChanged += new System.EventHandler(this.filterUseRegexCheckBox_CheckedChanged);
            // 
            // deletePictureBox
            // 
            this.deletePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deletePictureBox.Image = global::SAMPLauncherNET.Properties.Resources.delete_icon;
            this.deletePictureBox.Location = new System.Drawing.Point(768, 0);
            this.deletePictureBox.Name = "deletePictureBox";
            this.deletePictureBox.Size = new System.Drawing.Size(32, 32);
            this.deletePictureBox.TabIndex = 8;
            this.deletePictureBox.TabStop = false;
            this.deletePictureBox.Click += new System.EventHandler(this.deletePictureBox_Click);
            this.deletePictureBox.MouseEnter += new System.EventHandler(this.genericPictureBox_MouseEnter);
            this.deletePictureBox.MouseLeave += new System.EventHandler(this.genericPictureBox_MouseLeave);
            // 
            // FilterUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.deletePictureBox);
            this.Controls.Add(this.filterUseRegexCheckBox);
            this.Controls.Add(this.filterRadioGroupFlowLayoutPanel);
            this.Controls.Add(this.filterTextSingleLineTextField);
            this.Name = "FilterUserControl";
            this.Size = new System.Drawing.Size(800, 95);
            ((System.ComponentModel.ISupportInitialize)(this.deletePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField filterTextSingleLineTextField;
        private System.Windows.Forms.FlowLayoutPanel filterRadioGroupFlowLayoutPanel;
        private MaterialSkin.Controls.MaterialCheckBox filterUseRegexCheckBox;
        private System.Windows.Forms.PictureBox deletePictureBox;
    }
}
