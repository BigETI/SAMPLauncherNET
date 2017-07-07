namespace SAMPLauncherNET
{
    public class BackendRESTfulServer : Server
    {

        public BackendRESTfulServer(ServerDataContract serverData) : base(serverData.host, false)
        {
            requestsRequired[ERequestType.Information] = false;
            FetchDataAsync(ERequestType.Ping);
        }
    }
}
