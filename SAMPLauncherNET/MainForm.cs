using MetroFramework.Forms;
using MetroTranslatorStyler;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System;
using System.Data;
using System.Text;

namespace SAMPLauncherNET
{
    public partial class MainForm : MetroForm
    {

        private static readonly int ProcessorCount = Environment.ProcessorCount;

        private List<KeyValuePair<Server, int>> loadServers = new List<KeyValuePair<Server, int>>();

        private List<KeyValuePair<Server, int>> loadedServers = new List<KeyValuePair<Server, int>>();

        private Thread thread = null;

        private Thread rowThread = null;

        private bool rowThreadSuccess = false;

        private Dictionary<string, Server> registeredServers = new Dictionary<string, Server>();

        private int serverCount = 0;

        public Server SelectedServer
        {
            get
            {
                Server ret = null;
                foreach (DataGridViewRow dgvr in serversGrid.SelectedRows)
                {
                    if (dgvr.Cells[dgvr.Cells.Count - 2].Value != null)
                    {
                        string ipp = dgvr.Cells[dgvr.Cells.Count - 2].Value.ToString();
                        if (registeredServers.ContainsKey(ipp))
                        {
                            ret = registeredServers[ipp];
                            break;
                        }
                    }
                }
                return ret;
            }
        }

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
            serverCount = loadServers.Count;
            UpdateServerCount();
            thread = new Thread(() =>
            {
                while (loadServers.Count > 0)
                {
                    List<KeyValuePair<Server, int>> rlist = new List<KeyValuePair<Server, int>>();
                    lock (loadServers)
                    {
                        foreach (KeyValuePair<Server, int> kv in loadServers)
                        {
                            if (kv.Key.IsDataFetched(ERequestType.Ping) || kv.Key.IsDataFetched(ERequestType.Information))
                                rlist.Add(kv);
                        }
                        foreach (KeyValuePair<Server, int> kv in rlist)
                            loadServers.Remove(kv);
                    }
                    lock (loadedServers)
                    {
                        loadedServers.AddRange(rlist);
                    }
                    rlist.Clear();
                }
            });
            thread.Start();
        }

        private void EnterRow()
        {
            if (rowThread != null)
            {
                rowThread.Abort();
                rowThread = null;
            }
            rowThreadSuccess = false;
            Server server = SelectedServer;
            if (server != null)
            {
                if (server.IsDataFetched(ERequestType.Ping) && server.IsDataFetched(ERequestType.Information) && server.IsDataFetched(ERequestType.Rules) && server.IsDataFetched(ERequestType.Clients))
                    ReloadSelectedServerRow();
                rowThread = new Thread(() => RequestServerInfo(server));
                rowThread.Start();
            }
        }

        private void UpdateServerCount()
        {
            serverCountLabel.Text = Translator.GetTranslation("SERVERS") + ": " + serversDataTable.Rows.Count + "/" + serverCount;
        }

        private void ReloadSelectedServerRow()
        {
            foreach (DataGridViewRow dgvr in serversGrid.SelectedRows)
            {
                if (dgvr.Cells[dgvr.Cells.Count - 2].Value != null)
                {
                    string ipp = dgvr.Cells[dgvr.Cells.Count - 2].Value.ToString();
                    if (registeredServers.ContainsKey(ipp))
                    {
                        Server s = registeredServers[ipp];
                        DateTime timestamp = DateTime.Now;
                        while ((!s.IsDataFetched(ERequestType.Ping)) || (!s.IsDataFetched(ERequestType.Information)))
                        {
                            if (DateTime.Now.Subtract(timestamp).TotalMilliseconds >= 1000)
                                break;
                        }
                        object[] row = s.CachedRowData;
                        for (int i = 0; i < row.Length; i++)
                            dgvr.Cells[i].Value = row[i];
                        ReloadServerInfo();
                    }
                }
                break;
            }
        }

        private void RequestServerInfo(Server server)
        {
            while (true)
            {
                server.FetchMultiData(new ERequestType[] { ERequestType.Ping, ERequestType.Information, ERequestType.Clients, ERequestType.Rules });
                rowThreadSuccess = (server.IsDataFetched(ERequestType.Ping) && server.IsDataFetched(ERequestType.Information) && server.IsDataFetched(ERequestType.Clients) && server.IsDataFetched(ERequestType.Rules));
                Thread.Sleep(2000);
            }
        }

