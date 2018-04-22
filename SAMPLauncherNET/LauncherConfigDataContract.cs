using System.Runtime.Serialization;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Launcher config data contract class
    /// </summary>
    [DataContract]
    public class LauncherConfigDataContract
    {
        /// <summary>
        /// Language
        /// </summary>
        [DataMember]
        private string language = "en-GB";

        /// <summary>
        /// Last selected server list API
        /// </summary>
        [DataMember]
        private int lastSelectedServerListAPI;

        /// <summary>
        /// Development directory
        /// </summary>
        [DataMember]
        private string developmentDirectory = "./development";

        /// <summary>
        /// Show chatlog color codes
        /// </summary>
        [DataMember]
        private bool showChatlogColorCodes;

        /// <summary>
        /// Show chatlog colored
        /// </summary>
        [DataMember]
        private bool showChatlogColored;

        /// <summary>
        /// Show chatlog timestamp
        /// </summary>
        [DataMember]
        private bool showChatlogTimestamp;

        /// <summary>
        /// Show username dialog
        /// </summary>
        [DataMember]
        private bool showUsernameDialog;

        /// <summary>
        /// Don't close when launched
        /// </summary>
        [DataMember]
        private bool dontCloseWhenLaunched;

        /// <summary>
        /// Create session logs
        /// </summary>
        [DataMember]
        private bool createSessionsLog;

        /// <summary>
        /// Language
        /// </summary>
        public string Language
        {
            get
            {
                return language;
            }
            set
            {
                if (value != null)
                {
                    language = value;
                }
            }
        }

        /// <summary>
        /// Last selected server list API
        /// </summary>
        public int LastSelectedServerListAPI
        {
            get
            {
                return lastSelectedServerListAPI;
            }
        }

        /// <summary>
        /// Development directory
        /// </summary>
        public string DevelopmentDirectory
        {
            get
            {
                return developmentDirectory;
            }
            set
            {
                if (value != null)
                {
                    developmentDirectory = value;
                }
            }
        }

        /// <summary>
        /// Show chatlog color codes
        /// </summary>
        public bool ShowChatlogColorCodes
        {
            get
            {
                return showChatlogColorCodes;
            }
            set
            {
                showChatlogColorCodes = value;
            }
        }

        /// <summary>
        /// Show chatlog colored
        /// </summary>
        public bool ShowChatlogColored
        {
            get
            {
                return showChatlogColored;
            }
            set
            {
                showChatlogColored = value;
            }
        }

        /// <summary>
        /// Show chatlog timestamp
        /// </summary>
        public bool ShowChatlogTimestamp
        {
            get
            {
                return showChatlogTimestamp;
            }
            set
            {
                showChatlogTimestamp = value;
            }
        }

        /// <summary>
        /// Show username dialog
        /// </summary>
        public bool ShowUsernameDialog
        {
            get
            {
                return showUsernameDialog;
            }
            set
            {
                showUsernameDialog = value;
            }
        }

        /// <summary>
        /// Don't close when launched
        /// </summary>
        public bool DontCloseWhenLaunched
        {
            get
            {
                return dontCloseWhenLaunched;
            }
            set
            {
                dontCloseWhenLaunched = value;
            }
        }

        /// <summary>
        /// Create session logs
        /// </summary>
        public bool CreateSessionsLog
        {
            get
            {
                return createSessionsLog;
            }
            set
            {
                createSessionsLog = value;
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public LauncherConfigDataContract()
        {
            //
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="language">Language</param>
        /// <param name="lastSelectedServerListAPI">Last selected server list API</param>
        /// <param name="developmentDirectory">Development directory</param>
        /// <param name="showChatlogColorCodes">Show chatlog color codes</param>
        /// <param name="showChatlogColored">Show chatlog colored</param>
        /// <param name="showChatlogTimestamp">Show chatlog timestamp</param>
        /// <param name="showUsernameDialog">Show username dialog</param>
        /// <param name="dontCloseWhenLaunched">Don't close when launched</param>
        /// <param name="createSessionsLog">Create sessions log</param>
        public LauncherConfigDataContract(string language, int lastSelectedServerListAPI, string developmentDirectory, bool showChatlogColorCodes, bool showChatlogColored, bool showChatlogTimestamp, bool showUsernameDialog, bool dontCloseWhenLaunched, bool createSessionsLog)
        {
            this.language = language;
            this.lastSelectedServerListAPI = lastSelectedServerListAPI;
            this.developmentDirectory = developmentDirectory;
            this.showChatlogColorCodes = showChatlogColorCodes;
            this.showChatlogColored = showChatlogColored;
            this.showChatlogTimestamp = showChatlogTimestamp;
            this.showUsernameDialog = showUsernameDialog;
            this.dontCloseWhenLaunched = dontCloseWhenLaunched;
            this.createSessionsLog = createSessionsLog;
        }
    }
}
