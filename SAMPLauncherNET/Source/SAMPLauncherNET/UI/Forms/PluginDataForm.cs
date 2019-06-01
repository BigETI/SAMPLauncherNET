using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using WinFormsTranslator;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Plugin data form
    /// </summary>
    public partial class PluginDataForm : MaterialForm
    {
        /// <summary>
        /// Plugin data
        /// </summary>
        public PluginDataContract PluginData
        {
            get
            {
                return new PluginDataContract(pluginNameSingleLineTextField.Text, (EPluginProvider)(pluginProviderComboBox.SelectedIndex), pluginURISingleLineTextField.Text, pluginEnabledCheckBox.Checked, (EUpdateFrequency)(pluginUpdateFrequencyComboBox.SelectedIndex));
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pluginData">Plugin data</param>
        public PluginDataForm(PluginDataContract pluginData)
        {
            InitializeComponent();
            Utils.Translator.TranslateControls(this);
            Translator.EnumToComboBox<EPluginProvider>(pluginProviderComboBox);
            Translator.EnumToComboBox<EUpdateFrequency>(pluginUpdateFrequencyComboBox);
            if (pluginData != null)
            {
                Text = Utils.Translator.GetTranslation("EDIT_PLUGIN_TITLE");
                pluginEnabledCheckBox.Checked = pluginData.Enabled;
                pluginNameSingleLineTextField.Text = pluginData.Name;
                pluginProviderComboBox.SelectedIndex = (int)(pluginData.Provider);
                pluginURISingleLineTextField.Text = pluginData.URI;
                pluginUpdateFrequencyComboBox.SelectedIndex = (int)(pluginData.UpdateFrequency);
            }
        }

        /// <summary>
        /// Accept input
        /// </summary>
        private void AcceptInput()
        {
            if (pluginNameSingleLineTextField.Text.Trim().Length <= 0)
            {
                MessageBox.Show(Utils.Translator.GetTranslation("PLUGIN_NAME_MISSING"), Utils.Translator.GetTranslation("PLUGIN_NAME_MISSING_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (pluginProviderComboBox.SelectedIndex < 0)
                {
                    MessageBox.Show(Utils.Translator.GetTranslation("PLUGIN_PROVIDER_MISSING"), Utils.Translator.GetTranslation("PLUGIN_PROVIDER_MISSING_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (pluginURISingleLineTextField.Text.Trim().Length <= 0)
                    {
                        MessageBox.Show(Utils.Translator.GetTranslation("PLUGIN_URI_MISSING"), Utils.Translator.GetTranslation("PLUGIN_URI_MISSING_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (pluginUpdateFrequencyComboBox.SelectedIndex < 0)
                        {
                            MessageBox.Show(Utils.Translator.GetTranslation("PLUGIN_UPDATE_FREQUENCY_MISSING"), Utils.Translator.GetTranslation("PLUGIN_UPDATE_FREQUENCY_MISSING_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Plugin generic single line text field key up event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Key event arguments</param>
        private void pluginGenericSingleLineTextField_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                AcceptInput();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        /// <summary>
        /// OK button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void okButton_Click(object sender, EventArgs e)
        {
            AcceptInput();
        }

        /// <summary>
        /// Cancel button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
