using MetroFramework.Forms;
using MetroTranslatorStyler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace SAMPLauncherNET
{
    public partial class ExtendedServerInformationForm : MetroForm
    {

        Server server = null;

        private List<uint> pingList = new List<uint>();

        private Thread serverPingThread = null;

        private Thread serverInformationThread = null;

        private Thread serverInformativePlayersThread = null;

        private string hostname = "";

        private ushort playerCount = 0;

        private ushort maxPlayers = 0;

        private string gamemode = "";

        private string language = "";

        private List<Player> players = new List<Player>();

        public ExtendedServerInformationForm(Server server)
        {
            this.server = server;
            InitializeComponent();
            TranslatorStyler.LoadTranslationStyle(this, TranslatorStyler.TranslatorStylerInterface);
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
            serverInformativePlayersThread = new Thread(() =>
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
            serverInformativePlayersThread.Start();
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
            if (serverInformativePlayersThread != null)
            {
                serverInformativePlayersThread.Abort();
                serverInformativePlayersThread = null;
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
                foreach (DataGridViewRow dgvr in playersGrid.SelectedRows)
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
                    playersGrid.Rows[si].Selected = true;
            }
        }
    }
}
