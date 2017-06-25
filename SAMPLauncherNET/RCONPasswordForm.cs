using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMPLauncherNET
{
    public partial class RCONPasswordForm : MetroForm
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
