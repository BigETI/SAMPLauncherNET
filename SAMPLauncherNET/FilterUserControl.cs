using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
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
        public event EventHandler FilterFilterEvent;

        /// <summary>
        /// On filter delete event
        /// </summary>
        public event EventHandler FilterDeleteEvent;

        /// <summary>
        /// Material radio button
        /// </summary>
        private List<MaterialRadioButton> radioButtons = new List<MaterialRadioButton>();

        /// <summary>
        /// Filter options
        /// </summary>
        private FilterOption[] filterOptions = new FilterOption[0];

        /// <summary>
        /// Filter text
        /// </summary>
        public string FilterText
        {
            get => (UseRegex ? filterTextSingleLineTextField.Text.Trim() : EscapeFilterString(filterTextSingleLineTextField.Text.Trim()));
            set
            {
                if (value != null)
                {
                    filterTextSingleLineTextField.Text = value;
                }
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
        public string Field
        {
            get
            {
                string ret = null;
                foreach (MaterialRadioButton radio_button in radioButtons)
                {
                    if (radio_button.Checked)
                    {
                        ret = (string)(radio_button.Tag);
                    }
                }
                if (ret == null)
                {
                    ret = "";
                }
                return ret;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="filterOptions">Filter options</param>
        public FilterUserControl()
        {
            InitializeComponent();
            Translator.LoadTranslation(this);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="filterOptions">Filter options</param>
        public FilterOption[] FilterOptions
        {
            get => filterOptions;
            set
            {
                filterRadioGroupFlowLayoutPanel.Controls.Clear();
                radioButtons.Clear();
                if (value == null)
                {
                    filterOptions = new FilterOption[0];
                }
                else
                {
                    uint i = 0U;
                    List<FilterOption> options = new List<FilterOption>();
                    foreach (FilterOption filter_option in value)
                    {
                        if (filter_option != null)
                        {
                            MaterialRadioButton radio_button = new MaterialRadioButton();
                            filterRadioGroupFlowLayoutPanel.Controls.Add(radio_button);
                            radio_button.AutoSize = true;
                            radio_button.Checked = (i == 0U);
                            radio_button.Depth = 0;
                            radio_button.Font = new System.Drawing.Font("Roboto", 10F);
                            radio_button.Location = new System.Drawing.Point(0, 0);
                            radio_button.Margin = new Padding(0);
                            radio_button.MouseLocation = new System.Drawing.Point(-1, -1);
                            radio_button.MouseState = MaterialSkin.MouseState.HOVER;
                            radio_button.Name = "filterRadioButton" + i;
                            radio_button.Ripple = true;
                            radio_button.Size = new System.Drawing.Size(178, 30);
                            radio_button.TabIndex = (int)i;
                            radio_button.TabStop = true;
                            radio_button.Text = filter_option.DisplayName;
                            radio_button.UseVisualStyleBackColor = true;
                            radio_button.CheckedChanged += filterGenericRadioButton_CheckedChanged;
                            radio_button.Tag = filter_option.Field;
                            radioButtons.Add(radio_button);
                            options.Add(filter_option);
                        }
                        ++i;
                    }
                    filterOptions = options.ToArray();
                    Translator.LoadTranslation(filterRadioGroupFlowLayoutPanel);
                }
            }
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
            if (FilterFilterEvent != null)
            {
                FilterFilterEvent.Invoke(this, e);
            }
        }

        /// <summary>
        /// Filter generic radio button checked changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void filterGenericRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (FilterFilterEvent != null)
            {
                FilterFilterEvent.Invoke(this, e);
            }
        }

        /// <summary>
        /// Delete picture box click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void deletePictureBox_Click(object sender, EventArgs e)
        {
            if (FilterDeleteEvent != null)
            {
                FilterDeleteEvent.Invoke(this, e);
            }
        }

        /// <summary>
        /// Filter use regex check box checked changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void filterUseRegexCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FilterFilterEvent != null)
            {
                FilterFilterEvent.Invoke(this, e);
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
