/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Backend restful API server class
    /// </summary>
    public class BackendRESTfulServer : Server
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="serverData">Server data</param>
        public BackendRESTfulServer(ServerDataContract serverData) : base(serverData.host, false)
        {
            requestsRequired.Lock(ERequestType.Information);
            hostname = serverData.hostname;
            gamemode = serverData.gamemode;
            playerCount = serverData.playerCount;
            maxPlayers = serverData.maxPlayers;
            hasPassword = serverData.hasPassword;
            language = serverData.language;
            FetchDataAsync(ERequestType.Ping);
        }
    }
}
