namespace SAMPLauncherNET
{
    partial class PluginDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginDataForm));
            this.mainFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pluginEnabledCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.pluginNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.pluginNameSingleLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pluginProviderLabel = new MaterialSkin.Controls.MaterialLabel();
            this.pluginProviderComboBox = new System.Windows.Forms.ComboBox();
            this.pluginURILabel = new MaterialSkin.Controls.MaterialLabel();
            this.pluginURISingleLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pluginUpdateFrequencyLabel = new MaterialSkin.Controls.MaterialLabel();
            this.pluginUpdateFrequencyComboBox = new System.Windows.Forms.ComboBox();
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
            this.mainFlowLayoutPanel.Controls.Add(this.pluginEnabledCheckBox);
            this.mainFlowLayoutPanel.Controls.Add(this.pluginNameLabel);
            this.mainFlowLayoutPanel.Controls.Add(this.pluginNameSingleLineTextField);
            this.mainFlowLayoutPanel.Controls.Add(this.pluginProviderLabel);
            this.mainFlowLayoutPanel.Controls.Add(this.pluginProviderComboBox);
            this.mainFlowLayoutPanel.Controls.Add(this.pluginURILabel);
            this.mainFlowLayoutPanel.Controls.Add(this.pluginURISingleLineTextField);
            this.mainFlowLayoutPanel.Controls.Add(this.pluginUpdateFrequencyLabel);
            this.mainFlowLayoutPanel.Controls.Add(this.pluginUpdateFrequencyComboBox);
            this.mainFlowLayoutPanel.Controls.Add(this.okButton);
            this.mainFlowLayoutPanel.Controls.Add(this.cancelButton);
            this.mainFlowLayoutPanel.Location = new System.Drawing.Point(5, 64);
            this.mainFlowLayoutPanel.Name = "mainFlowLayoutPanel";
            this.mainFlowLayoutPanel.Size = new System.Drawing.Size(455, 275);
            this.mainFlowLayoutPanel.TabIndex = 1;
            // 
            // pluginEnabledCheckBox
            // 
            this.pluginEnabledCheckBox.Checked = true;
            this.pluginEnabledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pluginEnabledCheckBox.Depth = 0;
            this.pluginEnabledCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.pluginEnabledCheckBox.Location = new System.Drawing.Point(0, 0);
            this.pluginEnabledCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.pluginEnabledCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.pluginEnabledCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.pluginEnabledCheckBox.Name = "pluginEnabledCheckBox";
            this.pluginEnabledCheckBox.Ripple = true;
            this.pluginEnabledCheckBox.Size = new System.Drawing.Size(451, 30);
            this.pluginEnabledCheckBox.TabIndex = 0;
            this.pluginEnabledCheckBox.Text = "{$PLUGIN_ENABLED$}";
            this.pluginEnabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // pluginNameLabel
            // 
            this.pluginNameLabel.AutoSize = true;
            this.pluginNameLabel.Depth = 0;
            this.pluginNameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.pluginNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pluginNameLabel.Location = new System.Drawing.Point(3, 30);
            this.pluginNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.pluginNameLabel.Name = "pluginNameLabel";
            this.pluginNameLabel.Size = new System.Drawing.Size(137, 19);
            this.pluginNameLabel.TabIndex = 1;
            this.pluginNameLabel.Text = "{$PLUGIN_NAME$}";
            // 
            // pluginNameSingleLineTextField
            // 
            this.pluginNameSingleLineTextField.Depth = 0;
            this.pluginNameSingleLineTextField.Hint = "...";
            this.pluginNameSingleLineTextField.Location = new System.Drawing.Point(3, 52);
            this.pluginNameSingleLineTextField.MaxLength = 32767;
            this.pluginNameSingleLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.pluginNameSingleLineTextField.Name = "pluginNameSingleLineTextField";
            this.pluginNameSingleLineTextField.PasswordChar = '\0';
            this.pluginNameSingleLineTextField.SelectedText = "";
            this.pluginNameSingleLineTextField.SelectionLength = 0;
            this.pluginNameSingleLineTextField.SelectionStart = 0;
            this.pluginNameSingleLineTextField.Size = new System.Drawing.Size(450, 23);
            this.pluginNameSingleLineTextField.TabIndex = 2;
            this.pluginNameSingleLineTextField.TabStop = false;
            this.pluginNameSingleLineTextField.UseSystemPasswordChar = false;
            this.pluginNameSingleLineTextField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pluginGenericSingleLineTextField_KeyUp);
            // 
            // pluginProviderLabel
            // 
            this.pluginProviderLabel.AutoSize = true;
            this.pluginProviderLabel.Depth = 0;
            this.pluginProviderLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.pluginProviderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pluginProviderLabel.Location = new System.Drawing.Point(3, 78);
            this.pluginProviderLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.pluginProviderLabel.Name = "pluginProviderLabel";
            this.pluginProviderLabel.Size = new System.Drawing.Size(164, 19);
            this.pluginProviderLabel.TabIndex = 3;
            this.pluginProviderLabel.Text = "{$PLUGIN_PROVIDER$}";
            // 
            // pluginProviderComboBox
            // 
            this.pluginProviderComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pluginProviderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pluginProviderComboBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pluginProviderComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.pluginProviderComboBox.FormattingEnabled = true;
            this.pluginProviderComboBox.Location = new System.Drawing.Point(3, 100);
            this.pluginProviderComboBox.Name = "pluginProviderComboBox";
            this.pluginProviderComboBox.Size = new System.Drawing.Size(450, 28);
            this.pluginProviderComboBox.TabIndex = 4;
            // 
            // pluginURILabel
            // 
            this.pluginURILabel.AutoSize = true;
            this.pluginURILabel.Depth = 0;
            this.pluginURILabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.pluginURILabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pluginURILabel.Location = new System.Drawing.Point(3, 131);
            this.pluginURILabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.pluginURILabel.Name = "pluginURILabel";
            this.pluginURILabel.Size = new System.Drawing.Size(117, 19);
            this.pluginURILabel.TabIndex = 5;
            this.pluginURILabel.Text = "{$PLUGIN_URI$}";
            // 
            // pluginURISingleLineTextField
            // 
            this.pluginURISingleLineTextField.Depth = 0;
            this.pluginURISingleLineTextField.Hint = "...";
            this.pluginURISingleLineTextField.Location = new System.Drawing.Point(3, 153);
            this.pluginURISingleLineTextField.MaxLength = 32767;
            this.pluginURISingleLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.pluginURISingleLineTextField.Name = "pluginURISingleLineTextField";
            this.pluginURISingleLineTextField.PasswordChar = '\0';
            this.pluginURISingleLineTextField.SelectedText = "";
            this.pluginURISingleLineTextField.SelectionLength = 0;
            this.pluginURISingleLineTextField.SelectionStart = 0;
            this.pluginURISingleLineTextField.Size = new System.Drawing.Size(450, 23);
            this.pluginURISingleLineTextField.TabIndex = 6;
            this.pluginURISingleLineTextField.TabStop = false;
            this.pluginURISingleLineTextField.UseSystemPasswordChar = false;
            this.pluginURISingleLineTextField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pluginGenericSingleLineTextField_KeyUp);
            // 
            // pluginUpdateFrequencyLabel
            // 
            this.pluginUpdateFrequencyLabel.AutoSize = true;
            this.pluginUpdateFrequencyLabel.Depth = 0;
            this.pluginUpdateFrequencyLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.pluginUpdateFrequencyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pluginUpdateFrequencyLabel.Location = new System.Drawing.Point(3, 179);
            this.pluginUpdateFrequencyLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.pluginUpdateFrequencyLabel.Name = "pluginUpdateFrequencyLabel";
            this.pluginUpdateFrequencyLabel.Size = new System.Drawing.Size(243, 19);
            this.pluginUpdateFrequencyLabel.TabIndex = 7;
            this.pluginUpdateFrequencyLabel.Text = "{$PLUGIN_UPDATE_FREQUENCY$}";
            // 
            // pluginUpdateFrequencyComboBox
            // 
            this.pluginUpdateFrequencyComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pluginUpdateFrequencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pluginUpdateFrequencyComboBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pluginUpdateFrequencyComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.pluginUpdateFrequencyComboBox.FormattingEnabled = true;
            this.pluginUpdateFrequencyComboBox.Location = new System.Drawing.Point(3, 201);
            this.pluginUpdateFrequencyComboBox.Name = "pluginUpdateFrequencyComboBox";
            this.pluginUpdateFrequencyComboBox.Size = new System.Drawing.Size(450, 28);
            this.pluginUpdateFrequencyComboBox.TabIndex = 8;
            // 
            // okButton
            // 
            this.okButton.AutoSize = true;
            this.okButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.okButton.Depth = 0;
            this.okButton.Icon = null;
            this.okButton.Location = new System.Drawing.Point(3, 235);
            this.okButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.okButton.Name = "okButton";
            this.okButton.Primary = true;
            this.okButton.Size = new System.Drawing.Size(64, 36);
            this.okButton.TabIndex = 9;
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
            this.cancelButton.Location = new System.Drawing.Point(73, 235);
            this.cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Primary = true;
            this.cancelButton.Size = new System.Drawing.Size(98, 36);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "{$CANCEL$}";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // PluginDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 351);
            this.Controls.Add(this.mainFlowLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(465, 351);
            this.MinimumSize = new System.Drawing.Size(465, 351);
            this.Name = "PluginDataForm";
            this.Text = "{$NEW_PLUGIN_TITLE$}";
            this.mainFlowLayoutPanel.ResumeLayout(false);
            this.mainFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mainFlowLayoutPanel;
        private MaterialSkin.Controls.MaterialLabel pluginNameLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField pluginNameSingleLineTextField;
        private MaterialSkin.Controls.MaterialLabel pluginProviderLabel;
        private System.Windows.Forms.ComboBox pluginProviderComboBox;
        private MaterialSkin.Controls.MaterialLabel pluginURILabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField pluginURISingleLineTextField;
        private MaterialSkin.Controls.MaterialRaisedButton okButton;
        private MaterialSkin.Controls.MaterialRaisedButton cancelButton;
        private MaterialSkin.Controls.MaterialCheckBox pluginEnabledCheckBox;
        private MaterialSkin.Controls.MaterialLabel pluginUpdateFrequencyLabel;
        private System.Windows.Forms.ComboBox pluginUpdateFrequencyComboBox;
    }
}