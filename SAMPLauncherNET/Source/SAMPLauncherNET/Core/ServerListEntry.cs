using System;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Server list entry
    /// </summary>
    public class ServerListEntry : IComparable, IComparable<ServerListEntry>, IDisposable
    {
        /// <summary>
        /// Server
        /// </summary>
        private readonly Server server;

        /// <summary>
        /// Server list index
        /// </summary>
        private readonly int serverListIndex;

        /// <summary>
        /// Server
        /// </summary>
        public Server Server { get => server; }

        /// <summary>
        /// Server list index
        /// </summary>
        public int ServerListIndex { get => serverListIndex; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="server">Server</param>
        /// <param name="serverListIndex">Server list index</param>
        public ServerListEntry(Server server, int serverListIndex)
        {
            this.server = server;
            this.serverListIndex = serverListIndex;
        }

        /// <summary>
        /// Compare to
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>Comparison result</returns>
        public int CompareTo(object obj)
        {
            return ((obj is ServerListEntry) ? CompareTo((ServerListEntry)obj) : -1);
        }

        /// <summary>
        /// Compare to
        /// </summary>
        /// <param name="other">Other</param>
        /// <returns>Comparison result</returns>
        public int CompareTo(ServerListEntry other)
        {
            int ret = -1;
            if ((other != null) && (server != null))
            {
                if (other.server != null)
                {
                    ret = server.CompareTo(other.server);
                    if (ret == 0)
                    {
                        ret = serverListIndex.CompareTo(other.serverListIndex);
                    }
                }
            }
            return ret;
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            if (server != null)
            {
                server.Dispose();
            }
        }
    }
}
