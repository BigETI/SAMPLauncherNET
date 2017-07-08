using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
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

        private List<ServerListConnector> api = new List<ServerListConnector>();

        private SAMPConfig config = SAMP.SAMPConfig;

        private bool queryFirstServer = true;

        private int selectedAPIIndex = -1;

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

        private bool IsInFavouriteList
        {
            get
            {
                bool ret = false;
                if ((selectedAPIIndex >= 0) && (selectedAPIIndex < api.Count))
                {
                    ServerListConnector slc = api[selectedAPIIndex];
                    ret = ((slc.ServerListType == EServerListType.Favourites) || (slc.ServerListType == EServerListType.LegacyFavourites));
                }
                return ret;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            Size sz = revertConfigButton.Size;
            Translator.LoadTranslation(this);
            revertConfigButton.Location = new Point(revertConfigButton.Location.X + (sz.Width - revertConfigButton.Size.Width), revertConfigButton.Location.Y);
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

            galleryFileSystemWatcher.Path = SAMP.GalleryPath;
            textFileSystemWatcher.Path = SAMP.ConfigPath;

            lastChatlogTextBox.Text = SAMP.Chatlog;
            savedPositionsTextBox.Text = SAMP.SavedPositions;

            ReloadConfig();
            ReloadAPI();
            thread = new Thread(() =>
            {
                while (true)
                {
                    List<KeyValuePair<Server, int>> rlist = new List<KeyValuePair<Server, int>>();
                    lock (loadServers)
                    {
                        foreach (KeyValuePair<Server, int> kv in loadServers)
                        {
                            if (kv.Key.IsDataFetched(ERequestType.Ping) || kv.Key.IsDataFetched(ERequestType.Information))
                                rlist.Add(kv);
                            else
                            {
                                kv.Key.SendQueryWhenExpired(ERequestType.Ping, 5000U);
                                kv.Key.SendQueryWhenExpired(ERequestType.Information, 5000U);
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

        private void ClearAPI()
        {
            selectAPIComboBox.Items.Clear();
            selectedAPIIndex = -1;
            lock (api)
            {
                api.Clear();
            }
            apiDataTable.Clear();
            lock (loadServers)
            {
                loadServers.Clear();
            }
            lock (loadedServers)
            {
                loadedServers.Clear();
            }
            lock (registeredServers)
            {
                registeredServers.Clear();
            }
            serversDataTable.Clear();
        }

        private void ReloadAPI()
        {
            ClearAPI();
            lock (api)
            {
                api.AddRange(SAMP.APIIO);
                selectAPIComboBox.Items.AddRange(api.ToArray());
                lock (apiDataTable)
                {
                    for (int i = 0; i < api.Count; i++)
                    {
                        DataRow dr = apiDataTable.NewRow();
                        ServerListConnector slc = api[i];
                        dr.ItemArray = new object[] { i, slc.Name, slc.ServerListType.ToString(), slc.Endpoint };
                        apiDataTable.Rows.Add(dr);
                    }
                }
                if (api.Count > 0)
                {
                    selectAPIComboBox.SelectedIndex = 0;
                    Translator.LoadTranslation(selectAPIComboBox);
                }
            }
        }

        private void SelectAPI()
        {
            int index = selectAPIComboBox.SelectedIndex;
            if ((index >= 0) && (index < api.Count))
            {
                lock (loadServers)
                {
                    queryFirstServer = true;
                    ServerListConnector slc = api[index];
                    if (slc.NotLoaded)
                    {
                        slc.NotLoaded = false;
                        Dictionary<string, Server> l = slc.ServerListIO;
                        foreach (Server server in l.Values)
                            loadServers.Add(new KeyValuePair<Server, int>(server, index));
                    }
                }
                UpdateServerListFilter();
                UpdateServerCount();
                EnterRow();
            }
        }

        private void UpdateServerCount()
        {
            uint c = 0U;
            int index = selectedAPIIndex;
            if ((index >= 0) && (index < api.Count))
                c = api[index].ServerCount;
            serverCountLabel.Text = Translator.GetTranslation("SERVERS") + ": " + c;
        }

        private bool EnterRow()
        {
            bool ret = false;
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
                ret = true;
            }
            return ret;
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
                            dgvr.Cells[3].Value = server.PlayerCount + "/" + server.MaxPlayers;
                            dgvr.Cells[4].Value = server.Gamemode;
                            dgvr.Cells[5].Value = server.Language;
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

        private string EscapeFilterString(string str)
        {
            StringBuilder ret = new StringBuilder();
            foreach (char c in str.ToCharArray())
            {
                switch (c)
                {
                    case '\'':
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

        private void UpdateServerListFilter()
        {
            string ft = EscapeFilterString(filterSingleLineTextField.Text.Trim());
            StringBuilder filter = new StringBuilder("GroupID=");
            filter.Append(selectedAPIIndex.ToString());
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
            EnterRow();
        }

        private void ReloadFavourites(Dictionary<string, Server> servers, int index)
        {
            DataRow[] rows = serversDataTable.Select("GroupID=" + index);
            foreach (DataRow row in rows)
                row.Delete();
            lock (loadServers)
            {
                foreach (Server server in servers.Values)
                    loadServers.Add(new KeyValuePair<Server, int>(server, index));
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
                    SAMP.LaunchSAMP(server, cf.Username, server.HasPassword ? cf.ServerPassword : null, rconPassword, false, closeWhenLaunchedCheckBox.Checked, this);
            }
        }

        private void ReloadGallery()
        {
            if (mainTabControl.SelectedTab == galleryPage)
            {
                galleryListView.Clear();
                galleryImageList.Images.Clear();
                Dictionary<string, Image> images = SAMP.GalleryImages;
                int i = 0;
                foreach (KeyValuePair<string, Image> kv in images)
                {
                    galleryImageList.Images.Add(kv.Value);
                    ListViewItem lvi = galleryListView.Items.Add(kv.Key.Substring(SAMP.GalleryPath.Length + 1), i);
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

        private void AddSelectedAPI()
        {
            APIForm apif = new APIForm();
            DialogResult result = apif.ShowDialog();
            DialogResult = DialogResult.None;
            if (result == DialogResult.OK)
            {
                List<ServerListConnector> api = SAMP.APIIO;
                api.Add(new ServerListConnector(apif.API));
                SAMP.APIIO = api;
                ReloadAPI();
            }
        }

        private void EditSelectedAPI()
        {
            foreach (DataGridViewRow dgvr in apiGridView.SelectedRows)
            {
                int index = (int)(dgvr.Cells[0].Value);
                if ((index >= 0) && (index < api.Count))
                {
                    ServerListConnector slc = api[index];
                    APIForm apif = new APIForm(slc.APIDataContract);
                    DialogResult result = apif.ShowDialog();
                    DialogResult = DialogResult.None;
                    if (result == DialogResult.OK)
                    {
                        api[index] = new ServerListConnector(apif.API);
                        SAMP.APIIO = api;
                        ReloadAPI();
                    }
                }
                break;
            }
        }

        private void RemoveSelectedAPI()
        {
            if (MessageBox.Show(Translator.GetTranslation("REMOVE_API"), Translator.GetTranslation("REMOVE_API_TITLE"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow dgvr in apiGridView.SelectedRows)
                {
                    int index = (int)(dgvr.Cells[0].Value);
                    if ((index >= 0) && (index < api.Count))
                    {
                        api.RemoveAt(index);
                        SAMP.APIIO = api;
                        ReloadAPI();
                    }
                    break;
                }
            }
        }

        private void RemoveSelectionFromFavourites(bool promptWhenError = true)
        {
            if (IsInFavouriteList)
            {
                Server server = SelectedServer;
                if (server != null)
                {
                    if (MessageBox.Show(Translator.GetTranslation("REMOVE_SERVER_FROM_FAVOURITES"), Translator.GetTranslation("REMOVE_SERVER_FROM_FAVOURITES_TITLE"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Dictionary<string, Server> servers = api[selectedAPIIndex].ServerListIO;
                        if (servers.ContainsKey(server.IPPortString))
                        {
                            servers.Remove(server.IPPortString);
                            api[selectedAPIIndex].ServerListIO = servers;
                            ReloadFavourites(servers, selectedAPIIndex);
                        }
                    }
                }
            }
            else if (promptWhenError)
                MessageBox.Show(Translator.GetTranslation("SERVER_NOT_IN_FAVOURITES"), Translator.GetTranslation("NOT_IN_FAVOURITES"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void serverListTimer_Tick(object sender, EventArgs e)
        {
            lock (loadedServers)
            {
                foreach (KeyValuePair<Server, int> kv in loadedServers)
                {
                    DataRow dr = serversDataTable.NewRow();
                    object[] row = new object[7];
                    row[0] = kv.Value;
                    if (kv.Key.IsDataFetched(ERequestType.Ping))
                        row[1] = kv.Key.Ping;
                    else
                        row[1] = 1000U;
                    if (kv.Key.IsDataFetched(ERequestType.Information))
                    {
                        row[2] = kv.Key.Hostname;
                        row[3] = kv.Key.PlayerCount + "/" + kv.Key.MaxPlayers;
                        row[4] = kv.Key.Gamemode;
                        row[5] = kv.Key.Language;
                    }
                    else
                    {
                        row[2] = "-";
                        row[3] = "0/0";
                        row[4] = "-";
                        row[5] = "-";
                    }
                    row[6] = kv.Key.IPPortString;
                    dr.ItemArray = row;
                    serversDataTable.Rows.Add(dr);
                    if (!(registeredServers.ContainsKey(kv.Key.IPPortString)))
                        registeredServers.Add(kv.Key.IPPortString, kv.Key);
                    if (queryFirstServer)
                        queryFirstServer = !(EnterRow());
                    lock (api)
                    {
                        if ((kv.Value >= 0) && (kv.Value < api.Count))
                            ++api[kv.Value].ServerCount;
                    }
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
            SAMP.OpenGitHubProject();
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
            SAMP.ShowGallery();
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
            SAMP.LaunchSAMPDebugMode(closeWhenLaunchedCheckBox.Checked, this);
        }

        private void launchSingleplayerButton_Click(object sender, EventArgs e)
        {
            SAMP.LaunchSingleplayerMode(closeWhenLaunchedCheckBox.Checked, this);
        }

        private void textFileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            switch (e.Name)
            {
                case "chatlog.txt":
                    lastChatlogTextBox.Text = SAMP.Chatlog;
                    break;
                case "savedpositions.txt":
                    savedPositionsTextBox.Text = SAMP.SavedPositions;
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
                List<IndexedServerListConnector> connectors = new List<IndexedServerListConnector>();
                for (int i = 0; i < api.Count; i++)
                {
                    ServerListConnector slc = api[i];
                    if ((slc.ServerListType == EServerListType.Favourites) || (slc.ServerListType == EServerListType.LegacyFavourites))
                        connectors.Add(new IndexedServerListConnector(slc, i));
                }
                if (connectors.Count <= 0)
                    MessageBox.Show(Translator.GetTranslation("NO_FAVOURITES"), Translator.GetTranslation("NO_FAVOURITES_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    IndexedServerListConnector islc = null;
                    if (connectors.Count > 1)
                    {
                        FavouriteListsForm flf = new FavouriteListsForm(connectors);
                        DialogResult result = flf.ShowDialog();
                        DialogResult = DialogResult.None;
                        if (result == DialogResult.OK)
                            islc = flf.SelectedServerListConnector;
                    }
                    else
                        islc = connectors[0];
                    if (islc != null)
                    {
                        ServerListConnector slc = islc.ServerListConnector;
                        Dictionary<string, Server> servers = slc.ServerListIO;
                        if (servers.ContainsKey(server.IPPortString))
                            MessageBox.Show(Translator.GetTranslation("SERVER_ALREADY_IN_FAVOURITES"), Translator.GetTranslation("ALREADY_IN_FAVOURITES"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            servers.Add(server.IPPortString, server.ToFavouriteServer(server.Hostname, server.Gamemode));
                            slc.ServerListIO = servers;
                            ReloadFavourites(servers, islc.Index);
                        }
                    }
                }
            }
        }

        private void removeServerFromFavouritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveSelectionFromFavourites();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void connectWithRCONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RCONPasswordForm rconf = new RCONPasswordForm();
            DialogResult result = rconf.ShowDialog();
            DialogResult = DialogResult.None;
            if (result == DialogResult.OK)
                Connect(rconf.RCONPassword);
        }

        private void serversGridView_DoubleClick(object sender, EventArgs e)
        {
            Connect();
        }

        private void selectAPIComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAPIIndex = selectAPIComboBox.SelectedIndex;
            SelectAPI();
        }

        private void gitHubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SAMP.OpenGitHubProject();
        }

        private void apiAddPictureBox_Click(object sender, EventArgs e)
        {
            AddSelectedAPI();
        }

        private void apiRemovePictureBox_Click(object sender, EventArgs e)
        {
            RemoveSelectedAPI();
        }

        private void apiEditPictureBox_Click(object sender, EventArgs e)
        {
            EditSelectedAPI();
        }

        private void addNewAPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSelectedAPI();
        }

        private void editSelectedAPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditSelectedAPI();
        }

        private void removeSelectedAPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveSelectedAPI();
        }

        private void apiGridView_DoubleClick(object sender, EventArgs e)
        {
            EditSelectedAPI();
        }

        private void serversGridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                RemoveSelectionFromFavourites(false);
            }
        }

        private void revertAPIListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Translator.GetTranslation("REVERT_API_LIST"), Translator.GetTranslation("REVERT_API_LIST_TITLE"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SAMP.RevertAPI();
                ReloadAPI();
            }
        }
    }
}
