using MetroFramework.Forms;
using MetroTranslatorStyler;
using System;
using System.Windows.Forms;

namespace SAMPLauncherNET
{
    public partial class OptionsForm : MetroForm
    {

        private SAMPConfig config = new SAMPConfig(new INIFile(Utils.SAMPConfigPath));

        public OptionsForm()
        {
            InitializeComponent();
            TranslatorStyler.LoadTranslationStyle(this, TranslatorStyler.TranslatorStylerInterface);
            pageSizeTextBox.Text = config.PageSize.ToString();
            fpsLimitTrackBar.Value = config.FPSLimit;
            fpsLimitTextBox.Text = fpsLimitTrackBar.Value.ToString();
            disableHeadMoveCheckBox.Checked = config.DisableHeadMovement;
            timestampCheckBox.Checked = config.Timestamp;
            imeCheckBox.Checked = config.IME;
            multiCoreCheckBox.Checked = config.MultiCore;
            directModeCheckBox.Checked = config.DirectMode;
            audioMessageOffCheckBox.Checked = config.AudioMessageOff;
            audioProxyOffCheckBox.Checked = config.AudioProxyOff;
            noNametagStatusCheckBox.Checked = config.NoNametagStatus;
            fontFaceTextBox.Text = config.FontFace;
            fontWeightCheckBox.Checked = config.FontWeight;
        }

        public void Save()
        {
            config.PageSize = int.Parse(pageSizeTextBox.Text);
            config.FPSLimit = fpsLimitTrackBar.Value;
            config.DisableHeadMovement = disableHeadMoveCheckBox.Checked;
            config.Timestamp = timestampCheckBox.Checked;
            config.IME = imeCheckBox.Checked;
            config.MultiCore = multiCoreCheckBox.Checked;
            config.DirectMode = directModeCheckBox.Checked;
            config.AudioMessageOff = audioMessageOffCheckBox.Checked;
            config.AudioProxyOff = audioProxyOffCheckBox.Checked;
            config.NoNametagStatus = noNametagStatusCheckBox.Checked;
            config.FontFace = fontFaceTextBox.Text;
            config.FontWeight = fontWeightCheckBox.Checked;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Save();
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pageSizeTextBox_TextChanged(object sender, EventArgs e)
        {
            int v = 0;
            if (!(int.TryParse(pageSizeTextBox.Text, out v)))
                pageSizeTextBox.Text = "0";
        }

        private void fpsLimitTrackBar_ValueChanged(object sender, EventArgs e)
        {
            fpsLimitTextBox.Text = fpsLimitTrackBar.Value.ToString();
        }

        private void fpsLimitTextBox_TextChanged(object sender, EventArgs e)
        {
            int v = 0;
            if (int.TryParse(pageSizeTextBox.Text, out v))
            {
                if (v < fpsLimitTrackBar.Minimum)
                    v = fpsLimitTrackBar.Minimum;
                else if (v > fpsLimitTrackBar.Maximum)
                    v = fpsLimitTrackBar.Maximum;
                if (fpsLimitTextBox.Text != v.ToString())
                    fpsLimitTextBox.Text = v.ToString();
                if (fpsLimitTrackBar.Value != v)
                    fpsLimitTrackBar.Value = v;
            }
            else
            {
                fpsLimitTextBox.Text = fpsLimitTrackBar.Minimum.ToString();
                fpsLimitTrackBar.Value = fpsLimitTrackBar.Minimum;
            }
        }
    }
}
