using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormsTranslator;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Favourites list form class
    /// </summary>
    public partial class FavouriteListsForm : MaterialForm
    {
        /// <summary>
        /// Selected server list connector
        /// </summary>
        public IndexedServerListConnector SelectedServerListConnector
        {
            get
            {
                return (IndexedServerListConnector)(favouritesListComboBox.SelectedItem);
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="favouriteLists">Favourite lists</param>
        public FavouriteListsForm(List<IndexedServerListConnector> favouriteLists)
        {
            InitializeComponent();
            Translator.LoadTranslation(this);
        }

        /// <summary>
        /// OK button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void okButton_Click(object sender, EventArgs e)
        {
            if (SelectedServerListConnector == null)
                MessageBox.Show(Translator.GetTranslation("FAVOURITE_LIST_NOT_SELECTED"), Translator.GetTranslation("FAVOURITE_LIST_NOT_SELECTED_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
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
