using MetroFramework.Forms;
using MetroTranslatorStyler;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SAMPLauncherNET
{
    public partial class ConnectForm : MetroForm
    {
        
        public string Username
        {
            get
            {
                return usernameTextBox.Text.Trim();
            }
        }

        public string ServerPassword
        {
            get
            {
                return serverPasswordTextBox.Text;
            }
        }

        public ConnectForm(bool noPasswordMode)
        {
            InitializeComponent();
            TranslatorStyler.LoadTranslationStyle(this, TranslatorStyler.TranslatorStylerInterface);
            usernameTextBox.Text = Utils.Username;
            if (noPasswordMode)
            {
                serverPasswordLabel.Visible = false;
                serverPasswordTextBox.Visible = false;
                MinimumSize = new Size(472, 182);
                Size = MinimumSize;
            }
        }

        private void AcceptInput()
        {
            if (Username.Length <= 0)
                MessageBox.Show(Translator.GetTranslation("PLEASE_TYPE_IN_USERNAME"), Translator.GetTranslation("INPUT_ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool success = true;
                if (serverPasswordTextBox.Visible && (ServerPassword.Trim().Length <= 0))
                    success = (MessageBox.Show(Translator.GetTranslation("SERVER_PASSWORD_FIELD_IS_EMPTY"), Translator.GetTranslation("SERVER_PASSWORD_FIELD_IS_EMPTY_TITLE"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes);
                if (success)
                {
                    if (!(tempUsernameCheckBox.Checked))
                        Utils.Username = Username;
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            AcceptInput();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void usernameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Return:
                    AcceptInput();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }
    }
}
