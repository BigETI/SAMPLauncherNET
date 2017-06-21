using MetroFramework.Forms;
using MetroTranslatorStyler;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System;

namespace SAMPLauncherNET
{
    public partial class MainForm : MetroForm
    {

        public MainForm()
        {
            InitializeComponent();
            TranslatorStyler.LoadTranslationStyle(this, new TranslatorStylerInterface());
            TranslatorStyler.EnumerableToComboBox(languagesComboBox, TranslatorStyler.TranslatorStylerInterface.Languages);
            serverListView.BeginInvoke(new Action(delegate ()
                {
                    Dictionary<string, FavouriteServer> favs = Utils.FavouritesIO;
                    foreach (FavouriteServer fav in favs.Values)
                    {
                        ListViewItem lvi = serverListView.Items.Add("-");
                        lvi.Tag = fav;
                        lvi.Group = serverListView.Groups[0];
                        serverListView.BeginInvoke(new Action(() => FillListViewItem(lvi, fav)));
                    }
                    Dictionary<string, Server> list = Utils.FetchHostedList;
                    foreach (Server hosted in list.Values)
                    {
                        ListViewItem lvi = serverListView.Items.Add("-");
                        lvi.Tag = hosted;
                        lvi.Group = serverListView.Groups[1];
                        serverListView.BeginInvoke(new Action(() => FillListViewItem(lvi, hosted)));
                    }
                    list = Utils.FetchMasterList;
                    foreach (Server master in list.Values)
                    {
                        ListViewItem lvi = serverListView.Items.Add("-");
                        lvi.Tag = master;
                        lvi.Group = serverListView.Groups[2];
                        serverListView.BeginInvoke(new Action(() => FillListViewItem(lvi, master)));
                    }
                }));
        }

        private void FillListViewItem(ListViewItem listViewItem, Server server)
        {
            
            string[] data = server.CachedRowData;
            for (int i = 0; i < data.Length; i++)
            {
                if (i == 0)
                    listViewItem.Text = data[0];
                else
                    listViewItem.SubItems.Add(data[i]);
            }
            /*listViewItem.Text = server.Ping.ToString();
            listViewItem.SubItems.Add(server.Hostname);
            listViewItem.SubItems.Add(server.PlayerCount.ToString());
            listViewItem.SubItems.Add(server.MaxPlayers.ToString());
            listViewItem.SubItems.Add(server.Gamemode);
            listViewItem.SubItems.Add(server.Language);*/
        }

        private void showFavouritesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //serverListView.
        }

        private void serverListView_Click(object sender, EventArgs e)
        {
            serverListView.BeginInvoke(new Action(delegate()
            {
                foreach (ListViewItem lvi in serverListView.SelectedItems)
                {
                    if (lvi.Tag is Server)
                    {
                        Server server = (Server)(lvi.Tag);
                        string[] data = server.FetchRowData;
                        for (int i = 0; i < data.Length; i++)
                        {
                            if (i == 0)
                                lvi.Text = data[0];
                            else
                                lvi.SubItems[i].Text = data[i];
                        }
                    }
                }
            }));
        }

        private void testConnectButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in serverListView.SelectedItems)
            {
                if (lvi.Tag is Server)
                {
                    Utils.LaunchSAMP((Server)(lvi.Tag));
                    break;
                }
            }
                
        }
    }
}
