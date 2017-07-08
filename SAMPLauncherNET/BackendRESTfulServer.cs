namespace SAMPLauncherNET
{
    public class BackendRESTfulServer : Server
    {

        public BackendRESTfulServer(ServerDataContract serverData) : base(serverData.host, false)
        {
            requestsRequired[ERequestType.Information] = false;
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
