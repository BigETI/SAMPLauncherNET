using MetroFramework.Forms;
using MetroTranslatorStyler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMPLauncherNET
{
    public partial class ExtendedServerInformationForm : MetroForm
    {

        Server server = null;

        private Dictionary<uint, uint> pingList = new Dictionary<uint, uint>();

        private Thread serverPingThread = null;

        private Thread serverInformationThread = null;

        private string hostname = "";

        private ushort playerCount = 0;

        private ushort maxPlayers = 0;

        private string gamemode = "";

        private string language = "";

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
                    server.FetchPingData();
                    if (server.IsPingDataFetched)
                    {
                        lock (pingList)
                        {
                            pingList.Add((uint)(pingList.Count), server.Ping);
                        }
                    }
                    Thread.Sleep(1000);
                }
            });
            serverInformationThread = new Thread(() =>
            {
                while (true)
                {
                    server.FetchInformationData();
                    if (server.IsInformationDataFetched)
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
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            lock (pingList)
            {
                pingChart.Series[0].Points.DataBindXY(pingList.Keys, pingList.Values);
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
        }
    }
}
