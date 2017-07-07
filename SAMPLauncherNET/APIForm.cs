using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using WinFormsTranslator;

namespace SAMPLauncherNET
{
    public partial class APIForm : MaterialForm
    {

        public APIDataContract API
        {
            get
            {
                APIDataContract ret = new APIDataContract();
                ret.name = apiNameSingleLineTextField.Text;
                ret.type = ((EServerListType)(apiTypeComboBox.SelectedIndex)).ToString();
                ret.endpoint = apiEndpointSingleLineTextField.Text;
                return ret;
            }
        }

        public APIForm(APIDataContract api = null)
        {
            InitializeComponent();
            Translator.LoadTranslation(this);
            Translator.EnumToComboBox(apiTypeComboBox, new EServerListType[] { EServerListType.Error });
            if (api != null)
            {
                Text = Translator.GetTranslation("EDIT_API_TITLE");
                apiNameSingleLineTextField.Text = api.name;
                EServerListType type;
                if (!Enum.TryParse(api.type, out type))
                    type = EServerListType.Favourites;
                apiTypeComboBox.SelectedIndex = (int)type;
                apiEndpointSingleLineTextField.Text = api.endpoint;
            }
        }

        private void AcceptInput()
        {
            if (apiNameSingleLineTextField.Text.Trim().Length <= 0)
                MessageBox.Show(Translator.GetTranslation("API_NAME_MISSING"), Translator.GetTranslation("API_NAME_MISSING_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (apiTypeComboBox.SelectedIndex < 0)
                    MessageBox.Show(Translator.GetTranslation("API_TYPE_MISSING"), Translator.GetTranslation("API_TYPE_MISSING_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (apiEndpointSingleLineTextField.Text.Trim().Length <= 0)
                        MessageBox.Show(Translator.GetTranslation("API_ENDPOINT_MISSING"), Translator.GetTranslation("API_ENDPOINT_MISSING_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
            }
        }

        private void apiNameSingleLineTextField_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.Return:
                    AcceptInput();
                    break;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            AcceptInput();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
