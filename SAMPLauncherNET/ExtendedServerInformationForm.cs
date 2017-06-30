using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using WinFormsTranslator;

namespace SAMPLauncherNET
{
    public partial class ExtendedServerInformationForm : MaterialForm
    {
        Server server = null;

        private List<uint> pingList = new List<uint>();

        private Thread serverPingThread = null;

        private Thread serverInformationThread = null;

        private Thread serverDetailedClientsThread = null;

        private Thread serverRulesThread = null;

        private string hostname = "";

        private ushort playerCount = 0;

        private ushort maxPlayers = 0;

        private string gamemode = "";

        private string language = "";

        private List<Player> players = new List<Player>();

        private Dictionary<string, string> rules = new Dictionary<string, string>();

        public ExtendedServerInformationForm(Server server)
        {
            this.server = server;
            InitializeComponent();
            Translator.LoadTranslation(this);
            ipAndPortLabel.Text = Translator.GetTranslation("IP_AND_PORT") + ": " + server.IPPortString;
            serverPingThread = new Thread(() =>
            {
                while (true)
                {
                    server.FetchData(ERequestType.Ping);
                    if (server.IsDataFetched(ERequestType.Ping))
                    {
                        lock (pingList)
                        {
                            pingList.Add(server.Ping);
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
                    server.FetchData(ERequestType.Information);
                    if (server.IsDataFetched(ERequestType.Information))
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
                    server.FetchData(ERequestType.DetailedClients);
                    if (server.IsDataFetched(ERequestType.DetailedClients))
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
                    server.FetchData(ERequestType.Rules);
                    if (server.IsDataFetched(ERequestType.Rules))
                    {
                        lock (rules)
                        {
                            rules.Clear();
                            foreach (string key in server.RuleKeys)
                                rules.Add(key, server.GetRuleValue(key));
                        }
                    }
                    Thread.Sleep(2000);
                }
            });
            serverRulesThread.Start();
        }

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

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            lock (pingList)
            {
                pingChart.Series[0].Points.DataBindY(pingList);
                if (pingList.Count > 0)
                    pingLabel.Text = Translator.GetTranslation("PING") + ": " + pingList[pingList.Count - 1] + " ms";
            }
            lock (hostname)
            {
                hostnameLabel.Text = Translator.GetTranslation("HOSTNAME") + ": " + hostname;
                playersLabel.Text = Translator.GetTranslation("PLAYERS") + ": " + playerCount + "/" + maxPlayers;
            }
            lock (gamemode)
            {
                gamemodeLabel.Text = Translator.GetTranslation("GAMEMODE") + ": " + gamemode;
            }
            lock (gamemode)
            {
                languageLabel.Text = Translator.GetTranslation("LANGUAGE") + ": " + language;
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
                        cs = true;
                    ++i;
                }
                if (cs)
                    playersGridView.Rows[si].Selected = true;
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
                        cs = true;
                    ++i;
                }
                if (cs)
                    rulesGridView.Rows[si].Selected = true;
            }
        }
    }
}
