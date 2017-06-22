using MetroFramework.Forms;
using MetroTranslatorStyler;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System;
using System.Threading.Tasks;

namespace SAMPLauncherNET
{
    public partial class MainForm : MetroForm
    {

        private static readonly int ProcessorCount = Environment.ProcessorCount;

        private List<KeyValuePair<Server, int>> loadServers = new List<KeyValuePair<Server, int>>();

        private List<KeyValuePair<Server, int>> loadedServers = new List<KeyValuePair<Server, int>>();

        public MainForm()
        {
            InitializeComponent();
            TranslatorStyler.LoadTranslationStyle(this, new TranslatorStylerInterface());
            TranslatorStyler.EnumerableToComboBox(languagesComboBox, TranslatorStyler.TranslatorStylerInterface.Languages);
            Dictionary<string, FavouriteServer> fl = Utils.FavouritesIO;
            foreach (FavouriteServer s in fl.Values)
                loadServers.Add(new KeyValuePair<Server, int>(s, 0));
            Dictionary<string, Server> l = Utils.FetchHostedList;
            foreach (Server s in l.Values)
                loadServers.Add(new KeyValuePair<Server, int>(s, 1));
            l = Utils.FetchMasterList;
            foreach (Server s in l.Values)
                loadServers.Add(new KeyValuePair<Server, int>(s, 2));
            Thread t = new Thread(() =>
            {
                while (loadServers.Count > 0)
                {
                    List<KeyValuePair<Server, int>> rlist = new List<KeyValuePair<Server, int>>();
                    foreach (KeyValuePair<Server, int> kv in loadServers)
                    {
                        if (kv.Key.IsRowDataFetched)
                        {
                            rlist.Add(kv);
                        }
                    }
                    foreach (KeyValuePair<Server, int> kv in rlist)
                        loadServers.Remove(kv);
                    lock (loadedServers)
                    {
                        loadedServers.AddRange(rlist);
                    }
                    rlist.Clear();
                }
            });
            t.Start();
        }
        

        private void showFavouritesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //serverListView.
        }

        private void serverListView_Click(object sender, EventArgs e)
        {
            /*serverListView.BeginInvoke(new Action(delegate ()
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
            }));*/
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

        /*
        ListViewItem lvi = null;
                        for (int i = 0; i < d.Length; i++)
                        {
                            if (i == 0)
                            {
                                lvi = serverListView.Items.Add(d[0]);
                                KeyValuePair<Server, int> kv = servers[i];
                                lvi.Group = serverListView.Groups[kv.Value];
                                lvi.Tag = kv.Key;
                            }
                            else
                                lvi.SubItems.Add(d[i]);
                        }
            */

        private void serverListTimer_Tick(object sender, EventArgs e)
        {
            lock (loadedServers)
            {
                foreach (KeyValuePair<Server, int> kv in loadedServers)
                {
                    ListViewItem lvi = null;
                    string[] data = kv.Key.CachedRowData;
                    for (int i = 0; i < data.Length; i++)
                    {
                        if (i == 0)
                        {
                            lvi = serverListView.Items.Add(data[0]);
                            lvi.Group = serverListView.Groups[kv.Value];
                            lvi.Tag = kv.Key;
                        }
                        else
                            lvi.SubItems.Add(data[i]);
                    }
                }
                loadedServers.Clear();
            }
        }
    }
}
