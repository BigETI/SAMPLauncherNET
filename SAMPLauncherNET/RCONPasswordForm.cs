using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using WinFormsTranslator;

namespace SAMPLauncherNET
{
    public partial class RCONPasswordForm : MaterialForm
    {

        public string RCONPassword
        {
            get
            {
                return rconPasswordTextBox.Text;
            }
        }

        public RCONPasswordForm()
        {
            InitializeComponent();
            Translator.LoadTranslation(this);
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rconPasswordTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Return:
                    DialogResult = DialogResult.OK;
                    Close();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }
    }
}
