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
        /// Last selected server list API
        /// </summary>
        [DataMember]
        private int lastSelectedServerListAPI = 0;

        /// <summary>
        /// Development directory
        /// </summary>
        [DataMember]
        private string developmentDirectory = "./development";

        /// <summary>
        /// Use Discord Rich Presence
        /// </summary>
        [DataMember]
        private bool useDiscordRichPresence = true;

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
        /// Use Discord Rich Presence
        /// </summary>
        public bool UseDiscordRichPresence
        {
            get
            {
                return useDiscordRichPresence;
            }
            set
            {
                useDiscordRichPresence = value;
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
        /// <param name="lastSelectedServerListAPI">Last selected server list API</param>
        /// <param name="developmentDirectory">Development directory</param>
        /// <param name="useDiscordRichPresence">Use discord rich presence</param>
        public LauncherConfigDataContract(int lastSelectedServerListAPI, string developmentDirectory, bool useDiscordRichPresence)
        {
            this.lastSelectedServerListAPI = lastSelectedServerListAPI;
            this.developmentDirectory = developmentDirectory;
            this.useDiscordRichPresence = useDiscordRichPresence;
        }

        /// <summary>
        /// On deserialized event
        /// </summary>
        /// <param name="context">Context</param>
        [OnDeserialized]
        void OnDeserialized(StreamingContext context)
        {
            useDiscordRichPresence = true;
        }
    }
}
