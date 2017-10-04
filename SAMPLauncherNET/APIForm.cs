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
    /// API form class
    /// </summary>
    public partial class APIForm : MaterialForm
    {
        /// <summary>
        /// API
        /// </summary>
        public APIDataContract API
        {
            get
            {
                return new APIDataContract(apiNameSingleLineTextField.Text, ((EServerListType)(apiTypeComboBox.SelectedIndex)).ToString(), apiEndpointSingleLineTextField.Text);
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="api"></param>
        public APIForm(APIDataContract api)
        {
            InitializeComponent();
            Translator.LoadTranslation(this);
            Translator.EnumToComboBox(apiTypeComboBox, new EServerListType[] { EServerListType.Error });
            if (api != null)
            {
                Text = Translator.GetTranslation("EDIT_API_TITLE");
                apiNameSingleLineTextField.Text = api.Name;
                EServerListType type;
                if (!Enum.TryParse(api.Type, out type))
                {
                    type = EServerListType.Favourites;
                }
                apiTypeComboBox.SelectedIndex = (int)type;
                apiEndpointSingleLineTextField.Text = api.Endpoint;
            }
        }

        /// <summary>
        /// Accept input
        /// </summary>
        private void AcceptInput()
        {
            if (apiNameSingleLineTextField.Text.Trim().Length <= 0)
            {
                MessageBox.Show(Translator.GetTranslation("API_NAME_MISSING"), Translator.GetTranslation("API_NAME_MISSING_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (apiTypeComboBox.SelectedIndex < 0)
                {
                    MessageBox.Show(Translator.GetTranslation("API_TYPE_MISSING"), Translator.GetTranslation("API_TYPE_MISSING_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (apiEndpointSingleLineTextField.Text.Trim().Length <= 0)
                    {
                        MessageBox.Show(Translator.GetTranslation("API_ENDPOINT_MISSING"), Translator.GetTranslation("API_ENDPOINT_MISSING_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
            }
        }

        /// <summary>
        /// API name single line text field key up event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Key event arguments</param>
        private void apiNameSingleLineTextField_KeyUp(object sender, KeyEventArgs e)
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
