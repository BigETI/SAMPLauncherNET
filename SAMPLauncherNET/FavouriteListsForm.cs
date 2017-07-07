using MaterialSkin.Controls;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormsTranslator;

namespace SAMPLauncherNET
{
    public partial class FavouriteListsForm : MaterialForm
    {
        
        public IndexedServerListConnector SelectedServerListConnector
        {
            get
            {
                return (IndexedServerListConnector)(favouritesListComboBox.SelectedItem);
            }
        }

        public FavouriteListsForm(List<IndexedServerListConnector> favouriteLists)
        {
            InitializeComponent();
            Translator.LoadTranslation(this);
            favouritesListComboBox.Items.AddRange(favouriteLists.ToArray());
        }

        private void okButton_Click(object sender, System.EventArgs e)
        {
            if (SelectedServerListConnector == null)
                MessageBox.Show(Translator.GetTranslation("FAVOURITE_LIST_NOT_SELECTED"), Translator.GetTranslation("FAVOURITE_LIST_NOT_SELECTED_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
