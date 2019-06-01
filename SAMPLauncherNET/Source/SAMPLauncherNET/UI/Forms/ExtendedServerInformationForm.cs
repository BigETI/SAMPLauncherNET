using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsTranslator;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Extended server information form class
    /// </summary>
    public partial class ExtendedServerInformationForm : MaterialForm
    {
        /// <summary>
        /// Ping count limit
        /// </summary>
        private const uint PingCountLimit = 50U;

        /// <summary>
        /// Server
        /// </summary>
        private readonly Server server;

        /// <summary>
        /// Ping list
        /// </summary>
        private readonly List<uint> pingList = new List<uint>();

        /// <summary>
        /// Server ping thread
        /// </summary>
        private Thread serverPingThread;

        /// <summary>
        /// Server information thread
        /// </summary>
        private Thread serverInformationThread;

        /// <summary>
        /// Server detailed clients thread
        /// </summary>
        private Thread serverDetailedClientsThread;

        /// <summary>
        /// Server rules thread
        /// </summary>
        private Thread serverRulesThread;

        /// <summary>
        /// Hostname
        /// </summary>
        private string hostname = "";

        /// <summary>
        /// Player count
        /// </summary>
        private ushort playerCount;

        /// <summary>
        /// Maximal players
        /// </summary>
        private ushort maxPlayers;

        /// <summary>
        /// Gamemode
        /// </summary>
        private string gamemode = "";

        /// <summary>
        /// Language
        /// </summary>
        private string language = "";

        /// <summary>
        /// Players
        /// </summary>
        private readonly List<Player> players = new List<Player>();

        /// <summary>
        /// Rules
        /// </summary>
        private readonly Dictionary<string, string> rules = new Dictionary<string, string>();

        /// <summary>
        /// Geo location async
        /// </summary>
        private readonly Task<GeoLocationData> geoLocationAsync;

        /// <summary>
        /// Geo location
        /// </summary>
        private GeoLocationData geoLocation;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="server"></param>
        public ExtendedServerInformationForm(Server server)
        {
            this.server = server;
            InitializeComponent();
            Utils.Translator.TranslateControls(this);
            playersGridView.Columns[0].HeaderText = Utils.Translator.GetTranslation("ID");
            playersGridView.Columns[1].HeaderText = Utils.Translator.GetTranslation("PLAYER");
            playersGridView.Columns[2].HeaderText = Utils.Translator.GetTranslation("SCORE");
            playersGridView.Columns[3].HeaderText = Utils.Translator.GetTranslation("PING");
            rulesGridView.Columns[0].HeaderText = Utils.Translator.GetTranslation("RULE");
            rulesGridView.Columns[1].HeaderText = Utils.Translator.GetTranslation("VALUE");
            ipAndPortLabel.Text = Utils.Translator.GetTranslation("IP_AND_PORT") + ": " + server.IPPortString;
            serverPingThread = new Thread(() =>
            {
                while (true)
                {
                    server.FetchData(ERequestResponseType.Ping);
                    if (server.IsDataFetched(ERequestResponseType.Ping))
                    {
                        lock (pingList)
                        {
                            pingList.Add(server.Ping);
                            while (pingList.Count > PingCountLimit)
                            {
                                pingList.RemoveAt(0);
                            }
                        }
                    }
                    Thread.Sleep(1000);
                }
            });
            serverPingThread.Start();
            serverInformationThread = new Thread(() =>
            {
                while (true)
                {
                    server.FetchData(ERequestResponseType.Information);
                    if (server.IsDataFetched(ERequestResponseType.Information))
                    {
                        lock (hostname)
                        {
                            hostname = server.Hostname;
                            playerCount = server.PlayerCount;
                            maxPlayers = server.MaxPlayers;
                        }
                        lock (gamemode)
                        {
                            gamemode = server.Gamemode;
                        }
                        lock (language)
                        {
                            language = server.Language;
                        }
                    }
                    Thread.Sleep(2000);
                }
            });
            serverInformationThread.Start();
            serverDetailedClientsThread = new Thread(() =>
            {
                while (true)
                {
                    server.FetchData(ERequestResponseType.DetailedClients);
                    if (server.IsDataFetched(ERequestResponseType.DetailedClients))
                    {
                        lock (players)
                        {
                            players.Clear();
                            players.AddRange(server.PlayerValues);
                        }
                    }
                    Thread.Sleep(2000);
                }
            });
            serverDetailedClientsThread.Start();
            serverRulesThread = new Thread(() =>
            {
                while (true)
                {
                    server.FetchData(ERequestResponseType.Rules);
                    if (server.IsDataFetched(ERequestResponseType.Rules))
                    {
                        lock (rules)
                        {
                            rules.Clear();
                            foreach (string key in server.RuleKeys)
                            {
                                rules.Add(key, server.GetRuleValue(key));
                            }
                        }
                    }
                    Thread.Sleep(2000);
                }
            });
            serverRulesThread.Start();
            geoLocationAsync = GeoLocator.LocateAsync(server.IPv4AddressString);
        }

        /// <summary>
        /// Form closed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Form closed event arguments</param>
        private void ExtendedServerInformationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serverPingThread != null)
            {
                serverPingThread.Abort();
                serverPingThread = null;
            }
            if (serverInformationThread != null)
            {
                serverInformationThread.Abort();
                serverInformationThread = null;
            }
            if (serverDetailedClientsThread != null)
            {
                serverDetailedClientsThread.Abort();
                serverDetailedClientsThread = null;
            }
            if (serverRulesThread != null)
            {
                serverRulesThread.Abort();
                serverRulesThread = null;
            }
        }

        /// <summary>
        /// Update timer tick event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void updateTimer_Tick(object sender, EventArgs e)
        {
            lock (pingList)
            {
                pingChart.Series[0].Points.DataBindY(pingList);
                if (pingList.Count > 0)
                {
                    pingLabel.Text = Utils.Translator.GetTranslation("PING") + ": " + pingList[pingList.Count - 1] + " ms";
                }
            }
            lock (hostname)
            {
                hostnameLabel.Text = Utils.Translator.GetTranslation("HOSTNAME") + ": " + hostname;
                playersLabel.Text = Utils.Translator.GetTranslation("PLAYERS") + ": " + playerCount + "/" + maxPlayers;
            }
            lock (gamemode)
            {
                gamemodeLabel.Text = Utils.Translator.GetTranslation("GAMEMODE") + ": " + gamemode;
            }
            lock (gamemode)
            {
                languageLabel.Text = Utils.Translator.GetTranslation("LANGUAGE") + ": " + language;
            }
            lock (players)
            {
                int si = -1;
                bool cs = false;
                foreach (DataGridViewRow dgvr in playersGridView.SelectedRows)
                {
                    si = dgvr.Index;
                    break;
                }
                playersDataTable.Clear();
                int i = 0;
                foreach (Player player in players)
                {
                    DataRow dr = playersDataTable.NewRow();
                    object[] data = new object[4];
                    data[0] = player.ID;
                    data[1] = player.Name;
                    data[2] = player.Score;
                    data[3] = player.Ping;
                    dr.ItemArray = data;
                    playersDataTable.Rows.Add(dr);
                    if (i == si)
                    {
                        cs = true;
                    }
                    ++i;
                }
                if (cs)
                {
                    playersGridView.Rows[si].Selected = true;
                }
            }
            lock (rules)
            {
                int si = -1;
                bool cs = false;
                foreach (DataGridViewRow dgvr in rulesGridView.SelectedRows)
                {
                    si = dgvr.Index;
                    break;
                }
                rulesDataTable.Clear();
                int i = 0;
                foreach (KeyValuePair<string, string> rule in rules)
                {
                    DataRow dr = rulesDataTable.NewRow();
                    object[] data = new object[2];
                    data[0] = rule.Key;
                    data[1] = rule.Value;
                    dr.ItemArray = data;
                    rulesDataTable.Rows.Add(dr);
                    if (i == si)
                    {
                        cs = true;
                    }
                    ++i;
                }
                if (cs)
                {
                    rulesGridView.Rows[si].Selected = true;
                }
            }
            if ((geoLocation == null) && geoLocationAsync.IsCompleted)
            {
                geoLocation = geoLocationAsync.Result;
                countryLabel.Text = Utils.Translator.GetTranslation("COUNTRY") + ": " + geoLocation.CountryName + " (" + geoLocation.CountryCode + ")";
                regionLabel.Text = Utils.Translator.GetTranslation("REGION") + ": " + geoLocation.RegionName + " (" + geoLocation.RegionCode + ")";
                cityLabel.Text = Utils.Translator.GetTranslation("CITY") + ": " + geoLocation.ZIPCode + " " + geoLocation.City;
                timeZoneLabel.Text = Utils.Translator.GetTranslation("TIME_ZONE") + ": " + geoLocation.TimeZone;
                latitudeLongitudeLabel.Text = Utils.Translator.GetTranslation("LATITUDE_LONGITUDE") + ": " + geoLocation.Latitude + "; " + geoLocation.Longitude;
                metroCodeLabel.Text = Utils.Translator.GetTranslation("METRO_CODE") + ": " + geoLocation.MetroCode;
            }
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
        /// Show in Google Maps button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void showInGoogleMapsButton_Click(object sender, EventArgs e)
        {
            if (geoLocation != null)
            {
                if (geoLocation.IsValid)
                {
                    Process.Start("https://www.google.com/maps/@" + geoLocation.Latitude + "," + geoLocation.Longitude + ",10.0z");
                }
            }
        }

        /// <summary>
        /// Show in OpenStreetMap button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void showInOpenStreetMapButton_Click(object sender, EventArgs e)
        {
            if (geoLocationAsync != null)
            {
                if (geoLocation.IsValid)
                {
                    Process.Start("http://www.openstreetmap.org/?mlat=" + geoLocation.Latitude + "&mlon=" + geoLocation.Longitude + "&zoom=10.0");
                }
            }
        }
    }
}
