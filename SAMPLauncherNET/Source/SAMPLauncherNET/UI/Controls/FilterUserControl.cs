using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WinFormsTranslator;

/// <summary>
/// SA:MP launcher .NET UI namespace
/// </summary>
namespace SAMPLauncherNET.UI
{
    /// <summary>
    /// Filter user control class
    /// </summary>
    public partial class FilterUserControl : UserControl
    {
        /// <summary>
        /// On filter event
        /// </summary>
        public event EventHandler Filter;

        /// <summary>
        /// On filter delete event
        /// </summary>
        public event EventHandler FilterDelete;

        /// <summary>
        /// Material radio button
        /// </summary>
        private List<MaterialRadioButton> radioButtons = new List<MaterialRadioButton>();

        /// <summary>
        /// Filter options
        /// </summary>
        private FilterOption[] filterOptions = new FilterOption[0];

        /// <summary>
        /// Binding source
        /// </summary>
        private BindingSource bindingSource;

        /// <summary>
        /// Index field
        /// </summary>
        private string indexField = "";

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
        /// Binding source
        /// </summary>
        public BindingSource BindingSource
        {
            get
            {
                return bindingSource;
            }
            set
            {
                if (bindingSource != value)
                {
                    bindingSource = value;
                    UpdateFilter();
                }
            }
        }

        /// <summary>
        /// Index field
        /// </summary>
        public string IndexField
        {
            get
            {
                return indexField;
            }
            set
            {
                if (value != null)
                {
                    indexField = value;
                    UpdateFilter();
                }
            }
        }

        /// <summary>
        /// Update filter
        /// </summary>
        private void UpdateFilter()
        {
            if (bindingSource != null)
            {
                StringBuilder str = new StringBuilder();
                string filter_text = FilterText;
                if (filter_text.Length > 0)
                {
                    if (UseRegex)
                    {
                        try
                        {
                            Regex regex = new Regex(filter_text);
                            bool first = true;
                            if ((bindingSource.DataSource is DataSet) && (bindingSource.DataMember.Length > 0) && (indexField.Length > 0))
                            {
                                DataSet data_set = (DataSet)(bindingSource.DataSource);
                                string data_member = bindingSource.DataMember;
                                if (data_set.Tables.Contains(data_member))
                                {
                                    DataTable data_table = data_set.Tables[data_member];
                                    string field = Field;
                                    if (data_table.Columns.Contains(field) && data_table.Columns.Contains(indexField))
                                    {
                                        DataColumn data_column = data_table.Columns[field];
                                        DataColumn index_data_column = data_table.Columns[indexField];
                                        foreach (DataRow row in data_table.Rows)
                                        {
                                            object match_str_obj = row.Field<object>(data_column);
                                            if (match_str_obj != null)
                                            {
                                                string match_str = match_str_obj.ToString();
                                                if (regex.IsMatch(match_str))
                                                {
                                                    if (first)
                                                    {
                                                        str.Append("`");
                                                        str.Append(indexField);
                                                        str.Append("` IN (");
                                                        first = false;
                                                    }
                                                    else
                                                    {
                                                        str.Append(", ");
                                                    }
                                                    object index_obj = row.Field<object>(index_data_column);
                                                    str.Append("'");
                                                    str.Append((index_obj == null) ? "null" : index_obj.ToString());
                                                    str.Append("'");
                                                }
                                            }
                                        }
                                        if (first)
                                        {
                                            str.Append("`");
                                            str.Append(indexField);
                                            str.Append("` NOT '%'");
                                        }
                                        else
                                        {
                                            str.Append(")");
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Error.WriteLine(e.Message);
                        }
                    }
                    else
                    {
                        string field = Field;
                        if (field.Length > 0)
                        {
                            str.Append("`");
                            str.Append(field);
                            str.Append("` LIKE '%");
                            str.Append(FilterText);
                            str.Append("%'");
                        }
                    }
                }
                try
                {
                    Console.WriteLine(str.ToString());
                    bindingSource.Filter = str.ToString();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, Translator.GetTranslation("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            UpdateFilter();
            if (Filter != null)
            {
                Filter.Invoke(this, e);
            }
        }

        /// <summary>
        /// Filter generic radio button checked changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void filterGenericRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Filter != null)
            {
                Filter.Invoke(this, e);
            }
        }

        /// <summary>
        /// Delete picture box click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void deletePictureBox_Click(object sender, EventArgs e)
        {
            FilterText = "";
            if (FilterDelete != null)
            {
                FilterDelete.Invoke(this, e);
            }
        }

        /// <summary>
        /// Filter use regex check box checked changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void filterUseRegexCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Filter != null)
            {
                Filter.Invoke(this, e);
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
