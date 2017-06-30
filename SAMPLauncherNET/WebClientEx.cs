using System;
using System.Net;

namespace SAMPLauncherNET
{
    public class WebClientEx : WebClient
    {

        private int timeout;

        public WebClientEx(int timeout)
        {
            this.timeout = timeout;
        }

        protected override WebRequest GetWebRequest(Uri uri)
        {
            WebRequest w = base.GetWebRequest(uri);
            w.Timeout = timeout;
            return w;
        }
    }
}