        private void ReloadServerInfo()
        {
            int si = 0;
            bool cs = false;
            Server server = SelectedServer;
            if (server != null)
            {
                foreach (DataGridViewRow dgvr in playersGrid.SelectedRows)
                {
                    si = dgvr.Index;
                    break;
                }
                playersDataTable.Clear();
                try
                {
                    int i = 0;
                    foreach (string client in server.ClientKeys)
                    {
                        DataRow dr = playersDataTable.NewRow();
                        object[] row = new object[2];
                        row[0] = client;
                        row[1] = server.GetScoreFromClient(client);
                        dr.ItemArray = row;
                        playersDataTable.Rows.Add(dr);
                        if (i == si)
                            cs = true;
                        ++i;
                    }
                }
                catch
                {
                    //
                }
                if (cs)
                    playersGrid.Rows[si].Selected = true;
                si = 0;
                cs = false;
                foreach (DataGridViewRow dgvr in rulesGrid.SelectedRows)
                {
                    si = dgvr.Index;
                    break;
                }
                rulesDataTable.Clear();
                try
                {
                    int i = 0;
                    foreach (string rule in server.RuleKeys)
                    {
                        DataRow dr = rulesDataTable.NewRow();
                        object[] row = new object[2];
                        row[0] = rule;
                        row[1] = server.GetRuleValue(rule);
                        dr.ItemArray = row;
                        rulesDataTable.Rows.Add(dr);
                        if (i == si)
                            cs = true;
                        ++i;
                    }
                }
                catch
                {
                    //
                }
                if (cs)
                    rulesGrid.Rows[si].Selected = true;
            }
        }

        private void Connect(string rconPassword = null)
        {
            Server server = SelectedServer;
            if (server != null)
            {
                ConnectForm cf = new ConnectForm(!(server.HasPassword));
                DialogResult result = cf.ShowDialog();
                DialogResult = DialogResult.None;
                if (result == DialogResult.OK)
                    Utils.LaunchSAMP(server, cf.Username, server.HasPassword ? cf.ServerPassword : null, rconPassword, false, closeWhenLaunchedCheckBox.Checked, this);
            }
        }

        private void UpdateServerListFilter()
        {
            int gid = 0;
            string ft = filterTextBox.Text.Trim();
            StringBuilder filter = new StringBuilder("GroupID=");
            if (showHostedListRadioButton.Checked)
                gid = 1;
            else if (showMasterListRadioButton.Checked)
                gid = 2;
            filter.Append(gid);
            if (ft.Length > 0)
            {
                if (filterHostnameRadioButton.Checked)
                    filter.Append(" AND `Hostname` LIKE '%");
                else if (filterModeRadioButton.Checked)
                    filter.Append(" AND `Mode` LIKE '%");
                else if (filterLanguageRadioButton.Checked)
                    filter.Append(" AND `Language` LIKE '%");
                else
                    filter.Append(" AND `IP and port` LIKE '%");
                filter.Append(ft);
                filter.Append("%'");
            }
            serversBindingSource.Filter = filter.ToString();
        }

