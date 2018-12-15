/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// SA:MP servers API server class
    /// </summary>
    public class SAMPServersAPIServer : Server
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="serverData">Server data</param>
        public SAMPServersAPIServer(SAMPServersAPIServerDataContract serverData) : base(serverData.Host, false)
        {
            if (serverData.Hostname.Trim().Length > 0)
            {
                hostname = serverData.Hostname;
            }
            gamemode = serverData.Gamemode;
            playerCount = serverData.PlayerCount;
            maxPlayers = serverData.MaxPlayers;
            hasPassword = serverData.HasPassword;
            language = serverData.Language;
            FetchDataAsync(ERequestResponseType.Ping);
            FetchDataAsync(ERequestResponseType.Information);
        }
    }
}
