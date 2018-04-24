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
        public BackendRESTfulServer(BackendRESTfulServerDataContract serverData) : base(serverData.Host, true)
        {
            requestsRequired.Lock(ERequestType.Information);
            hostname = serverData.Hostname;
            gamemode = serverData.Gamemode;
            playerCount = serverData.PlayerCount;
            maxPlayers = serverData.MaxPlayers;
            hasPassword = serverData.HasPassword;
            language = serverData.Language;
            FetchDataAsync(ERequestType.Ping);
        }
    }
}
