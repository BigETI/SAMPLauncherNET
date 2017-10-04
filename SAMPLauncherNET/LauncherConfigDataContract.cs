using System.IO;
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
                    developmentDirectory = value;
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
        public LauncherConfigDataContract(int lastSelectedServerListAPI, string developmentDirectory)
        {
            this.lastSelectedServerListAPI = lastSelectedServerListAPI;
            this.developmentDirectory = developmentDirectory;
        }
    }
}
