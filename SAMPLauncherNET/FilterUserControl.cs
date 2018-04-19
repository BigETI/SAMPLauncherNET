using System;
using System.Text;
using System.Windows.Forms;
using WinFormsTranslator;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Filter user control class
    /// </summary>
    public partial class FilterUserControl : UserControl
    {
        /// <summary>
        /// On filter filter event
        /// </summary>
        public EventHandler OnFilterFilterEvent;

        /// <summary>
        /// On filter delete event
        /// </summary>
        public EventHandler OnFilterDeleteEvent;

        /// <summary>
        /// FIlter text
        /// </summary>
        public string FilterText
        {
            get
            {
                return (UseRegex ? filterTextSingleLineTextField.Text.Trim() : EscapeFilterString(filterTextSingleLineTextField.Text.Trim()));
            }
        }

        /// <summary>
        /// Use regular expression
        /// </summary>
        public bool UseRegex
        {
            get
            {
                return filterUseRegexCheckBox.Checked;
            }
        }

        /// <summary>
        /// Filter type
        /// </summary>
        public EFilterType FilterType
        {
            get
            {
                EFilterType ret = EFilterType.Hostname;
                if (filterModeRadioButton.Checked)
                {
                    ret = EFilterType.Mode;
                }
                else if (filterLanguageRadioButton.Checked)
                {
                    ret = EFilterType.Language;
                }
                else if (filterIPAndPortRadioButton.Checked)
                {
                    ret = EFilterType.IPAndPort;
                }
                return ret;
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public FilterUserControl()
        {
            InitializeComponent();
            Translator.LoadTranslation(this);
        }

        /// <summary>
        /// Escape filter string
        /// </summary>
        /// <param name="str">String</param>
        /// <returns>Escaped filer string</returns>
        private static string EscapeFilterString(string str)
        {
            StringBuilder ret = new StringBuilder();
            foreach (char c in str)
            {
                switch (c)
                {
                    case '\'':
                    case '[':
                    case ']':
                    case '{':
                    case '}':
                        break;
                    case '\\':
                        ret.Append("\\\\");
                        break;
                    case '%':
                        ret.Append("\\%");
                        break;
                    default:
                        ret.Append(c, 1);
                        break;
                }
            }
            return ret.ToString();
        }

        /// <summary>
        /// Filter single line text field text changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void filterSingleLineTextField_TextChanged(object sender, EventArgs e)
        {
            if (OnFilterFilterEvent != null)
            {
                OnFilterFilterEvent.Invoke(this, e);
            }
        }

        /// <summary>
        /// Filter generic radio button checked changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void filterGenericRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (OnFilterFilterEvent != null)
            {
                OnFilterFilterEvent.Invoke(this, e);
            }
        }

        /// <summary>
        /// Delete picture box click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void deletePictureBox_Click(object sender, EventArgs e)
        {
            if (OnFilterDeleteEvent != null)
            {
                OnFilterDeleteEvent.Invoke(this, e);
            }
        }

        /// <summary>
        /// Filter use regex check box checked changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void filterUseRegexCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (OnFilterFilterEvent != null)
            {
                OnFilterFilterEvent.Invoke(this, e);
            }
        }

        /// <summary>
        /// Generic picture box mouse enter event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void genericPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        /// <summary>
        /// Generic picture box mouse leave event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void genericPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
