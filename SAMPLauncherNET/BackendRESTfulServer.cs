using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMPLauncherNET
{
    public class BackendRESTfulServer : Server
    {

        public BackendRESTfulServer(ServerDataContract serverData) : base(serverData.Host, false)
        {
            requestsRequired[ERequestType.Information] = false;
            FetchDataAsync(ERequestType.Ping);
        }
    }
}
