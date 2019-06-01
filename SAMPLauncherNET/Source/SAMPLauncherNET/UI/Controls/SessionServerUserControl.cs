using System;
using System.Threading;
using System.Windows.Forms;
using WinFormsTranslator;

/// <summary>
/// SA:MP launcher .NET UI namespace
/// </summary>
namespace SAMPLauncherNET.UI
{
    /// <summary>
    /// Session server user control class
    /// </summary>
    public partial class SessionServerUserControl : UserControl
    {
        /// <summary>
        /// Session
        /// </summary>
        private Session session;

        /// <summary>
        /// Main form
        /// </summary>
        private MainForm mainForm;

        /// <summary>
        /// Server thread
        /// </summary>
        private Thread serverThread;

        /// <summary>
        /// Server
        /// </summary>
        private Server server;

        /// <summary>
        /// Hostname
        /// </summary>
        private string hostname;

        /// <summary>
        /// Mode
        /// </summary>
        private string mode;

        /// <summary>
        /// Language
        /// </summary>
        private string language;

        /// <summary>
        /// Username translated
        /// </summary>
        private string usernameTranslated;

        /// <summary>
        /// Game version translated
        /// </summary>
        private string gameVersionTranslated;

        /// <summary>
        /// Hostname translated
        /// </summary>
        private string hostnameTranslated;

        /// <summary>
        /// gamemode translated
        /// </summary>
        private string gamemodeTranslated;

        /// <summary>
        /// Language translated
        /// </summary>
        private string languageTranslated;

        /// <summary>
        /// Date and time translated
        /// </summary>
        private string dateAndTimeTranslated;

        /// <summary>
        /// Time spend translated
        /// </summary>
        private string timeSpendTranslated;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="session">Session</param>
        public SessionServerUserControl(Session session, MainForm mainForm)
        {
            this.session = session;
            this.mainForm = mainForm;
            InitializeComponent();
            Utils.Translator.TranslateControls(this);
            usernameTranslated = Utils.Translator.GetTranslation("USERNAME");
            gameVersionTranslated = Utils.Translator.GetTranslation("GAME_VERSION");
            hostnameTranslated = Utils.Translator.GetTranslation("HOSTNAME");
            gamemodeTranslated = Utils.Translator.GetTranslation("GAMEMODE");
            languageTranslated = Utils.Translator.GetTranslation("LANGUAGE");
            dateAndTimeTranslated = Utils.Translator.GetTranslation("DATE_AND_TIME");
            timeSpendTranslated = Utils.Translator.GetTranslation("TIME_SPEND");

            hostname = session.Hostname;
            mode = session.Mode;
            language = session.Language;
            Disposed += (sender, e) =>
            {
                if (serverThread != null)
                {
                    serverThread.Abort();
                    serverThread = null;
                }
            };
            serverThread = new Thread(() =>
            {
                server = new Server(session.IPPort, true);
                if (server.IsValid)
                {
                    while (true)
                    {
                        string hostname = server.Hostname;
                        string mode = server.Gamemode;
                        string language = server.Language;
                        if (hostname.Length > 0)
                        {
                            this.hostname = hostname;
                        }
                        if (mode.Length > 0)
                        {
                            this.mode = mode;
                        }
                        if (language.Length > 0)
                        {
                            this.language = language;
                        }
                        Thread.Sleep(2000);
                    }
                }
                server.Dispose();
                server = null;
            });
            serverThread.Start();
            UpdateTextLabel();
        }

        /// <summary>
        /// Update text label
        /// </summary>
        private void UpdateTextLabel()
        {
            textLabel.Text = usernameTranslated + ": " + session.Username + Environment.NewLine + Environment.NewLine + gameVersionTranslated + ": " + session.GameVersion + Environment.NewLine + Environment.NewLine + hostnameTranslated + ": " + hostname + Environment.NewLine + Environment.NewLine + gamemodeTranslated + ": " + mode + Environment.NewLine + Environment.NewLine + languageTranslated + ": " + language + Environment.NewLine + Environment.NewLine + dateAndTimeTranslated + ": " + session.DateTime + Environment.NewLine + Environment.NewLine + timeSpendTranslated + ": " + session.TimeSpan;
        }

        /// <summary>
        /// Conbnect button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void connectButton_Click(object sender, EventArgs e)
        {
            mainForm.ConnectUsingSession(session);
        }

        /// <summary>
        /// Tick timer tick event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void tickTimer_Tick(object sender, EventArgs e)
        {
            UpdateTextLabel();
        }
    }
}
