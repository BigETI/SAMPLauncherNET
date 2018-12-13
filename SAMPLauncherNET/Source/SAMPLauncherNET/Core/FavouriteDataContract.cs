using System.Runtime.Serialization;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Favourite data contract class
    /// </summary>
    [DataContract]
    public class FavouriteDataContract
    {
        /// <summary>
        /// Host
        /// </summary>
        [DataMember]
        private string host;

        /// <summary>
        /// Hostname
        /// </summary>
        [DataMember]
        private string hostname;

        /// <summary>
        /// Mode
        /// </summary>
        [DataMember]
        private string mode;

        /// <summary>
        /// Host
        /// </summary>
        public string Host
        {
            get
            {
                if (host == null)
                {
                    host = "";
                }
                return host;
            }
        }

        /// <summary>
        /// Hostname
        /// </summary>
        public string Hostname
        {
            get
            {
                if (hostname == null)
                {
                    hostname = "";
                }
                return hostname;
            }
        }

        /// <summary>
        /// Mode
        /// </summary>
        public string Mode
        {
            get
            {
                if (mode == null)
                {
                    mode = "";
                }
                return mode;
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public FavouriteDataContract()
        {
            //
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="host">Host</param>
        /// <param name="hostname">Hostname</param>
        /// <param name="mode">Mode</param>
        public FavouriteDataContract(string host, string hostname, string mode)
        {
            this.host = host;
            this.hostname = hostname;
            this.mode = mode;
        }
    }
}
