using INIEngine;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsTranslator;

namespace SAMPLauncherNET
{
    public partial class MainForm : MaterialForm
    {

        private MaterialSkinManager materialSkinManager = null;

        private List<KeyValuePair<Server, int>> loadServers = new List<KeyValuePair<Server, int>>();

        private List<KeyValuePair<Server, int>> loadedServers = new List<KeyValuePair<Server, int>>();

        private Dictionary<string, Server> registeredServers = new Dictionary<string, Server>();

        private Thread thread = null;

        private Thread rowThread = null;

        private bool rowThreadSuccess = false;

        private int[] serverCount = new int[] { 0, 0, 0 };

        private SAMPConfig config = Utils.SAMPConfig;

        public Server SelectedServer
        {
            get
            {
                Server ret = null;
                foreach (DataGridViewRow dgvr in serversGridView.SelectedRows)
                {
                    if (dgvr.Cells[dgvr.Cells.Count - 1].Value != null)
                    {
                        string ipp = dgvr.Cells[dgvr.Cells.Count - 1].Value.ToString();
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
            Translator.LoadTranslation(this);
            Translator.EnumerableToComboBox(languagesComboBox, Translator.TranslatorInterface.Languages);
            int i = 0;
            foreach (Language language in Translator.TranslatorInterface.Languages)
            {
                if (language.Culture == (string)(Properties.Settings.Default["Language"]))
                {
                    languagesComboBox.SelectedIndex = i;
                    break;
                }
                ++i;
            }

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue800, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange400, Primary.DeepOrange600, Primary.DeepOrange100, Accent.Orange100, TextShade.WHITE);

            galleryFileSystemWatcher.Path = Utils.GalleryPath;
            textFileSystemWatcher.Path = Utils.ConfigPath;

            lastChatlogTextBox.Text = Utils.Chatlog;
            savedPositionsTextBox.Text = Utils.SavedPositions;

            ReloadConfig();

            Dictionary<string, FavouriteServer> fl = Utils.FavouritesIO;
            serverCount[0] = fl.Count;
            foreach (FavouriteServer s in fl.Values)
                loadServers.Add(new KeyValuePair<Server, int>(s, 0));
            Dictionary<string, Server> l = Utils.FetchHostedList;
            serverCount[1] = l.Count;
            foreach (Server s in l.Values)
                loadServers.Add(new KeyValuePair<Server, int>(s, 1));
            l = Utils.FetchMasterList;
            serverCount[2] = l.Count;
            foreach (Server s in l.Values)
                loadServers.Add(new KeyValuePair<Server, int>(s, 2));
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

        private void UpdateServerCount()
        {
            StringBuilder sb = new StringBuilder(Translator.GetTranslation("SERVERS"));
            sb.Append(": ");
            bool first = true;
            for (int i = 0; i < 3; i++)
            {
                if (first)
                    first = false;
                else
                    sb.Append(", ");
                sb.Append(serversDataTable.Select("GroupID=" + i).Length.ToString());
                sb.Append("/");
                sb.Append(serverCount[i].ToString());
            }
            serverCountLabel.Text = sb.ToString();
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

        private void ReloadSelectedServerRow()
        {
            foreach (DataGridViewRow dgvr in serversGridView.SelectedRows)
            {
                if (dgvr.Cells[dgvr.Cells.Count - 1].Value != null)
                {
                    string ipp = dgvr.Cells[dgvr.Cells.Count - 1].Value.ToString();
                    if (registeredServers.ContainsKey(ipp))
                    {
                        Server server = registeredServers[ipp];
                        DateTime timestamp = DateTime.Now;
                        while ((!server.IsDataFetched(ERequestType.Ping)) && (!server.IsDataFetched(ERequestType.Information)))
                        {
                            if (DateTime.Now.Subtract(timestamp).TotalMilliseconds >= 1000)
                                break;
                        }
                        if (server.IsDataFetched(ERequestType.Ping))
                            dgvr.Cells[1].Value = server.Ping;
                        if (server.IsDataFetched(ERequestType.Information))
                        {
                            dgvr.Cells[2].Value = server.Hostname;
                            dgvr.Cells[3].Value = server.PlayerCount;
                            dgvr.Cells[4].Value = server.MaxPlayers;
                            dgvr.Cells[5].Value = server.Gamemode;
                            dgvr.Cells[6].Value = server.Language;
                        }
                        ReloadServerInfo();
                    }
                }
                break;
            }
        }

        private void ReloadServerInfo()
        {
            int si = 0;
            bool cs = false;
            Server server = SelectedServer;
            if (server != null)
            {
                foreach (DataGridViewRow dgvr in playersGridView.SelectedRows)
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
                    playersGridView.Rows[si].Selected = true;
                si = 0;
                cs = false;
                foreach (DataGridViewRow dgvr in rulesGridView.SelectedRows)
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
                    rulesGridView.Rows[si].Selected = true;
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

        private void UpdateServerListFilter()
        {
            int gid = 0;
            string ft = filterSingleLineTextField.Text.Trim();
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

        private void ReloadGallery()
        {
            if (mainTabControl.SelectedTab == galleryPage)
            {
                galleryListView.Clear();
                galleryImageList.Images.Clear();
                Dictionary<string, Image> images = Utils.GalleryImages;
                int i = 0;
                foreach (KeyValuePair<string, Image> kv in images)
                {
                    galleryImageList.Images.Add(kv.Value);
                    ListViewItem lvi = galleryListView.Items.Add(kv.Key.Substring(Utils.GalleryPath.Length + 1), i);
                    lvi.Tag = kv.Key;
                    ++i;
                }
            }
        }

        private void ViewSelectedImage()
        {
            foreach (ListViewItem item in galleryListView.SelectedItems)
            {
                string file_name = (string)(item.Tag);
                if (File.Exists(file_name))
                    Process.Start(file_name);
            }
        }

        private void DeleteSelectedImage()
        {
            List<string> files = new List<string>();
            foreach (ListViewItem item in galleryListView.SelectedItems)
            {
                string file_name = (string)(item.Tag);
                if (File.Exists(file_name))
                    files.Add(file_name);
            }
            if (files.Count > 0)
            {
                if (MessageBox.Show(Translator.GetTranslation("DELETE_SELECTED_IMAGES"), Translator.GetTranslation("DELETE_SELECTED_IMAGES_TITLE"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    galleryFileSystemWatcher.EnableRaisingEvents = false;
                    foreach (string file in files)
                    {
                        try
                        {
                            File.Delete(file);
                        }
                        catch
                        {
                            //
                        }
                    }
                    galleryFileSystemWatcher.EnableRaisingEvents = true;
                    ReloadGallery();
                }
            }
        }

        public void SaveConfig()
        {
            config.PageSize = int.Parse(pageSizeSingleLineTextField.Text);
            config.FPSLimit = fpsLimitTrackBar.Value;
            config.DisableHeadMovement = disableHeadMoveCheckBox.Checked;
            config.Timestamp = timestampCheckBox.Checked;
            config.IME = imeCheckBox.Checked;
            config.MultiCore = multiCoreCheckBox.Checked;
            config.DirectMode = directModeCheckBox.Checked;
            config.AudioMessageOff = audioMessageOffCheckBox.Checked;
            config.AudioProxyOff = audioProxyOffCheckBox.Checked;
            config.NoNametagStatus = noNametagStatusCheckBox.Checked;
            config.FontFace = fontFaceSingleLineTextField.Text;
            config.FontWeight = fontWeightCheckBox.Checked;
            config.Save();
        }

        private void ReloadConfig()
        {
            pageSizeSingleLineTextField.Text = config.PageSize.ToString();
            fpsLimitTrackBar.Value = config.FPSLimit;
            fpsLimitSingleLineTextField.Text = fpsLimitTrackBar.Value.ToString();
            disableHeadMoveCheckBox.Checked = config.DisableHeadMovement;
            timestampCheckBox.Checked = config.Timestamp;
            imeCheckBox.Checked = config.IME;
            multiCoreCheckBox.Checked = config.MultiCore;
            directModeCheckBox.Checked = config.DirectMode;
            audioMessageOffCheckBox.Checked = config.AudioMessageOff;
            audioProxyOffCheckBox.Checked = config.AudioProxyOff;
            noNametagStatusCheckBox.Checked = config.NoNametagStatus;
            fontFaceSingleLineTextField.Text = config.FontFace;
            fontWeightCheckBox.Checked = config.FontWeight;
        }

        private void serverListTimer_Tick(object sender, EventArgs e)
        {
            lock (loadedServers)
            {
                foreach (KeyValuePair<Server, int> kv in loadedServers)
                {
                    DataRow dr = serversDataTable.NewRow();
                    object[] row = new object[8];
                    row[0] = kv.Value;
                    if (kv.Key.IsDataFetched(ERequestType.Ping))
                        row[1] = kv.Key.Ping;
                    else
                        row[1] = 1000U;
                    if (kv.Key.IsDataFetched(ERequestType.Information))
                    {
                        row[2] = kv.Key.Hostname;
                        row[3] = kv.Key.PlayerCount;
                        row[4] = kv.Key.MaxPlayers;
                        row[5] = kv.Key.Gamemode;
                        row[6] = kv.Key.Language;
                    }
                    else
                    {
                        row[2] = "-";
                        row[3] = 0;
                        row[4] = 0;
                        row[5] = "-";
                        row[6] = "-";
                    }
                    row[7] = kv.Key.IPPortString;
                    dr.ItemArray = row;
                    serversDataTable.Rows.Add(dr);
                    if (!(registeredServers.ContainsKey(kv.Key.IPPortString)))
                        registeredServers.Add(kv.Key.IPPortString, kv.Key);
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

        private void serversGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            EnterRow();
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

        private void languagesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = languagesComboBox.SelectedIndex;
            if (i >= 0)
            {
                List<Language> langs = new List<Language>(Translator.TranslatorInterface.Languages);
                if (Translator.ChangeLanguage(langs[i]))
                    Application.Restart();
            }
        }

        private void gitHubProjectPictureBox_Click(object sender, EventArgs e)
        {
            Utils.OpenGitHubProject();
        }

        private void genericGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // null route
            e.ThrowException = false;
        }

        private void filterSingleLineTextField_TextChanged(object sender, EventArgs e)
        {
            UpdateServerListFilter();
        }

        private void filterGenericRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateServerListFilter();
        }

        private void genericPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void genericPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadGallery();
        }

        private void galleryFileSystemWatcher_GenericChanged(object sender, System.IO.FileSystemEventArgs e)
        {
            ReloadGallery();
        }

        private void galleryFileSystemWatcher_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            ReloadGallery();
        }

        private void galleryViewPictureBox_Click(object sender, EventArgs e)
        {
            ViewSelectedImage();
        }

        private void galleryDeletePictureBox_Click(object sender, EventArgs e)
        {
            DeleteSelectedImage();
        }

        private void galleryListView_DoubleClick(object sender, EventArgs e)
        {
            ViewSelectedImage();
        }

        private void showGalleryPictureBox_Click(object sender, EventArgs e)
        {
            Utils.ShowGallery();
        }

        private void galleryListView_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Return:
                    ViewSelectedImage();
                    break;
                case Keys.Delete:
                    DeleteSelectedImage();
                    break;
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void launchDebugModeButton_Click(object sender, EventArgs e)
        {
            Utils.LaunchSAMPDebugMode(closeWhenLaunchedCheckBox.Checked, this);
        }

        private void launchSingleplayerButton_Click(object sender, EventArgs e)
        {
            Utils.LaunchSingleplayerMode(closeWhenLaunchedCheckBox.Checked, this);
        }

        private void textFileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            switch (e.Name)
            {
                case "chatlog.txt":
                    lastChatlogTextBox.Text = Utils.Chatlog;
                    break;
                case "savedpositions.txt":
                    savedPositionsTextBox.Text = Utils.SavedPositions;
                    break;
            }
        }

        private void saveConfigButton_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void pageSizeSingleLineTextField_TextChanged(object sender, EventArgs e)
        {
            int v = 0;
            if (!(int.TryParse(pageSizeSingleLineTextField.Text, out v)))
                pageSizeSingleLineTextField.Text = "0";
        }

        private void fpsLimitTrackBar_ValueChanged(object sender, EventArgs e)
        {
            fpsLimitSingleLineTextField.Text = fpsLimitTrackBar.Value.ToString();
        }

        private void fpsLimitSingleLineTextField_TextChanged(object sender, EventArgs e)
        {
            int v = 0;
            if (int.TryParse(fpsLimitSingleLineTextField.Text, out v))
            {
                if (v < fpsLimitTrackBar.Minimum)
                    v = fpsLimitTrackBar.Minimum;
                else if (v > fpsLimitTrackBar.Maximum)
                    v = fpsLimitTrackBar.Maximum;
                if (fpsLimitSingleLineTextField.Text != v.ToString())
                    fpsLimitSingleLineTextField.Text = v.ToString();
                if (fpsLimitTrackBar.Value != v)
                    fpsLimitTrackBar.Value = v;
            }
            else
            {
                fpsLimitSingleLineTextField.Text = fpsLimitTrackBar.Minimum.ToString();
                fpsLimitTrackBar.Value = fpsLimitTrackBar.Minimum;
            }
        }

        private void revertConfigButton_Click(object sender, EventArgs e)
        {
            ReloadConfig();
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

        private void showGenericRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateServerListFilter();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void connectWithRCONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RCONPasswordForm rconf = new RCONPasswordForm();
            Connect(rconf.RCONPassword);
        }
    }
}
