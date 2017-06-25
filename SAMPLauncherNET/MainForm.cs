using MetroFramework.Forms;
using MetroTranslatorStyler;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System;
using System.Data;

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
                            if (kv.Key.IsRowDataFetched)
                            {
                                rlist.Add(kv);
                            }
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
            foreach (DataGridViewRow dgvr in serversGrid.SelectedRows)
            {
                string ipp = dgvr.Cells[dgvr.Cells.Count - 2].Value.ToString();
                if (registeredServers.ContainsKey(ipp))
                {
                    Server server = registeredServers[ipp];
                    if (server.IsRowRowPlayerAndRulesFetched)
                        ReloadSelectedServerRow();
                    else
                    {
                        serverInfoPanel.Visible = false;
                        serversSplitter.Visible = false;
                    }
                    rowThread = new Thread(() => RequestServerInfo(server));
                    rowThread.Start();
                    break;
                }
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
                string ipp = dgvr.Cells[dgvr.Cells.Count - 2].Value.ToString();
                if (registeredServers.ContainsKey(ipp))
                {
                    Server s = registeredServers[ipp];
                    DateTime timestamp = DateTime.Now;
                    while (s.IsRowDataNotFetched)
                    {
                        if (DateTime.Now.Subtract(timestamp).TotalMilliseconds >= 1000)
                            break;
                    }
                    object[] row = s.CachedRowData;
                    for (int i = 0; i < row.Length; i++)
                        dgvr.Cells[i].Value = row[i];
                    ReloadServerInfo();
                }
                break;
            }
            serverInfoPanel.Visible = true;
            serversSplitter.Visible = true;
        }

        private void RequestServerInfo(Server server)
        {
            while (true)
            {
                server.FetchRowPlayerAndRulesData();
                rowThreadSuccess = true;
                Thread.Sleep(2000);
            }
        }

        private void ReloadServerInfo()
        {
            int si = 0;
            bool cs = false;
            Server server = null;
            foreach (DataGridViewRow dgvr in playersGrid.SelectedRows)
            {
                si = dgvr.Index;
                break;
            }
            foreach (DataGridViewRow dgvr in serversGrid.SelectedRows)
            {
                string ipp = dgvr.Cells[dgvr.Cells.Count - 2].Value.ToString();
                if (registeredServers.ContainsKey(ipp))
                {
                    server = registeredServers[ipp];
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
                }
                break;
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
            if (server != null)
            {
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
            }
            if (cs)
                rulesGrid.Rows[si].Selected = true;
        }

        private void Connect(string rconPassword = null)
        {
            foreach (DataGridViewRow dgvr in serversGrid.SelectedRows)
            {
                string ipp = dgvr.Cells[dgvr.Cells.Count - 2].Value.ToString();
                if (registeredServers.ContainsKey(ipp))
                {
                    Server server = registeredServers[ipp];
                    ConnectForm cf = new ConnectForm(server.HasPassword);
                    DialogResult result = cf.ShowDialog();
                    DialogResult = DialogResult.None;
                    if (result == DialogResult.OK)
                        Utils.LaunchSAMP(server, cf.Username, server.HasPassword ? cf.ServerPassword : null, rconPassword, debugCheckBox.Checked, closeWhenLaunchedCheckBox.Checked, this);
                    break;
                }
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

        private void showGenericRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            int gid = 0;
            if (showHostedListRadioButton.Checked)
                gid = 1;
            else if (showMasterListRadioButton.Checked)
                gid = 2;
            serversBindingSource.Filter = "GroupID=" + gid;
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
                Properties.Settings.Default.Language = langs[i].Culture;
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

            serverListTimer.Stop();
            serverListTimer.Start();
        }
    }
}
