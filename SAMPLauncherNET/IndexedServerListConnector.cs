/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Indexed server list connector
    /// </summary>
    public class IndexedServerListConnector
    {
        /// <summary>
        /// Server list connector
        /// </summary>
        private ServerListConnector serverListConnector;

        /// <summary>
        /// Index
        /// </summary>
        private int index;

        /// <summary>
        /// Server list connector
        /// </summary>
        public ServerListConnector ServerListConnector
        {
            get
            {
                return serverListConnector;
            }
        }

        /// <summary>
        /// Index
        /// </summary>
        public int Index
        {
            get
            {
                return index;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="serverListConnector">Server list connector</param>
        /// <param name="index">Index</param>
        public IndexedServerListConnector(ServerListConnector serverListConnector, int index)
        {
            this.serverListConnector = serverListConnector;
            this.index = index;
        }

        /// <summary>
        /// To string
        /// </summary>
        /// <returns>String representation</returns>
        public override string ToString()
        {
            return serverListConnector.ToString();
        }
    }
}
