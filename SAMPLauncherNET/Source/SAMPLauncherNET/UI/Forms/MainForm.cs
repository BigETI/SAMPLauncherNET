using MaterialSkin;
using MaterialSkin.Controls;
using SAMPLauncherNET.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using WinFormsTranslator;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Main form class
    /// </summary>
    public partial class MainForm : MaterialForm
    {
        /// <summary>
        /// Loading form
        /// </summary>
        private LoadingForm loadingForm;

        /// <summary>
        /// Load servers
        /// </summary>
        private readonly List<ServerListEntry> loadServers = new List<ServerListEntry>();

        /// <summary>
        /// Loaded servers
        /// </summary>
        private readonly List<ServerListEntry> loadedServers = new List<ServerListEntry>();

        /// <summary>
        /// Registered servers
        /// </summary>
        private readonly Dictionary<string, Server> registeredServers = new Dictionary<string, Server>();

        /// <summary>
        /// Update server list entries
        /// </summary>
        private Dictionary<Server, HashSet<ERequestResponseType>> updateServerListEntries = new Dictionary<Server, HashSet<ERequestResponseType>>();

        /// <summary>
        /// Servers thread
        /// </summary>
        private Thread serversThread;

        /// <summary>
        /// Servers row thread
        /// </summary>
        private Thread serversRowThread;

        /// <summary>
        /// Servers row thread success
        /// </summary>
        private bool serversRowThreadSuccess;

        /// <summary>
        /// Configuration
        /// </summary>
        private readonly SAMPConfig config = SAMP.SAMPConfig;

        /// <summary>
        /// Query first server
        /// </summary>
        private bool queryFirstServer = true;

        /// <summary>
        /// Selected API index
        /// </summary>
        private int selectedAPIIndex = -1;

        /// <summary>
        /// Filters
        /// </summary>
        private List<FilterUserControl> filters = new List<FilterUserControl>();

        /// <summary>
        /// Loaded gallery
        /// </summary>
        private readonly Dictionary<string, Image> loadedGallery = new Dictionary<string, Image>();

        /// <summary>
        /// Gallery thread
        /// </summary>
        private Thread galleryThread;

        /// <summary>
        /// Last gallery image index
        /// </summary>
        private uint lastGalleryImageIndex;

        /// <summary>
        /// Loaded sessions
        /// </summary>
        private List<object[]> loadedSessions = new List<object[]>();

        /// <summary>
        /// Sessions thread
        /// </summary>
        private Thread sessionsThread;

        /// <summary>
        /// Last media state
        /// </summary>
        private MediaState lastMediaState;

        /// <summary>
        /// Keep running
        /// </summary>
        private bool keepRunning = true;

        //private Dictionary<>

        /// <summary>
        /// Selected browser
        /// </summary>
        public Server SelectedServer
        {
            get
            {
                Server ret = null;
                foreach (DataGridViewRow dgvr in serversGridView.SelectedRows)
                {
                    if (dgvr.Cells[dgvr.Cells.Count - 3].Value != null)
                    {
                        string ipp = dgvr.Cells[dgvr.Cells.Count - 3].Value.ToString();
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

        /// <summary>
        /// Is in favourites list
        /// </summary>
        private bool IsInFavouriteList
        {
            get
            {
                bool ret = false;
                List<ServerListConnector> apis = SAMP.APIIO;
                if ((selectedAPIIndex >= 0) && (selectedAPIIndex < apis.Count))
                {
                    ServerListConnector slc = apis[selectedAPIIndex];
                    ret = ((slc.ServerListType == EServerListType.Favourites) || (slc.ServerListType == EServerListType.LegacyFavourites));
                }
                return ret;
            }
        }

        /// <summary>
        /// Favourite lists
        /// </summary>
        public IEnumerable<IndexedServerListConnector> FavouriteLists
        {
            get
            {
                List<IndexedServerListConnector> ret = new List<IndexedServerListConnector>();
                List<ServerListConnector> apis = SAMP.APIIO;
                for (int i = 0; i < apis.Count; i++)
                {
                    ServerListConnector slc = apis[i];
                    if ((slc.ServerListType == EServerListType.Favourites) || (slc.ServerListType == EServerListType.LegacyFavourites))
                    {
                        ret.Add(new IndexedServerListConnector(slc, i));
                    }
                }
                return ret;
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Size sz = revertConfigButton.Size;
            Translator.LoadTranslation(this);
            revertConfigButton.Location = new Point(revertConfigButton.Location.X + (sz.Width - revertConfigButton.Size.Width), revertConfigButton.Location.Y);
            Translator.EnumerableToComboBox(languagesComboBox, Translator.TranslatorInterface.Languages);
            serversGridView.Columns[1].HeaderText = Translator.GetTranslation("PING");
            serversGridView.Columns[2].HeaderText = Translator.GetTranslation("HOSTNAME");
            serversGridView.Columns[3].HeaderText = Translator.GetTranslation("PLAYERS");
            serversGridView.Columns[4].HeaderText = Translator.GetTranslation("MODE");
            serversGridView.Columns[5].HeaderText = Translator.GetTranslation("LANGUAGE");
            serversGridView.Columns[6].HeaderText = Translator.GetTranslation("IP_AND_PORT");
            playersGridView.Columns[0].HeaderText = Translator.GetTranslation("PLAYER");
            playersGridView.Columns[1].HeaderText = Translator.GetTranslation("SCORE");
            rulesGridView.Columns[0].HeaderText = Translator.GetTranslation("RULE");
            rulesGridView.Columns[1].HeaderText = Translator.GetTranslation("VALUE");
            apiGridView.Columns[1].HeaderText = Translator.GetTranslation("NAME");
            apiGridView.Columns[2].HeaderText = Translator.GetTranslation("TYPE");
            apiGridView.Columns[3].HeaderText = Translator.GetTranslation("ENDPOINT");
            sessionsDataGridView.Columns[1].HeaderText = Translator.GetTranslation("USERNAME");
            sessionsDataGridView.Columns[2].HeaderText = Translator.GetTranslation("HOSTNAME");
            sessionsDataGridView.Columns[3].HeaderText = Translator.GetTranslation("IP_AND_PORT");
            usernameSingleLineTextField.Hint = Translator.GetTranslation("USERNAME") + "...";
            usernameSingleLineTextField.Text = SAMP.Username;

            int i = 0;
            string lang = SAMP.LauncherConfigIO.Language;
            foreach (Language language in Translator.TranslatorInterface.Languages)
            {
                if (language.Culture == lang)
                {
                    languagesComboBox.SelectedIndex = i;
                    break;
                }
                ++i;
            }
            assemblyVersionLabel.Text += ": " + Assembly.GetExecutingAssembly().GetName().Version;
            fileVersionLabel.Text += ": " + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
            productVersionLabel.Text += ": " + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;

            MaterialSkinManager material_skin_manager = MaterialSkinManager.Instance;
            material_skin_manager.AddFormToManage(this);
            material_skin_manager.Theme = MaterialSkinManager.Themes.DARK;
            material_skin_manager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue800, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            galleryFileSystemWatcher.Path = SAMP.GalleryPath;
            textFileSystemWatcher.Path = SAMP.ConfigPath;
            try
            {
                if (!(Directory.Exists(SessionProvider.SessionsDirectory)))
                {
                    Directory.CreateDirectory(SessionProvider.SessionsDirectory);
                }
                sessionsFileSystemWatcher.Path = SessionProvider.SessionsDirectory;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
            }
            savedPositionsTextBox.Text = SAMP.SavedPositions;
            ReloadVersions();
            ReloadSAMPConfig();
            ReloadPluginsData();
            ReloadLauncherConfig();
            UpdateChatlogFormat();
            ReloadDeveloperToolsConfig();
            FixFilterControls();
            serversThread = new Thread(() =>
            {
                while (keepRunning)
                {
                    List<ServerListEntry> server_list_entries = new List<ServerListEntry>();
                    lock (loadServers)
                    {
                        foreach (ServerListEntry server_list_entry in loadServers)
                        {
                            if ((server_list_entry.Server is FavouriteServer) || (server_list_entry.Server is SAMPAPIServer))
                            {
                                server_list_entries.Add(server_list_entry);
                            }
                            else
                            {
                                if (server_list_entry.Server.IsDataFetched(ERequestResponseType.Ping) || server_list_entry.Server.IsDataFetched(ERequestResponseType.Information))
                                {
                                    server_list_entries.Add(server_list_entry);
                                }
                                else
                                {
                                    server_list_entry.Server.SendQueryWhenExpired(ERequestResponseType.Ping, 5000U);
                                    server_list_entry.Server.SendQueryWhenExpired(ERequestResponseType.Information, 5000U);
                                }
                            }
                        }
                        foreach (ServerListEntry server_list_entry in server_list_entries)
                        {
                            loadServers.Remove(server_list_entry);
                        }
                    }
                    lock (loadedServers)
                    {
                        loadedServers.AddRange(server_list_entries);
                    }
                    server_list_entries.Clear();
                    Thread.Sleep(50);
                }
            });
            serversThread.Start();
        }

        /// <summary>
        /// Show loading window
        /// </summary>
        private void ShowLoadingForm(EventHandler onShown)
        {
            HideLoadingForm();
            loadingForm = new LoadingForm();
            loadingForm.Location = new Point(Location.X + ((Size.Width - loadingForm.Size.Width) / 2), Location.Y + ((Size.Height - loadingForm.Size.Height) / 2));
            loadingForm.Shown += onShown;
            loadingForm.Show();
        }

        /// <summary>
        /// Hide loading window
        /// </summary>
        private void HideLoadingForm()
        {
            if (loadingForm != null)
            {
                loadingForm.Close();
                loadingForm = null;
            }
        }

        /// <summary>
        /// Clear plugins data
        /// </summary>
        private void ClearPluginsData()
        {
            pluginsDataTable.Clear();
        }

        /// <summary>
        /// Reload plugins data
        /// </summary>
        private void ReloadPluginsData()
        {
            PluginDataContract[] plugins = SAMP.PluginsDataIO;
            ClearPluginsData();
            for (int i = 0; i < plugins.Length; i++)
            {
                DataRow dr = pluginsDataTable.NewRow();
                PluginDataContract plugin = plugins[i];
                string trimmed_name = plugin.Name.Trim();
                if (trimmed_name.Length > 4)
                {
                    if (trimmed_name.StartsWith("{$") && trimmed_name.EndsWith("$}"))
                    {
                        plugin.TranslatableText = Translator.GetTranslation(trimmed_name.Substring(2, trimmed_name.Length - 4));
                    }
                }
                dr.ItemArray = new object[] { i, plugin.Enabled, plugin.Name, plugin.Provider.ToString(), plugin.URI, plugin.UpdateFrequency.ToString() };
                pluginsDataTable.Rows.Add(dr);
            }
        }

        /// <summary>
        /// Clear APIs
        /// </summary>
        private void ClearAPIs()
        {
            List<ServerListConnector> apis = SAMP.APIIO;
            foreach (ServerListConnector api in apis)
            {
                api.NotLoaded = true;
            }
            selectAPIComboBox.Items.Clear();
            selectedAPIIndex = -1;
            apiDataTable.Clear();
            lock (loadServers)
            {
                foreach (ServerListEntry server_list_entry in loadServers)
                {
                    server_list_entry.Dispose();
                }
                loadServers.Clear();
            }
            lock (loadedServers)
            {
                foreach (ServerListEntry server_list_entry in loadedServers)
                {
                    server_list_entry.Dispose();
                }
                loadedServers.Clear();
            }
            lock (registeredServers)
            {
                registeredServers.Clear();
            }
            serversDataTable.Clear();
        }

        /// <summary>
        /// Reload APIs
        /// </summary>
        /// <param name="oldIndex">Old index</param>
        private void ReloadAPIs(int oldIndex = 0)
        {
            List<ServerListConnector> apis = SAMP.APIIO;
            ClearAPIs();
            lock (apiDataTable)
            {
                for (int i = 0; i < apis.Count; i++)
                {
                    DataRow dr = apiDataTable.NewRow();
                    ServerListConnector slc = apis[i];
                    string trimmed_name = slc.Name.Trim();
                    if (trimmed_name.Length > 4)
                    {
                        if (trimmed_name.StartsWith("{$") && trimmed_name.EndsWith("$}"))
                        {
                            slc.TranslatableText = Translator.GetTranslation(trimmed_name.Substring(2, trimmed_name.Length - 4));
                        }
                    }
                    dr.ItemArray = new object[] { i, slc.Name, slc.ServerListType.ToString(), slc.Endpoint };
                    apiDataTable.Rows.Add(dr);
                }
            }
            selectAPIComboBox.Items.AddRange(apis.ToArray());
            if (apis.Count > oldIndex)
            {
                selectAPIComboBox.SelectedIndex = oldIndex;
            }
        }

        /// <summary>
        /// Select API
        /// </summary>
        private void SelectAPI()
        {
            int index = selectAPIComboBox.SelectedIndex;
            List<ServerListConnector> apis = SAMP.APIIO;
            if ((index >= 0) && (index < apis.Count))
            {
                lock (loadServers)
                {
                    queryFirstServer = true;
                    ServerListConnector slc = apis[index];
                    if (slc.NotLoaded)
                    {
                        ShowLoadingForm((sender, e) =>
                        {
                            lock (loadServers)
                            {
                                slc.NotLoaded = false;
                                Dictionary<string, Server> l = slc.ServerListIO;
                                foreach (Server server in l.Values)
                                {
                                    loadServers.Add(new ServerListEntry(server, index));
                                }
                            }
                        });
                    }
                }
                UpdateServerListFilters();
                UpdateServerCount();
            }
        }

        /// <summary>
        /// Add filter control
        /// </summary>
        private void AddFilterControl()
        {
            FilterUserControl filter = new FilterUserControl();
            filter.FilterOptions = new FilterOption[]
            {
                new FilterOption("Hostname", "{$FILTER_HOSTNAME$}"),
                new FilterOption("Mode", "{$FILTER_MODE$}"),
                new FilterOption("Language", "{$FILTER_LANGUAGE$}"),
                new FilterOption("IP and port", "{$FILTER_IP_AND_PORT$}")
            };
            filtersInnerPanel.Controls.Add(filter);
            filters.Add(filter);
            filter.Dock = DockStyle.Top;
            filter.Filter += (sender, e) =>
            {
                UpdateServerListFilters();
            };
            filter.FilterDelete += (sender, e) =>
            {
                if (sender is FilterUserControl)
                {
                    RemoveFilterControl((FilterUserControl)sender);
                }
            };
        }

        /// <summary>
        /// Remove filter control
        /// </summary>
        /// <param name="filterControl">Filter control</param>
        private void RemoveFilterControl(FilterUserControl filterControl)
        {
            if (filterControl != null)
            {
                if (filters.Contains(filterControl))
                {
                    filters.Remove(filterControl);
                    filtersInnerPanel.Controls.Remove(filterControl);
                    FixFilterControls();
                    UpdateServerListFilters();
                }
            }
        }

        /// <summary>
        /// Fix filter controls
        /// </summary>
        private void FixFilterControls()
        {
            if (filters.Count <= 0)
            {
                AddFilterControl();
            }
        }

        /// <summary>
        /// Update server count
        /// </summary>
        private void UpdateServerCount()
        {
            uint c = 0U;
            int index = selectedAPIIndex;
            List<ServerListConnector> apis = SAMP.APIIO;
            if ((index >= 0) && (index < apis.Count))
            {
                c = apis[index].ServerCount;
            }
            serverCountLabel.Text = Translator.GetTranslation("SERVERS") + ": " + c;
        }

        /// <summary>
        /// Enter servers row
        /// </summary>
        /// <returns>Success</returns>
        private bool EnterServersRow()
        {
            bool ret = false;
            if (serversRowThread != null)
            {
                serversRowThread.Abort();
                serversRowThread = null;
            }
            serversRowThreadSuccess = false;
            Server server = SelectedServer;
            if (server != null)
            {
                ReloadSelectedServerRow();
                serversRowThread = new Thread(() => RequestServerInfo(server));
                serversRowThread.Start();
                ret = true;
            }
            return ret;
        }

        /// <summary>
        /// Reload selected server row
        /// </summary>
        private void ReloadSelectedServerRow()
        {
            // TODO
            foreach (DataGridViewRow dgvr in serversGridView.SelectedRows)
            {
                object ip_port_object = dgvr.Cells[dgvr.Cells.Count - 3].Value;
                if (ip_port_object != null)
                {
                    string ip_port = ip_port_object.ToString();
                    if (registeredServers.ContainsKey(ip_port))
                    {
                        Server server = registeredServers[ip_port];
                        if (server != null)
                        {
                            DataRow[] data_rows = serversDataTable.Select("`IP and port`='" + ip_port + "'");
                            if (data_rows != null)
                            {
                                foreach (DataRow data_row in data_rows)
                                {
                                    if (data_row != null)
                                    {
                                        data_row.BeginEdit();
                                        object[] row = data_row.ItemArray;
                                        if (server.IsDataFetched(ERequestResponseType.Ping))
                                        {
                                            row[1] = new PingString(server.Ping);
                                        }
                                        if (server.IsDataFetched(ERequestResponseType.Information))
                                        {
                                            row[2] = server.Hostname;
                                            uint player_count = server.PlayerCount;
                                            uint max_players = server.MaxPlayers;
                                            row[3] = new PlayerCountString(player_count, max_players);
                                            row[4] = server.Gamemode;
                                            row[5] = server.Language;
                                            row[7] = (player_count == 0U);
                                            row[8] = (player_count >= max_players);
                                        }
                                        data_row.EndEdit();
                                    }
                                }
                                ReloadServerInfo();
                            }
                        }
                    }
                }
                break;
            }
        }

        /// <summary>
        /// Reload server information
        /// </summary>
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
                playersGridView.Refresh();
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
                        {
                            cs = true;
                        }
                        ++i;
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                }
                if (cs)
                {
                    playersGridView.Rows[si].Selected = true;
                }
                si = 0;
                cs = false;
                foreach (DataGridViewRow dgvr in rulesGridView.SelectedRows)
                {
                    si = dgvr.Index;
                    break;
                }
                rulesDataTable.Clear();
                rulesGridView.Refresh();
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
                        {
                            cs = true;
                        }
                        ++i;
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                }
                if (cs)
                {
                    rulesGridView.Rows[si].Selected = true;
                }
            }
        }

        /// <summary>
        /// Request server information
        /// </summary>
        /// <param name="server">Server</param>
        private void RequestServerInfo(Server server)
        {
            uint count = 0U;
            while (keepRunning)
            {
                if ((count % 4U) == 0U)
                {
                    server.FetchMultiData(new ERequestResponseType[] { ERequestResponseType.Ping, ERequestResponseType.Information, ERequestResponseType.Clients, ERequestResponseType.Rules });
                    serversRowThreadSuccess = (server.IsDataFetched(ERequestResponseType.Ping) || server.IsDataFetched(ERequestResponseType.Information) || server.IsDataFetched(ERequestResponseType.Clients) || server.IsDataFetched(ERequestResponseType.Rules));
                    count = 0U;
                }
                else
                {
                    server.FetchData(ERequestResponseType.Ping);
                }
                ++count;
                if (keepRunning)
                {
                    Thread.Sleep(1000);
                }
            }
        }

        /// <summary>
        /// Update server list filter
        /// </summary>
        private void UpdateServerListFilters()
        {
            StringBuilder str = new StringBuilder("GroupID=");
            str.Append(selectedAPIIndex.ToString());
            if (!(showEmptyServersToolStripMenuItem.Checked))
            {
                str.Append(" AND `IsEmpty`=0");
            }
            if (!(showFullServersToolStripMenuItem.Checked))
            {
                str.Append(" AND `IsFull`=0");
            }
            foreach (FilterUserControl filter in filters)
            {
                string ft = filter.FilterText;
                if (ft.Length > 0)
                {
                    if (filter.UseRegex)
                    {
                        try
                        {
                            Regex regex = new Regex(ft);
                            bool first = true;
                            foreach (Server server in registeredServers.Values)
                            {
                                string match_str = null;
                                switch (filter.Field)
                                {
                                    case "Hostname":
                                        match_str = server.Hostname;
                                        break;
                                    case "Mode":
                                        match_str = server.Gamemode;
                                        break;
                                    case "Language":
                                        match_str = server.Language;
                                        break;
                                    case "IP and port":
                                        match_str = server.IPPortString;
                                        break;
                                }
                                if (match_str != null)
                                {
                                    if (regex.IsMatch(match_str))
                                    {
                                        if (first)
                                        {
                                            str.Append(" AND `IP and port` IN (");
                                            first = false;
                                        }
                                        else
                                        {
                                            str.Append(", ");
                                        }
                                        str.Append("'");
                                        str.Append(server.IPPortString);
                                        str.Append("'");
                                    }
                                }
                            }
                            if (first)
                            {
                                str.Append(" AND `IP and port` NOT '%'");
                            }
                            else
                            {
                                str.Append(")");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Error.WriteLine(e);
                        }
                    }
                    else
                    {
                        string field = filter.Field;
                        if (field.Length > 0)
                        {
                            str.Append(" AND `");
                            str.Append(field);
                            str.Append("` LIKE '%");
                            str.Append(filter.FilterText);
                            str.Append("%'");
                        }
                    }
                }
            }
            try
            {
                Console.WriteLine(str.ToString());
                serversBindingSource.Filter = str.ToString();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                MessageBox.Show(e.Message, Translator.GetTranslation("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            EnterServersRow();
        }

        /// <summary>
        /// Reload favourites
        /// </summary>
        /// <param name="servers">Servers</param>
        /// <param name="index">Index</param>
        private void ReloadFavourites(Dictionary<string, Server> servers, int index)
        {
            DataRow[] rows = serversDataTable.Select("GroupID=" + index);
            foreach (DataRow row in rows)
            {
                row.Delete();
            }
            lock (loadServers)
            {
                foreach (Server server in servers.Values)
                {
                    loadServers.Add(new ServerListEntry(server, index));
                }
            }
        }

        /// <summary>
        /// Connect
        /// </summary>
        /// <param name="server">Server</param>
        /// <param name="rconPassword">RCON password</param>
        /// <param name="quitWhenDone">Quit when done</param>
        /// <param name="createSessionLog">Create session log</param>
        private void Connect(Server server = null, string rconPassword = null, bool quitWhenDone = false, bool createSessionLog = false)
        {
            Server s = server;
            if (s == null)
            {
                s = SelectedServer;
            }
            if (s != null)
            {
                bool success = true;
                foreach (Player player in s.PlayerValues)
                {
                    if (player.Name.ToLower() == SAMP.Username.ToLower())
                    {
                        success = (MessageBox.Show(Translator.GetTranslation("USERNAME_WARNING"), Translator.GetTranslation("USERNAME_WARNING_TITLE"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes);
                        break;
                    }
                }
                if (showUsernameDialogCheckBox.Checked || s.HasPassword)
                {
                    ConnectForm cf = new ConnectForm(!(s.HasPassword));
                    DialogResult result = cf.ShowDialog();
                    DialogResult = DialogResult.None;
                    if (result == DialogResult.OK)
                    {
                        SAMP.LaunchSAMP(s, cf.Username, s.HasPassword ? cf.ServerPassword : null, rconPassword, false, quitWhenDone, createSessionLog, SAMP.PluginsDataIO, this);
                        lastMediaState = SAMP.LastMediaState;
                    }
                }
                else
                {
                    string username = usernameSingleLineTextField.Text.Trim();
                    if (username.Length > 0)
                    {
                        SAMP.LaunchSAMP(s, usernameSingleLineTextField.Text.Trim(), null, rconPassword, false, quitWhenDone, createSessionLog, SAMP.PluginsDataIO, this);
                        lastMediaState = SAMP.LastMediaState;
                    }
                    else
                    {
                        MessageBox.Show(Translator.GetTranslation("PLEASE_TYPE_IN_USERNAME"), Translator.GetTranslation("INPUT_ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Connect using session
        /// </summary>
        /// <param name="session">Session</param>
        public void ConnectUsingSession(Session session)
        {
            if (session != null)
            {
                using (Server server = new Server(session.IPPort, false))
                {
                    if (server.IsValid)
                    {
                        Connect(server, null, closeWhenLaunchedCheckBox.Checked, createSessionsLogCheckBox.Checked);
                    }
                    else
                    {
                        Connect(quitWhenDone: closeWhenLaunchedCheckBox.Checked, createSessionLog: createSessionsLogCheckBox.Checked);
                    }
                }
            }
        }

        /// <summary>
        /// Visit website
        /// </summary>
        /// <param name="url">URL</param>
        private static void VisitWebsite(string url)
        {
            if (!(url.Contains("://")))
            {
                url = "http://" + url;
            }
            if (MessageBox.Show(url + "\r\n\r\n" + Translator.GetTranslation("VISIT_WEBSITE_MESSAGE"), Translator.GetTranslation("VISIT_WEBSITE_TITLE") + " " + url, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Process.Start(url);
            }
        }

        /// <summary>
        /// Reload launcher configuration
        /// </summary>
        private void ReloadLauncherConfig()
        {
            LauncherConfigDataContract lcdc = SAMP.LauncherConfigIO;
            developmentDirectorySingleLineTextField.Text = lcdc.DevelopmentDirectory;
            selectedAPIIndex = lcdc.LastSelectedServerListAPI;
            if (selectAPIComboBox.Items.Count > selectedAPIIndex)
            {
                selectAPIComboBox.SelectedIndex = selectedAPIIndex;
            }
            chatlogColorCodesCheckBox.Checked = lcdc.ShowChatlogColorCodes;
            chatlogColoredCheckBox.Checked = lcdc.ShowChatlogColored;
            chatlogTimestampCheckBox.Checked = lcdc.ShowChatlogTimestamp;
            showUsernameDialogCheckBox.Checked = !(lcdc.DontShowUsernameDialog);
            closeWhenLaunchedCheckBox.Checked = !(lcdc.DontCloseWhenLaunched);
            createSessionsLogCheckBox.Checked = lcdc.CreateSessionsLog;
        }

        /// <summary>
        /// Update chatlog format
        /// </summary>
        private void UpdateChatlogFormat()
        {
            lastChatlogRichTextBox.Rtf = ChatlogFormatter.Format(SAMP.Chatlog, EChatlogFormatType.RTF, chatlogColorCodesCheckBox.Checked, chatlogColoredCheckBox.Checked, chatlogTimestampCheckBox.Checked);
        }

        /// <summary>
        /// Reload gallery
        /// </summary>
        private void ReloadGallery()
        {
            if (galleryThread != null)
            {
                galleryThread.Abort();
            }
            galleryListView.Clear();
            galleryImageList.Images.Clear();
            loadedGallery.Clear();
            lastGalleryImageIndex = 0U;
            galleryThread = new Thread(() =>
            {
                foreach (string path in SAMP.GalleryImagePaths)
                {
                    Image image = ThumbnailsCache.GetThumbnail(path);
                    if (image != null)
                    {
                        lock (loadedGallery)
                        {
                            loadedGallery.Add(path, image);
                        }
                    }
                }
            });
            galleryThread.Start();
        }

        /// <summary>
        /// View selected image
        /// </summary>
        private void ViewSelectedImage()
        {
            foreach (ListViewItem item in galleryListView.SelectedItems)
            {
                try
                {
                    string file_name = (string)(item.Tag);
                    if (File.Exists(file_name))
                    {
                        Process.Start(file_name);
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                    MessageBox.Show(e.Message, Translator.GetTranslation("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Delete selected image
        /// </summary>
        private void DeleteSelectedImage()
        {
            List<string> files = new List<string>();
            foreach (ListViewItem item in galleryListView.SelectedItems)
            {
                string file_name = (string)(item.Tag);
                if (File.Exists(file_name))
                {
                    files.Add(file_name);
                }
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
                        catch (Exception e)
                        {
                            Console.Error.WriteLine(e);
                        }
                    }
                    galleryFileSystemWatcher.EnableRaisingEvents = true;
                    ReloadGallery();
                }
            }
        }

        /// <summary>
        /// Reload sessions data
        /// </summary>
        private void ReloadSessionsData()
        {
            if (sessionsThread != null)
            {
                sessionsThread.Abort();
            }
            sessionsDataTable.Clear();
            loadedSessions.Clear();
            sessionsThread = new Thread(() =>
            {
                foreach (Session session in SessionProvider.Sessions)
                {
                    lock (loadedSessions)
                    {
                        object[] data = new object[8];
                        data[0] = session.Path;
                        data[1] = session.Username;
                        data[2] = session.Hostname;
                        data[3] = session.IPPort;
                        data[4] = session.Chatlog;
                        data[5] = session.Mode;
                        data[6] = session.Language;
                        data[7] = session.DateTime;
                        loadedSessions.Add(data);
                    }
                }
            });
            sessionsThread.Start();
        }

        /// <summary>
        /// Reload selected session data
        /// </summary>
        private void ReloadSelectedSessionData()
        {
            foreach (DataGridViewRow dgvr in sessionsDataGridView.SelectedRows)
            {
                if (dgvr.Cells[0].Value != null)
                {
                    string path = dgvr.Cells[0].Value.ToString();
                    Session session = SessionsCache.GetSession(path);
                    if (session != null)
                    {
                        Utils.DisposeAll(sessionSplitContainer.Panel1.Controls);
                        sessionSplitContainer.Panel1.Controls.Clear();
                        SessionUserControl suc = new SessionUserControl(session);
                        sessionSplitContainer.Panel1.Controls.Add(suc);
                        suc.Dock = DockStyle.Fill;
                        Utils.DisposeAll(sessionSplitContainer.Panel2.Controls);
                        sessionSplitContainer.Panel2.Controls.Clear();
                        SessionServerUserControl ssuc = new SessionServerUserControl(session, this);
                        sessionSplitContainer.Panel2.Controls.Add(ssuc);
                        ssuc.Dock = DockStyle.Fill;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Save configuration
        /// </summary>
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

        /// <summary>
        /// Reload versions
        /// </summary>
        private void ReloadVersions()
        {
            SAMPVersionDataContract current_version = SAMPProvider.CurrentVersion;
            versionsListView.Clear();
            foreach (SAMPVersionDataContract version in SAMPProvider.VersionsList)
            {
                ListViewItem lvi = versionsListView.Items.Add(version.ToString());
                lvi.Tag = version;
                lvi.ImageIndex = ((current_version == version) ? 0 : 1);
            }
            ReloadAPIs();
        }

        /// <summary>
        /// Reload SA:MP configuration
        /// </summary>
        private void ReloadSAMPConfig()
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

        /// <summary>
        /// Fill items in checked list box
        /// </summary>
        /// <param name="checkedListBox">Checked list box</param>
        /// <param name="files">Files</param>
        /// <param name="checkedFiles">Checked files</param>
        private static void FillItemsInCheckedListBox(CheckedListBox checkedListBox, FileResource[] files, string[] checkedFiles)
        {
            checkedListBox.Items.AddRange(files);
            for (int i = 0; i < files.Length; i++)
            {
                FileResource file = files[i];
                foreach (string checked_file in checkedFiles)
                {
                    if (file.FileNameWithoutExtension == checked_file)
                    {
                        checkedListBox.SetItemChecked(i, true);
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Reload developer tools configuration
        /// </summary>
        private void ReloadDeveloperToolsConfig()
        {
            DeveloperToolsConfigDataContract dtcdc = SAMP.DeveloperToolsConfigIO;
            developerToolsGamemodesCheckedListBox.Items.Clear();
            developerToolsFilterscriptsCheckedListBox.Items.Clear();
            developerToolsPluginsCheckedListBox.Items.Clear();
            string directory = Utils.AppendCharacterToString(developmentDirectorySingleLineTextField.Text, '\\');
            if (Directory.Exists(directory))
            {
                FillItemsInCheckedListBox(developerToolsGamemodesCheckedListBox, Utils.GetFilesFromDirectory(directory + "gamemodes", "*.amx", SearchOption.TopDirectoryOnly), dtcdc.Gamemodes);
                FillItemsInCheckedListBox(developerToolsFilterscriptsCheckedListBox, Utils.GetFilesFromDirectory(directory + "filterscripts", "*.amx", SearchOption.TopDirectoryOnly), dtcdc.Filterscripts);
                FillItemsInCheckedListBox(developerToolsPluginsCheckedListBox, Utils.GetFilesFromDirectory(directory + "plugins", "*.dll", SearchOption.TopDirectoryOnly), dtcdc.Plugins);
            }
        }

        /// <summary>
        /// Save developer tools configuration
        /// </summary>
        private void SaveDeveloperToolsConfig()
        {
            DeveloperToolsConfigDataContract dtcdc = SAMP.DeveloperToolsConfigIO;
            List<string> entries = new List<string>();
            foreach (var item in developerToolsGamemodesCheckedListBox.CheckedItems)
            {
                entries.Add(item.ToString());
            }
            dtcdc.Gamemodes = entries.ToArray();
            entries.Clear();
            foreach (var item in developerToolsFilterscriptsCheckedListBox.CheckedItems)
            {
                entries.Add(item.ToString());
            }
            dtcdc.Filterscripts = entries.ToArray();
            entries.Clear();
            foreach (var item in developerToolsPluginsCheckedListBox.CheckedItems)
            {
                entries.Add(item.ToString());
            }
            dtcdc.Plugins = entries.ToArray();
            entries.Clear();
            dtcdc.Hostname = developerToolsHostnameSingleLineTextField.Text;
            dtcdc.Port = Utils.GetInt(developerToolsPortSingleLineTextField.Text);
            dtcdc.Password = developerToolsServerPasswordSingleLineTextField.Text;
            dtcdc.RCONPassword = developerToolsRCONPasswordSingleLineTextField.Text;
            if (dtcdc.RCONPassword.Trim().Length <= 0)
            {
                dtcdc.RCONPassword = Utils.GetRandomString(16);
                developerToolsRCONPasswordSingleLineTextField.Text = dtcdc.RCONPassword;
            }
            SAMP.DeveloperToolsConfigIO = dtcdc;
        }

        /// <summary>
        /// Add new plugin data
        /// </summary>
        private void AddNewPluginData()
        {
            PluginDataForm pdf = new PluginDataForm(null);
            DialogResult result = pdf.ShowDialog();
            DialogResult = DialogResult.None;
            if (result == DialogResult.OK)
            {
                List<PluginDataContract> plugins = new List<PluginDataContract>(SAMP.PluginsDataIO);
                plugins.Add(pdf.PluginData);
                SAMP.PluginsDataIO = plugins.ToArray();
                ReloadPluginsData();
            }
        }

        /// <summary>
        /// Edit selected plugin data
        /// </summary>
        private void EditSelectedPluginData()
        {
            PluginDataContract[] plugins = SAMP.PluginsDataIO;
            foreach (DataGridViewRow dgvr in pluginsGridView.SelectedRows)
            {
                object index = dgvr.Cells[0].Value;
                if (index is int)
                {
                    int i = (int)index;
                    if ((i >= 0) && (i < plugins.Length))
                    {
                        PluginDataContract plugin = plugins[i];
                        PluginDataForm pdf = new PluginDataForm(plugin);
                        DialogResult result = pdf.ShowDialog();
                        DialogResult = DialogResult.None;
                        if (result == DialogResult.OK)
                        {
                            plugins[i] = pdf.PluginData;
                            SAMP.PluginsDataIO = plugins;
                            ReloadPluginsData();
                        }
                    }
                }
                break;
            }
        }

        /// <summary>
        /// Remove selected plugin data
        /// </summary>
        private void RemoveSelectedPluginData()
        {
            if (MessageBox.Show(Translator.GetTranslation("REMOVE_PLUGIN"), Translator.GetTranslation("REMOVE_PLUGIN_TITLE"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                List<PluginDataContract> rl = new List<PluginDataContract>();
                List<PluginDataContract> plugins_result = new List<PluginDataContract>(SAMP.PluginsDataIO);
                foreach (DataGridViewRow dgvr in pluginsGridView.SelectedRows)
                {
                    object index = dgvr.Cells[0].Value;
                    if (index is int)
                    {
                        int i = (int)index;
                        if ((i >= 0) && (i < plugins_result.Count))
                        {
                            rl.Add(plugins_result[i]);
                        }
                    }
                }
                foreach (PluginDataContract item in rl)
                {
                    plugins_result.Remove(item);
                }
                SAMP.PluginsDataIO = plugins_result.ToArray();
                ReloadPluginsData();
            }
        }

        /// <summary>
        /// Add new API
        /// </summary>
        private void AddNewAPI()
        {
            APIForm apif = new APIForm(null);
            DialogResult result = apif.ShowDialog();
            DialogResult = DialogResult.None;
            if (result == DialogResult.OK)
            {
                List<ServerListConnector> api = SAMP.APIIO;
                api.Add(new ServerListConnector(apif.API));
                SAMP.APIIO = api;
                ReloadAPIs();
            }
        }

        /// <summary>
        /// Edit selected API
        /// </summary>
        private void EditSelectedAPI()
        {
            List<ServerListConnector> apis = SAMP.APIIO;
            foreach (DataGridViewRow dgvr in apiGridView.SelectedRows)
            {
                object index = dgvr.Cells[0].Value;
                if (index is int)
                {
                    int i = (int)index;
                    if ((i >= 0) && (i < apis.Count))
                    {
                        ServerListConnector slc = apis[i];
                        APIForm apif = new APIForm(slc.APIDataContract);
                        DialogResult result = apif.ShowDialog();
                        DialogResult = DialogResult.None;
                        if (result == DialogResult.OK)
                        {
                            apis[i] = new ServerListConnector(apif.API);
                            SAMP.APIIO = apis;
                            ReloadAPIs();
                        }
                    }
                }
                break;
            }
        }

        /// <summary>
        /// Remove selected API
        /// </summary>
        private void RemoveSelectedAPI()
        {
            if (MessageBox.Show(Translator.GetTranslation("REMOVE_API"), Translator.GetTranslation("REMOVE_API_TITLE"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                List<ServerListConnector> rl = new List<ServerListConnector>();
                List<ServerListConnector> apis_result = SAMP.APIIO;
                foreach (DataGridViewRow dgvr in apiGridView.SelectedRows)
                {
                    object index = dgvr.Cells[0].Value;
                    if (index is int)
                    {
                        int i = (int)index;
                        if ((i >= 0) && (i < apis_result.Count))
                        {
                            rl.Add(apis_result[i]);
                        }
                    }
                }
                foreach (ServerListConnector item in rl)
                {
                    apis_result.Remove(item);
                }
                SAMP.APIIO = apis_result;
                ReloadAPIs();
            }
        }

        /// <summary>
        /// Remove selection from favourites
        /// </summary>
        /// <param name="promptWhenError">Prompt when error</param>
        private void RemoveSelectionFromFavourites(bool promptWhenError = true)
        {
            if (IsInFavouriteList)
            {
                Server server = SelectedServer;
                if (server != null)
                {
                    if (MessageBox.Show(Translator.GetTranslation("REMOVE_SERVER_FROM_FAVOURITES"), Translator.GetTranslation("REMOVE_SERVER_FROM_FAVOURITES_TITLE"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        List<ServerListConnector> apis = SAMP.APIIO;
                        Dictionary<string, Server> servers = apis[selectedAPIIndex].ServerListIO;
                        if (servers.ContainsKey(server.IPPortString))
                        {
                            servers.Remove(server.IPPortString);
                            apis[selectedAPIIndex].ServerListIO = servers;
                            ReloadFavourites(servers, selectedAPIIndex);
                        }
                    }
                }
            }
            else if (promptWhenError)
            {
                MessageBox.Show(Translator.GetTranslation("SERVER_NOT_IN_FAVOURITES"), Translator.GetTranslation("NOT_IN_FAVOURITES"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Multi-threaded lists timer tick event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void multithreadedListsTimer_Tick(object sender, EventArgs e)
        {
            if ((lastMediaState != null) && (SAMP.LastSessionData != null))
            {
                try
                {
                    if (!(SAMP.IsGTASanAndreasRunning))
                    {
                        string chatlog_path = null;
                        string saved_positions_path = null;
                        List<string> screenshot_paths = new List<string>();
                        string[] paths = lastMediaState.GetModifiedAdded();
                        foreach (string path in paths)
                        {
                            if (path.ToLower().EndsWith(".png"))
                            {
                                screenshot_paths.Add(path);
                            }
                            else if (path.ToLower().EndsWith("chatlog.txt"))
                            {
                                chatlog_path = path;
                            }
                            else if (path.ToLower().EndsWith("savedpositions.txt"))
                            {
                                saved_positions_path = path;
                            }
                        }
                        string session_path;
                        do
                        {
                            session_path = Path.Combine(SessionProvider.SessionsDirectory, DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-") + Utils.GetRandomString(4U) + ".samp-session");
                        }
                        while (File.Exists(session_path));
                        Session session = null;
                        using (Server server = new Server(SAMP.LastSessionData.IPPort, true))
                        {
                            if (server.IsValid)
                            {
                                string hostname = server.Hostname;
                                string mode = server.Gamemode;
                                string language = server.Language;
                                session = Session.Create(session_path, SAMP.LastSessionData.DateTime, DateTime.Now - SAMP.LastSessionData.DateTime, SAMPProvider.CurrentVersion.Name, SAMP.LastSessionData.Username, SAMP.LastSessionData.IPPort, (hostname.Length > 0) ? hostname : SAMP.LastSessionData.Hostname, (mode.Length > 0) ? mode : SAMP.LastSessionData.Mode, (language.Length > 0) ? language : SAMP.LastSessionData.Language, screenshot_paths.ToArray(), chatlog_path, saved_positions_path);
                            }
                            else
                            {
                                session = Session.Create(session_path, SAMP.LastSessionData.DateTime, DateTime.Now - SAMP.LastSessionData.DateTime, SAMPProvider.CurrentVersion.Name, SAMP.LastSessionData.Username, SAMP.LastSessionData.IPPort, SAMP.LastSessionData.Hostname, SAMP.LastSessionData.Mode, SAMP.LastSessionData.Language, screenshot_paths.ToArray(), chatlog_path, saved_positions_path);
                            }
                        }
                        lastMediaState = null;
                        if (session != null)
                        {
                            SessionForm sf = new SessionForm(session);
                            DialogResult result = sf.ShowDialog();
                            DialogResult = DialogResult.None;
                            if (result == DialogResult.No)
                            {
                                try
                                {
                                    if (File.Exists(session.Path))
                                    {
                                        File.Delete(session.Path);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.Error.WriteLine(ex);
                                    MessageBox.Show(ex.Message, Translator.GetTranslation("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                SessionsCache.Remove(session);
                            }
                            if (closeWhenLaunchedCheckBox.Checked)
                            {
                                Close();
                            }
                            else
                            {
                                WindowState = FormWindowState.Maximized;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex);
                }
            }
            List<ServerListConnector> apis = SAMP.APIIO;
            lock (loadedServers)
            {
                foreach (ServerListEntry server_list_entry in loadedServers)
                {
                    DataRow dr = serversDataTable.NewRow();
                    object[] row = new object[9];
                    ushort player_count = server_list_entry.Server.PlayerCount;
                    ushort max_players = server_list_entry.Server.MaxPlayers;
                    row[0] = server_list_entry.ServerListIndex;
                    row[1] = new PingString(server_list_entry.Server.Ping);
                    row[2] = server_list_entry.Server.Hostname;
                    row[3] = new PlayerCountString(player_count, max_players);
                    row[4] = server_list_entry.Server.Gamemode;
                    row[5] = server_list_entry.Server.Language;
                    row[6] = server_list_entry.Server.IPPortString;
                    row[7] = (player_count <= 0);
                    row[8] = (player_count >= max_players);
                    dr.ItemArray = row;
                    serversDataTable.Rows.Add(dr);
                    if (!(registeredServers.ContainsKey(server_list_entry.Server.IPPortString)))
                    {
                        registeredServers.Add(server_list_entry.Server.IPPortString, server_list_entry.Server);
                    }
                    server_list_entry.Server.OnResponse += (server, response) =>
                    {
                        lock (updateServerListEntries)
                        {
                            string ip_port = server.IPPortString;
                            HashSet<ERequestResponseType> responses = null;
                            if (updateServerListEntries.ContainsKey(server))
                            {
                                responses = updateServerListEntries[server];
                            }
                            else
                            {
                                responses = new HashSet<ERequestResponseType>();
                                updateServerListEntries.Add(server, responses);
                            }
                            responses.Add(response);
                        }
                    };
                    if (queryFirstServer)
                    {
                        queryFirstServer = !(EnterServersRow());
                        if (!queryFirstServer)
                        {
                            HideLoadingForm();
                        }
                    }
                    if ((server_list_entry.ServerListIndex >= 0) && (server_list_entry.ServerListIndex < apis.Count))
                    {
                        ++apis[server_list_entry.ServerListIndex].ServerCount;
                    }
                }
                if (loadedServers.Count <= 0)
                {
                    HideLoadingForm();
                }
                else
                {
                    loadedServers.Clear();
                }
                UpdateServerCount();
            }
            if (serversRowThreadSuccess)
            {
                serversRowThreadSuccess = false;
                ReloadSelectedServerRow();
            }
            lock (loadedGallery)
            {
                foreach (KeyValuePair<string, Image> kv in loadedGallery)
                {
                    galleryImageList.Images.Add(kv.Value);
                    ListViewItem lvi = galleryListView.Items.Add(Path.GetFileName(kv.Key), (int)lastGalleryImageIndex);
                    lvi.Tag = kv.Key;
                    ++lastGalleryImageIndex;
                }
                loadedGallery.Clear();
            }
            lock (loadedSessions)
            {
                foreach (object[] data in loadedSessions)
                {
                    DataRow dr = sessionsDataTable.NewRow();
                    dr.ItemArray = data;
                    sessionsDataTable.Rows.Add(dr);
                }
                if (loadedSessions.Count > 0)
                {
                    ReloadSelectedSessionData();
                }
                loadedSessions.Clear();
            }
            lock (updateServerListEntries)
            {
                foreach (KeyValuePair<Server, HashSet<ERequestResponseType>> kv in updateServerListEntries)
                {
                    DataRow[] data_rows = serversDataTable.Select("`IP and port`='" + kv.Key + "'");
                    if (data_rows != null)
                    {
                        foreach (DataRow data_row in data_rows)
                        {
                            if (data_row != null)
                            {
                                data_row.BeginEdit();
                                object[] row_data = data_row.ItemArray;
                                foreach (ERequestResponseType response in kv.Value)
                                {
                                    switch (response)
                                    {
                                        case ERequestResponseType.Ping:
                                            row_data[1] = new PingString(kv.Key.Ping);
                                            break;
                                        case ERequestResponseType.Information:
                                            {
                                                uint player_count = kv.Key.PlayerCount;
                                                uint max_players = kv.Key.MaxPlayers;
                                                row_data[2] = kv.Key.Hostname;
                                                row_data[3] = new PlayerCountString(player_count, kv.Key.MaxPlayers);
                                                row_data[4] = kv.Key.Gamemode;
                                                row_data[5] = kv.Key.Language;
                                                row_data[7] = (player_count <= 0);
                                                row_data[8] = (player_count >= max_players);
                                            }
                                            break;
                                    }
                                }
                                data_row.EndEdit();
                                kv.Value.Clear();
                            }
                        }
                    }
                }
                updateServerListEntries.Clear();
            }
        }

        /// <summary>
        /// Servers grid view row enter event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Data grid view cell event arguments</param>
        private void serversGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            EnterServersRow();
        }

        /// <summary>
        /// Main form location changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void MainForm_LocationChanged(object sender, EventArgs e)
        {
            if (loadingForm != null)
            {
                loadingForm.Location = new Point(Location.X + ((Size.Width - loadingForm.Size.Width) / 2), Location.Y + ((Size.Height - loadingForm.Size.Height) / 2));
            }
        }

        /// <summary>
        /// Form closed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Form closed event args</param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            int lang_index = languagesComboBox.SelectedIndex;
            LauncherConfigDataContract lcdc = new LauncherConfigDataContract((lang_index >= 0) ? (new List<Language>(Translator.TranslatorInterface.Languages))[lang_index].Culture : "en-GB", selectedAPIIndex, developmentDirectorySingleLineTextField.Text, chatlogColorCodesCheckBox.Checked, chatlogColoredCheckBox.Checked, chatlogTimestampCheckBox.Checked, !(showUsernameDialogCheckBox.Checked), !(closeWhenLaunchedCheckBox.Checked), createSessionsLogCheckBox.Checked);
            SAMP.LauncherConfigIO = lcdc;
            SaveDeveloperToolsConfig();
            keepRunning = false;
            lock (loadServers)
            {
                foreach (ServerListEntry server_list_entry in loadServers)
                {
                    server_list_entry.Dispose();
                }
                loadServers.Clear();
            }
            lock (loadedServers)
            {
                foreach (ServerListEntry server_list_entry in loadedServers)
                {
                    server_list_entry.Dispose();
                }
                loadedServers.Clear();
            }
            lock (loadedGallery)
            {
                loadedGallery.Clear();
            }
            if (serversThread != null)
            {
                serversThread.Join();
                serversThread = null;
            }
            if (serversRowThread != null)
            {
                serversRowThread.Join();
                serversRowThread = null;
            }
            if (galleryThread != null)
            {
                galleryThread.Abort();
                galleryThread = null;
            }
            if (sessionsThread != null)
            {
                sessionsThread.Abort();
                sessionsThread = null;
            }
            SAMP.CloseLastServer();
            ThumbnailsCache.Clear();
        }

        /// <summary>
        /// Languages combo box selected index changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void languagesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = languagesComboBox.SelectedIndex;
            if (i >= 0)
            {
                List<Language> langs = new List<Language>(Translator.TranslatorInterface.Languages);
                if (Translator.ChangeLanguage(langs[i]))
                {
                    Application.Restart();
                }
            }
        }

        /// <summary>
        /// GitHub project picture box click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void gitHubProjectPictureBox_Click(object sender, EventArgs e)
        {
            SAMP.OpenGitHubProject();
        }

        /// <summary>
        /// Generic grid view data error event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Data grid view data error event arguments</param>
        private void genericGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // null route
            e.ThrowException = false;
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

        /// <summary>
        /// Main tab control selected index changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainTabControl.SelectedTab == mediaPage)
            {
                if (galleryThread == null)
                {
                    ReloadGallery();
                }
            }
            else if (mainTabControl.SelectedTab == sessionsPage)
            {
                if (sessionsThread == null)
                {
                    ReloadSessionsData();
                }
            }
        }

        /// <summary>
        /// Gallery file system watcher changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">File system event arguments</param>
        private void galleryFileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            ThumbnailsCache.RemoveFromCache(e.FullPath);
            ReloadGallery();
        }

        /// <summary>
        /// Gallery file system watcher created event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">File system event arguments</param>
        private void galleryFileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
            ReloadGallery();
        }

        /// <summary>
        /// Gallery file system watcher Deleted event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">File system event arguments</param>
        private void galleryFileSystemWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            ThumbnailsCache.RemoveFromCache(e.FullPath);
            ReloadGallery();
        }

        /// <summary>
        /// Gallery file system watcher renamed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Renamed event arguments</param>
        private void galleryFileSystemWatcher_Renamed(object sender, RenamedEventArgs e)
        {
            ThumbnailsCache.RemoveFromCache(e.OldFullPath);
            ReloadGallery();
        }

        /// <summary>
        /// Gallery view picture box click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void galleryViewPictureBox_Click(object sender, EventArgs e)
        {
            ViewSelectedImage();
        }

        /// <summary>
        /// Gallery ddelete picture box click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void galleryDeletePictureBox_Click(object sender, EventArgs e)
        {
            DeleteSelectedImage();
        }

        /// <summary>
        /// Gallery list view double click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void galleryListView_DoubleClick(object sender, EventArgs e)
        {
            ViewSelectedImage();
        }

        /// <summary>
        /// Show gallery picture box click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void showGalleryPictureBox_Click(object sender, EventArgs e)
        {
            SAMP.ShowGallery();
        }

        /// <summary>
        /// Gallery list view key up event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Key event arguments</param>
        private void galleryListView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                ViewSelectedImage();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                DeleteSelectedImage();
            }
        }

        /// <summary>
        /// Connect button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void connectButton_Click(object sender, EventArgs e)
        {
            Connect(quitWhenDone: closeWhenLaunchedCheckBox.Checked, createSessionLog: createSessionsLogCheckBox.Checked);
        }

        /// <summary>
        /// Launch debug mode button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void launchDebugModeButton_Click(object sender, EventArgs e)
        {
            SAMP.LaunchSAMPDebugMode(closeWhenLaunchedCheckBox.Checked, createSessionsLogCheckBox.Checked, this);
            lastMediaState = SAMP.LastMediaState;
        }

        /// <summary>
        /// Launch singleplayer button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void launchSingleplayerButton_Click(object sender, EventArgs e)
        {
            SAMP.LaunchSingleplayerMode(closeWhenLaunchedCheckBox.Checked, this);
        }

        /// <summary>
        /// Text file system watcher changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">File system event arguments</param>
        private void textFileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            switch (e.Name)
            {
                case "chatlog.txt":
                    lastChatlogRichTextBox.Text = SAMP.Chatlog;
                    break;
                case "savedpositions.txt":
                    savedPositionsTextBox.Text = SAMP.SavedPositions;
                    break;
            }
        }

        /// <summary>
        /// Save configuration button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void saveConfigButton_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        /// <summary>
        /// Page size single line text field text changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void pageSizeSingleLineTextField_TextChanged(object sender, EventArgs e)
        {
            int v = 0;
            if (!(int.TryParse(pageSizeSingleLineTextField.Text, out v)))
            {
                pageSizeSingleLineTextField.Text = "0";
            }
        }

        /// <summary>
        /// FPS limit track bar value changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void fpsLimitTrackBar_ValueChanged(object sender, EventArgs e)
        {
            fpsLimitSingleLineTextField.Text = fpsLimitTrackBar.Value.ToString();
        }

        /// <summary>
        /// FPS limit single line text field text changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void fpsLimitSingleLineTextField_TextChanged(object sender, EventArgs e)
        {
            int v = 0;
            if (int.TryParse(fpsLimitSingleLineTextField.Text, out v))
            {
                if (v < fpsLimitTrackBar.Minimum)
                {
                    v = fpsLimitTrackBar.Minimum;
                }
                else if (v > fpsLimitTrackBar.Maximum)
                {
                    v = fpsLimitTrackBar.Maximum;
                }
                if (fpsLimitSingleLineTextField.Text != v.ToString())
                {
                    fpsLimitSingleLineTextField.Text = v.ToString();
                }
                fpsLimitTrackBar.Value = v;
            }
            else
            {
                fpsLimitSingleLineTextField.Text = fpsLimitTrackBar.Minimum.ToString();
                fpsLimitTrackBar.Value = fpsLimitTrackBar.Minimum;
            }
        }

        /// <summary>
        /// Revert configuration button event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void revertConfigButton_Click(object sender, EventArgs e)
        {
            ReloadSAMPConfig();
        }

        /// <summary>
        /// Show extended server information tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void showExtendedServerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Server server = SelectedServer;
            if (server != null)
            {
                multithreadedListsTimer.Stop();
                ExtendedServerInformationForm esif = new ExtendedServerInformationForm(server);
                esif.ShowDialog();
                DialogResult = DialogResult.None;
                multithreadedListsTimer.Start();
            }
        }

        /// <summary>
        /// Add server to favourites tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void addServerToFavouritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Server server = SelectedServer;
            if (server != null)
            {
                List<IndexedServerListConnector> connectors = new List<IndexedServerListConnector>();
                List<ServerListConnector> apis = SAMP.APIIO;
                for (int i = 0; i < apis.Count; i++)
                {
                    ServerListConnector slc = apis[i];
                    if ((slc.ServerListType == EServerListType.Favourites) || (slc.ServerListType == EServerListType.LegacyFavourites))
                    {
                        connectors.Add(new IndexedServerListConnector(slc, i));
                    }
                }
                if (connectors.Count <= 0)
                {
                    MessageBox.Show(Translator.GetTranslation("NO_FAVOURITES"), Translator.GetTranslation("NO_FAVOURITES_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    IndexedServerListConnector islc = null;
                    if (connectors.Count > 1)
                    {
                        FavouriteListsForm flf = new FavouriteListsForm(connectors);
                        DialogResult result = flf.ShowDialog();
                        DialogResult = DialogResult.None;
                        if (result == DialogResult.OK)
                        {
                            islc = flf.SelectedServerListConnector;
                        }
                    }
                    else
                    {
                        islc = connectors[0];
                    }
                    if (islc != null)
                    {
                        ServerListConnector slc = islc.ServerListConnector;
                        Dictionary<string, Server> servers = slc.ServerListIO;
                        if (servers.ContainsKey(server.IPPortString))
                        {
                            MessageBox.Show(Translator.GetTranslation("SERVER_ALREADY_IN_FAVOURITES"), Translator.GetTranslation("ALREADY_IN_FAVOURITES"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            servers.Add(server.IPPortString, server.ToFavouriteServer("", ""));
                            slc.ServerListIO = servers;
                            ReloadFavourites(servers, islc.Index);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Remove server from favourites tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void removeServerFromFavouritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveSelectionFromFavourites();
        }

        /// <summary>
        /// Connect tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connect(quitWhenDone: closeWhenLaunchedCheckBox.Checked, createSessionLog: createSessionsLogCheckBox.Checked);
        }

        /// <summary>
        /// Connect with RCON tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void connectWithRCONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RCONPasswordForm rconf = new RCONPasswordForm();
            DialogResult result = rconf.ShowDialog();
            DialogResult = DialogResult.None;
            if (result == DialogResult.OK)
            {
                Connect(null, rconf.RCONPassword, closeWhenLaunchedCheckBox.Checked, createSessionLog: createSessionsLogCheckBox.Checked);
            }
        }

        /// <summary>
        /// Servers grid view cell double click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Data grid view cell event arguments</param>
        private void serversGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Connect(quitWhenDone: closeWhenLaunchedCheckBox.Checked, createSessionLog: createSessionsLogCheckBox.Checked);
            }
        }

        /// <summary>
        /// Select API combo box selected index changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void selectAPIComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAPIIndex = selectAPIComboBox.SelectedIndex;
            SelectAPI();
        }

        /// <summary>
        /// GitHub link label link clicked event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Link label link clicked event arguments</param>
        private void gitHubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SAMP.OpenGitHubProject();
        }

        /// <summary>
        /// API add picture box click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void apiAddPictureBox_Click(object sender, EventArgs e)
        {
            AddNewAPI();
        }

        /// <summary>
        /// API remove picture box click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void apiRemovePictureBox_Click(object sender, EventArgs e)
        {
            RemoveSelectedAPI();
        }

        /// <summary>
        /// API edit picture box click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void apiEditPictureBox_Click(object sender, EventArgs e)
        {
            EditSelectedAPI();
        }

        /// <summary>
        /// Add new API tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void addNewAPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewAPI();
        }

        /// <summary>
        /// Edit selected API too strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void editSelectedAPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditSelectedAPI();
        }

        /// <summary>
        /// Remove selected API tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void removeSelectedAPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveSelectedAPI();
        }

        /// <summary>
        /// API grid view double click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void apiGridView_DoubleClick(object sender, EventArgs e)
        {
            EditSelectedAPI();
        }

        /// <summary>
        /// Servers grid view key up event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Key event arguments</param>
        private void serversGridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                RemoveSelectionFromFavourites(false);
            }
        }

        /// <summary>
        /// Revert API list tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void revertAPIListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Translator.GetTranslation("REVERT_API_LIST"), Translator.GetTranslation("REVERT_API_LIST_TITLE"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SAMP.RevertAPIs();
                ReloadAPIs();
            }
        }

        /// <summary>
        /// Connect to host click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void connectToHostButton_Click(object sender, EventArgs e)
        {
            ConnectHostForm chf = new ConnectHostForm(SelectedServer);
            DialogResult result = chf.ShowDialog();
            DialogResult = DialogResult.None;
            if (result == DialogResult.OK)
            {
                Server server = new Server(chf.HostAndPort, false);
                Connect(server, quitWhenDone: closeWhenLaunchedCheckBox.Checked, createSessionLog: createSessionsLogCheckBox.Checked);
                server.Dispose();
            }
        }

        /// <summary>
        /// Rules grid view cell double click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Data grid view cell event arguments</param>
        private void rulesGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in rulesGridView.SelectedRows)
                {
                    if (row.Cells[0].Value.ToString() == "weburl")
                    {
                        VisitWebsite(row.Cells[1].Value.ToString());
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Visit website tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void visitWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedServer != null)
            {
                VisitWebsite(SelectedServer.GetRuleValue("weburl"));
            }
        }

        /// <summary>
        /// Search on Bing tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void searchOnBingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedServer != null)
            {
                Process.Start("https://bing.com/search?q=" + Uri.EscapeUriString(SelectedServer.IPPortString + " " + SelectedServer.Hostname));
            }
        }

        /// <summary>
        /// Search on DuckDuckGo tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void searchOnDuckDuckGoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedServer != null)
            {
                Process.Start("https://duckduckgo.com/?q=" + Uri.EscapeUriString(SelectedServer.IPPortString + " " + SelectedServer.Hostname));
            }
        }

        /// <summary>
        /// Search on Google tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void searchOnGoogleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedServer != null)
            {
                Process.Start("https://google.com/search?q=" + Uri.EscapeUriString(SelectedServer.IPPortString + " " + SelectedServer.Hostname));
            }
        }

        /// <summary>
        /// Search on Yahoo tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void searchOnYahooToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedServer != null)
            {
                Process.Start("https://search.yahoo.com/search?p=" + Uri.EscapeUriString(SelectedServer.IPPortString + " " + SelectedServer.Hostname));
            }
        }

        /// <summary>
        /// Search on Yandex tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void searchOnYandexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedServer != null)
            {
                Process.Start("https://yandex.ru/search/?text=" + Uri.EscapeUriString(SelectedServer.IPPortString + " " + SelectedServer.Hostname));
            }
        }

        /// <summary>
        /// Search on YouTube tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void searchOnYouTubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedServer != null)
            {
                Process.Start("https://youtube.com/results?search_query=" + Uri.EscapeUriString(SelectedServer.IPPortString + " " + SelectedServer.Hostname));
            }
        }

        /// <summary>
        /// Developer tools show additional configurations button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void developerToolsShowAdditionalConfigurationsButton_Click(object sender, EventArgs e)
        {
            LauncherConfigDataContract lcdc = SAMP.LauncherConfigIO;
            lcdc.DevelopmentDirectory = developmentDirectorySingleLineTextField.Text;
            SAMP.LauncherConfigIO = lcdc;
            DeveloperToolsConfigDataContract dtcdc = SAMP.DeveloperToolsConfigIO;
            dtcdc.Hostname = developerToolsHostnameSingleLineTextField.Text;
            dtcdc.Port = Utils.GetInt(developerToolsPortSingleLineTextField.Text);
            dtcdc.Password = developerToolsServerPasswordSingleLineTextField.Text;
            dtcdc.RCONPassword = developerToolsRCONPasswordSingleLineTextField.Text;
            DeveloperToolsConfigForm dtcf = new DeveloperToolsConfigForm(dtcdc);
            DialogResult result = dtcf.ShowDialog();
            DialogResult = DialogResult.None;
            if (result == DialogResult.OK)
            {
                dtcdc = dtcf.DeveloperToolsConfigDataContract;
                developerToolsHostnameSingleLineTextField.Text = dtcdc.Hostname;
                developerToolsPortSingleLineTextField.Text = dtcdc.Port.ToString();
                developerToolsServerPasswordSingleLineTextField.Text = dtcdc.Password;
                developerToolsRCONPasswordSingleLineTextField.Text = dtcdc.RCONPassword;
                List<string> entries = new List<string>();
                foreach (var item in developerToolsGamemodesCheckedListBox.CheckedItems)
                {
                    entries.Add(item.ToString());
                }
                dtcdc.Gamemodes = entries.ToArray();
                entries.Clear();
                foreach (var item in developerToolsFilterscriptsCheckedListBox.CheckedItems)
                {
                    entries.Add(item.ToString());
                }
                dtcdc.Filterscripts = entries.ToArray();
                entries.Clear();
                foreach (var item in developerToolsPluginsCheckedListBox.CheckedItems)
                {
                    entries.Add(item.ToString());
                }
                dtcdc.Plugins = entries.ToArray();
                entries.Clear();
                SAMP.DeveloperToolsConfigIO = dtcdc;
                ReloadDeveloperToolsConfig();
            }
        }

        /// <summary>
        /// Development directory single line text field text changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void developmentDirectorySingleLineTextField_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(developmentDirectorySingleLineTextField.Text))
            {
                LauncherConfigDataContract lcdc = SAMP.LauncherConfigIO;
                lcdc.DevelopmentDirectory = developmentDirectorySingleLineTextField.Text;
                SAMP.LauncherConfigIO = lcdc;
                ReloadDeveloperToolsConfig();
            }
        }

        /// <summary>
        /// Developer tools open directory button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void developerToolsOpenDirectoryButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(developmentDirectorySingleLineTextField.Text))
            {
                Process.Start("explorer.exe", Path.GetFullPath(developmentDirectorySingleLineTextField.Text));
            }
        }

        /// <summary>
        /// Developer tools start server button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void developerToolsStartServerButton_Click(object sender, EventArgs e)
        {
            SaveDeveloperToolsConfig();
            if (SAMPCTLProvider.Update())
            {
                SAMP.LaunchSAMPServer();
            }
        }

        /// <summary>
        /// Stop server button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void stopServerButton_Click(object sender, EventArgs e)
        {
            SAMP.CloseLastServer();
        }

        /// <summary>
        /// Developer tools connect to test server button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void developerToolsConnectToTestServerButton_Click(object sender, EventArgs e)
        {
            DeveloperToolsConfigDataContract dtcdc = SAMP.DeveloperToolsConfigIO;
            Connect(new Server("127.0.0.1:" + dtcdc.Port, false), dtcdc.RCONPassword, createSessionLog: createSessionsLogCheckBox.Checked);
        }

        /// <summary>
        /// Patch version picture box click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void patchVersionPictureBox_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in versionsListView.SelectedItems)
            {
                if (item.Tag is SAMPVersionDataContract)
                {
                    SAMPVersionDataContract version = (SAMPVersionDataContract)(item.Tag);
                    if (SAMPProvider.CurrentVersion != version)
                    {
                        if (MessageBox.Show(string.Format(Translator.GetTranslation("PATCH_VERSION"), version.Name), Translator.GetTranslation("PATCH_VERSION_TITLE"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            SAMP.ChangeSAMPVersion(version, false);
                            ReloadVersions();
                        }
                    }
                    break;
                }
            }
        }

        /// <summary>
        /// Install version picture box click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void installVersionPictureBox_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in versionsListView.SelectedItems)
            {
                if (item.Tag is SAMPVersionDataContract)
                {
                    SAMPVersionDataContract version = (SAMPVersionDataContract)(item.Tag);
                    if (SAMPProvider.CurrentVersion != version)
                    {
                        if (MessageBox.Show(string.Format(Translator.GetTranslation("INSTALL_VERSION"), version.Name), Translator.GetTranslation("INSTALL_VERSION_TITLE"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            SAMP.ChangeSAMPVersion(version, true);
                            ReloadVersions();
                        }
                    }
                    break;
                }
            }
        }

        /// <summary>
        /// Versions list view mouse double click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Mouse event arguments</param>
        private void versionsListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem item in versionsListView.SelectedItems)
            {
                if (item.Tag is SAMPVersionDataContract)
                {
                    SAMPVersionDataContract version = (SAMPVersionDataContract)(item.Tag);
                    if (SAMPProvider.CurrentVersion != version)
                    {
                        switch (MessageBox.Show(string.Format(Translator.GetTranslation("SELECT_VERSION"), version.Name), Translator.GetTranslation("SELECT_VERSION_TITLE"), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning))
                        {
                            case DialogResult.Yes:
                                SAMP.ChangeSAMPVersion(version, false);
                                ReloadVersions();
                                break;
                            case DialogResult.No:
                                SAMP.ChangeSAMPVersion(version, true);
                                ReloadVersions();
                                break;
                        }
                    }
                    break;
                }
            }
        }

        /// <summary>
        /// Add address to favourites list tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void addAddressToFavouriteListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAddressToFavouriteListForm aatflf = new AddAddressToFavouriteListForm(FavouriteLists);
            DialogResult result = aatflf.ShowDialog();
            DialogResult = DialogResult.None;
            if (result == DialogResult.OK)
            {
                IndexedServerListConnector islc = aatflf.SelectedServerListConnector;
                ServerListConnector slc = islc.ServerListConnector;
                Dictionary<string, Server> servers = slc.ServerListIO;
                FavouriteServer server = new FavouriteServer(aatflf.Address, "", "", "", "");
                if (servers.ContainsKey(server.IPPortString))
                {
                    MessageBox.Show(Translator.GetTranslation("SERVER_ALREADY_IN_FAVOURITES"), Translator.GetTranslation("ALREADY_IN_FAVOURITES"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    servers.Add(server.IPPortString, server);
                    slc.ServerListIO = servers;
                    ReloadFavourites(servers, islc.Index);
                }
                server.Dispose();
            }
        }

        /// <summary>
        /// Show username dialog checkbox checked changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void showUsernameDialogCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            usernamePanel.Visible = !(showUsernameDialogCheckBox.Checked);
        }

        /// <summary>
        /// Username single line text field text changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void usernameSingleLineTextField_TextChanged(object sender, EventArgs e)
        {
            SAMP.Username = usernameSingleLineTextField.Text.Trim();
        }

        /// <summary>
        /// CHatlog generic check box checked changed event
        /// </summary>
        /// <param name="sender">Sendere</param>
        /// <param name="e">Event arguments</param>
        private void chatlogGenericCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChatlogFormat();
        }

        /// <summary>
        /// Plugins add picture box click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void pluginsAddPictureBox_Click(object sender, EventArgs e)
        {
            AddNewPluginData();
        }

        /// <summary>
        /// Plugins edit picture box click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void pluginsEditPictureBox_Click(object sender, EventArgs e)
        {
            EditSelectedPluginData();
        }

        /// <summary>
        /// Plugins remove picture box click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void pluginsRemovePictureBox_Click(object sender, EventArgs e)
        {
            RemoveSelectedPluginData();
        }

        /// <summary>
        /// Plugins grid view sdouble click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void pluginsGridView_DoubleClick(object sender, EventArgs e)
        {
            EditSelectedPluginData();
        }

        /// <summary>
        /// Plugins grid view cell content click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void pluginsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 1) && (e.RowIndex >= 0))
            {
                if (e.RowIndex < pluginsGridView.Rows.Count)
                {
                    object index = pluginsGridView.Rows[e.RowIndex].Cells[0].Value;
                    if (index is int)
                    {
                        int i = (int)index;
                        if (i >= 0)
                        {
                            PluginDataContract[] plugins = SAMP.PluginsDataIO;
                            if (i < plugins.Length)
                            {
                                PluginDataContract plugin = plugins[i];
                                plugins[i] = new PluginDataContract(plugin.Name, plugin.Provider, plugin.URI, !(plugin.Enabled), plugin.UpdateFrequency);
                                SAMP.PluginsDataIO = plugins;
                                ReloadPluginsData();
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Add new plugin tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void addNewPluginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewPluginData();
        }

        /// <summary>
        /// Edit selected plugin 
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void editSelectedPluginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditSelectedPluginData();
        }

        /// <summary>
        /// Remove selected plugin tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void removeSelectedPluginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveSelectedPluginData();
        }

        /// <summary>
        /// Revert plugin list tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void revertPluginListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Translator.GetTranslation("REVERT_PLUGIN_LIST"), Translator.GetTranslation("REVERT_PLUGIN_LIST_TITLE"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SAMP.RevertPluginsData();
                ReloadPluginsData();
            }
        }

        /// <summary>
        /// Last chatlog copy text as tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void lastChatlogCopyTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ChatlogFormatter.Format(SAMP.Chatlog, EChatlogFormatType.Plain, chatlogColorCodesCheckBox.Checked, chatlogColoredCheckBox.Checked, chatlogTimestampCheckBox.Checked));
        }

        /// <summary>
        /// Last chatlog copy original text as tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void lastChatlogCopyOriginalTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SAMP.Chatlog);
        }

        /// <summary>
        /// Last chatlog copy HTML as tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void lastChatlogCopyHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ChatlogFormatter.Format(SAMP.Chatlog, EChatlogFormatType.HTMLSnippet, chatlogColorCodesCheckBox.Checked, chatlogColoredCheckBox.Checked, chatlogTimestampCheckBox.Checked));
        }

        /// <summary>
        /// Last chatlog copy RTF as tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void lastChatlogCopyRTFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ChatlogFormatter.Format(SAMP.Chatlog, EChatlogFormatType.RTF, chatlogColorCodesCheckBox.Checked, chatlogColoredCheckBox.Checked, chatlogTimestampCheckBox.Checked));
        }

        /// <summary>
        /// Last chatlog save text as tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void lastChatlogSaveTextAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastChatlogSaveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            DialogResult result = lastChatlogSaveFileDialog.ShowDialog();
            DialogResult = DialogResult.None;
            if (result == DialogResult.OK)
            {
                Utils.SaveTextFile(lastChatlogSaveFileDialog.FileName, ChatlogFormatter.Format(SAMP.Chatlog, EChatlogFormatType.Plain, chatlogColorCodesCheckBox.Checked, chatlogColoredCheckBox.Checked, chatlogTimestampCheckBox.Checked));
            }
        }

        /// <summary>
        /// Last chatlog save original text as tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void lastChatlogSaveOriginalTextAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastChatlogSaveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            DialogResult result = lastChatlogSaveFileDialog.ShowDialog();
            DialogResult = DialogResult.None;
            if (result == DialogResult.OK)
            {
                Utils.SaveTextFile(lastChatlogSaveFileDialog.FileName, SAMP.Chatlog);
            }
        }

        /// <summary>
        /// Last chatlog save HTML as tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void lastChatlogSaveHTMLAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastChatlogSaveFileDialog.Filter = "Hypertext Markup Language files (*.html)|*.html|Hypertext Markup Language files (*.htm)|*.htm|All files (*.*)|*.*";
            DialogResult result = lastChatlogSaveFileDialog.ShowDialog();
            DialogResult = DialogResult.None;
            if (result == DialogResult.OK)
            {
                Utils.SaveTextFile(lastChatlogSaveFileDialog.FileName, ChatlogFormatter.Format(SAMP.Chatlog, EChatlogFormatType.HTML, chatlogColorCodesCheckBox.Checked, chatlogColoredCheckBox.Checked, chatlogTimestampCheckBox.Checked));
            }
        }

        /// <summary>
        /// Last chatlog save RTF as tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void lastChatlogSaveRTFAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastChatlogSaveFileDialog.Filter = "Rich Text Format files (*.rtf)|*.rtf|All files (*.*)|*.*";
            DialogResult result = lastChatlogSaveFileDialog.ShowDialog();
            DialogResult = DialogResult.None;
            if (result == DialogResult.OK)
            {
                Utils.SaveTextFile(lastChatlogSaveFileDialog.FileName, ChatlogFormatter.Format(SAMP.Chatlog, EChatlogFormatType.RTF, chatlogColorCodesCheckBox.Checked, chatlogColoredCheckBox.Checked, chatlogTimestampCheckBox.Checked));
            }
        }

        /// <summary>
        /// Add servers filter picture box click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void addServersFilterPictureBox_Click(object sender, EventArgs e)
        {
            AddFilterControl();
        }

        /// <summary>
        /// Show empty servers tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void showEmptyServersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showEmptyServersToolStripMenuItem.Checked = !(showEmptyServersToolStripMenuItem.Checked);
            UpdateServerListFilters();
        }

        /// <summary>
        /// Show full servers tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void showFullServersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showFullServersToolStripMenuItem.Checked = !(showFullServersToolStripMenuItem.Checked);
            UpdateServerListFilters();
        }

        /// <summary>
        /// Reload server lists tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void reloadServerListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReloadAPIs(selectAPIComboBox.SelectedIndex);
        }

        /// <summary>
        /// Sessions file system watcher changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">File system event arguments</param>
        private void sessionsFileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            ReloadSessionsData();
        }

        /// <summary>
        /// Sessions file system watcher created event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">File system event arguments</param>
        private void sessionsFileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
            ReloadSessionsData();
        }

        /// <summary>
        /// Sessions file system watcher deleted event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">File system event arguments</param>
        private void sessionsFileSystemWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            ReloadSessionsData();
        }

        /// <summary>
        /// Sessions file system watcher renamed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">File system event arguments</param>
        private void sessionsFileSystemWatcher_Renamed(object sender, RenamedEventArgs e)
        {
            ReloadSessionsData();
        }

        /// <summary>
        /// Sessions data grid view row enter event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sessionsDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ReloadSelectedSessionData();
        }
    }
}