        private void ReloadFavourites(Dictionary<string, FavouriteServer> servers)
        {
            DataRow[] rows = serversDataTable.Select("GroupID=0");
            foreach (DataRow row in rows)
                row.Delete();
            lock (loadServers)
            {
                foreach (FavouriteServer s in servers.Values)
                    loadServers.Add(new KeyValuePair<Server, int>(s, 0));
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void serverListTimer_Tick(object sender, EventArgs e)
        {
            lock (loadedServers)
            {
                foreach (KeyValuePair<Server, int> kv in loadedServers)
                {
                    DataRow dr = serversDataTable.NewRow();
                    object[] data = kv.Key.CachedRowData;
                    object[] row = new object[data.Length + 1];
                    for (int i = 0; i < data.Length; i++)
                        row[i] = data[i];
                    row[data.Length] = kv.Value;
                    dr.ItemArray = row;
                    serversDataTable.Rows.Add(dr);
                    string ipp = data[data.Length - 1].ToString();
                    if (!(registeredServers.ContainsKey(ipp)))
                        registeredServers.Add(ipp, kv.Key);
                }
                loadedServers.Clear();
                UpdateServerCount();
            }
            if (rowThreadSuccess)
            {
                rowThreadSuccess = false;
                ReloadSelectedServerRow();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            lock (loadServers)
            {
                foreach (KeyValuePair<Server, int> kv in loadServers)
                {
                    kv.Key.Dispose();
                }
                loadServers.Clear();
            }
            lock (loadedServers)
            {
                foreach (KeyValuePair<Server, int> kv in loadedServers)
                {
                    kv.Key.Dispose();
                }
                loadedServers.Clear();
            }
            if (thread != null)
            {
                thread.Abort();
                thread = null;
            }
            if (rowThread != null)
            {
                rowThread.Abort();
                rowThread = null;
            }
        }

        private void selectGenericListRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateServerListFilter();
        }

        private void serversGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            EnterRow();
        }

        private void launchSingleplayerModeButton_Click(object sender, EventArgs e)
        {
            Utils.LaunchSingleplayerMode(closeWhenLaunchedCheckBox.Checked, this);
        }

        private void launchDebugModeButton_Click(object sender, EventArgs e)
        {
            Utils.LaunchSAMPDebugMode(closeWhenLaunchedCheckBox.Checked, this);
        }

        private void optionsLink_Click(object sender, EventArgs e)
        {
            OptionsForm of = new OptionsForm();
            serverListTimer.Stop();
            of.ShowDialog();
            DialogResult = DialogResult.None;
            serverListTimer.Start();
        }

        private void showGalleryLink_Click(object sender, EventArgs e)
        {
            Utils.ShowGallery();
        }

        private void needHelpForumsLink_Click(object sender, EventArgs e)
        {
            Utils.OpenForums();
        }

        private void gitHubProjectLink_Click(object sender, EventArgs e)
        {
            Utils.OpenGitHubProject();
        }

        private void showLastChatLogLink_Click(object sender, EventArgs e)
        {
            ChatlogForm cf = new ChatlogForm();
            serverListTimer.Stop();
            cf.ShowDialog();
            DialogResult = DialogResult.None;
            serverListTimer.Start();
        }

        private void languagesComboBox_TextChanged(object sender, EventArgs e)
        {
            int i = languagesComboBox.SelectedIndex;
            if (i >= 0)
            {
                List<Language> langs = new List<Language>(TranslatorStyler.TranslatorStylerInterface.Languages);
                Properties.Settings.Default["Language"] = langs[i].Culture;
                Properties.Settings.Default.Save();
                Application.Restart();
            }
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void connectWithRCONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RCONPasswordForm rconf = new RCONPasswordForm();
            Connect();
        }

        private void showExtendedServerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Server server = SelectedServer;
            if (server != null)
            {
                serverListTimer.Stop();
                ExtendedServerInformationForm esif = new ExtendedServerInformationForm(server);
                esif.ShowDialog();
                DialogResult = DialogResult.None;
                serverListTimer.Start();
            }
        }

        private void filterGenericRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateServerListFilter();
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateServerListFilter();
        }

        private void addServerToFavouritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Server server = SelectedServer;
            if (server != null)
            {
                Dictionary<string, FavouriteServer> servers = Utils.FavouritesIO;
                if (servers.ContainsKey(server.IPPortString))
                    MessageBox.Show(Translator.GetTranslation("SERVER_ALREADY_IN_FAVOURITES"), Translator.GetTranslation("ALREADY_IN_FAVOURITES"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    servers.Add(server.IPPortString, server.ToFavouriteServer(server.Hostname));
                    Utils.FavouritesIO = servers;
                    ReloadFavourites(servers);
                }
            }
        }

        private void removeServerFromFavouritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Server server = SelectedServer;
            if (server != null)
            {
                Dictionary<string, FavouriteServer> servers = Utils.FavouritesIO;
                if (servers.ContainsKey(server.IPPortString))
                {
                    servers.Remove(server.IPPortString);
                    Utils.FavouritesIO = servers;
                    ReloadFavourites(servers);
                }
                else
                    MessageBox.Show(Translator.GetTranslation("SERVER_NOT_IN_FAVOURITES"), Translator.GetTranslation("NOT_IN_FAVOURITES"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
