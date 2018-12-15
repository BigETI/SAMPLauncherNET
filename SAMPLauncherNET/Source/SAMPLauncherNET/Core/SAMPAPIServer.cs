/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Backend restful API server class
    /// </summary>
    public class SAMPAPIServer : Server
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="serverData">Server data</param>
        public SAMPAPIServer(SAMPAPIServerDataContract serverData) : base(serverData.Host, false)
        {
            requestsRequired.Lock(ERequestResponseType.Information);
            if (serverData.Hostname.Trim().Length > 0)
            {
                hostname = serverData.Hostname;
            }
            gamemode = serverData.Gamemode;
            playerCount = serverData.PlayerCount;
            maxPlayers = serverData.MaxPlayers;
            hasPassword = serverData.HasPassword;
            language = serverData.Language;
            //FetchDataAsync(ERequestType.Ping);
        }
    }
}
