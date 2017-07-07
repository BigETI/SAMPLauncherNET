using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

namespace SAMPLauncherNET
{
    public class ServerListConnector
    {

        private static DataContractJsonSerializer serverListJSONSerializer = new DataContractJsonSerializer(typeof(ServerDataContract[]));

        private static DataContractJsonSerializer favouriteListJSONSerializer = new DataContractJsonSerializer(typeof(FavouriteDataContract[]));

        public const string APIHTTPContentType = "text/html";

        public const string APIHTTPAccept = "text/html, */*";

        public const string APIHTTPUserAgent = "Mozilla/3.0 (compatible; SA:MP v0.3.7)";

        private string name = "";

        private EServerListType serverListType;

        private string endpoint;

        private uint maxServers = 0U;

        private uint serverCount = 0U;

        private bool notLoaded = true;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public EServerListType ServerListType
        {
            get
            {
                return serverListType;
            }
        }

        public string Endpoint
        {
            get
            {
                return endpoint;
            }
        }

        public uint MaxServers
        {
            get
            {
                return maxServers;
            }
        }

        public uint ServerCount
        {
            get
            {
                return serverCount;
            }
            set
            {
                serverCount = value;
            }
        }

        public bool NotLoaded
        {
            get
            {
                return notLoaded;
            }
            set
            {
                if (notLoaded)
                    serverCount = 0;
                notLoaded = value;
            }
        }

        public Dictionary<string, Server> ServerListIO
        {
            get
            {
                Dictionary<string, Server> ret = new Dictionary<string, Server>();
                switch (serverListType)
                {
                    case EServerListType.Favourites:
                        try
                        {
                            using (FileStream stream = File.Open(endpoint, FileMode.Open))
                            {
                                FavouriteDataContract[] favourites = (FavouriteDataContract[])(favouriteListJSONSerializer.ReadObject(stream));
                                foreach (FavouriteDataContract fdc in favourites)
                                    ret.Add(fdc.host, new FavouriteServer(fdc));
                            }
                        }
                        catch
                        {
                            //
                        }
                        break;
                    case EServerListType.BackendRESTful:
                        try
                        {
                            using (WebClientEx wc = new WebClientEx(5000))
                            {
                                wc.Headers.Set(HttpRequestHeader.ContentType, APIHTTPContentType);
                                wc.Headers.Set(HttpRequestHeader.Accept, APIHTTPAccept);
                                wc.Headers.Set(HttpRequestHeader.UserAgent, APIHTTPUserAgent);
                                using (MemoryStream stream = new MemoryStream(wc.DownloadData(endpoint)))
                                {
                                    ServerDataContract data = serverListJSONSerializer.ReadObject(stream) as ServerDataContract;
                                    if (data != null)
                                    {
                                        BackendRESTfulServer server = new BackendRESTfulServer(data);
                                        if (server.IsValid)
                                            ret.Add(server.IPPortString, server);
                                    }
                                }
                            }
                        }
                        catch
                        {
                            //
                        }
                        break;
                    case EServerListType.LegacyFavourites:
                        try
                        {
                            using (FileStream stream = File.Open(endpoint, FileMode.Open))
                            {
                                using (BinaryReader reader = new BinaryReader(stream))
                                {
                                    if (stream.Length >= 16)
                                    {
                                        string samp = new string(reader.ReadChars(4));
                                        if (samp == "SAMP")
                                        {
                                            if (reader.ReadUInt32() == 1U)
                                            {
                                                int sc = reader.ReadInt32();
                                                for (int i = 0; i < sc; i++)
                                                {
                                                    string ip = Encoding.Default.GetString(reader.ReadBytes(reader.ReadInt32()));
                                                    ushort port = (ushort)(reader.ReadUInt32());
                                                    string cn = Encoding.Default.GetString(reader.ReadBytes(reader.ReadInt32()));
                                                    string sp = Encoding.Default.GetString(reader.ReadBytes(reader.ReadInt32()));
                                                    string rp = Encoding.Default.GetString(reader.ReadBytes(reader.ReadInt32()));
                                                    ip = ip + ":" + port;
                                                    FavouriteServer s = new FavouriteServer(ip, cn, "", sp, rp);
                                                    if (s.IsValid)
                                                        ret.Add(s.IPPortString, s);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        catch
                        {
                            //
                        }
                        break;
                    case EServerListType.LegacySAMP:
                        try
                        {
                            using (WebClientEx wc = new WebClientEx(5000))
                            {
                                wc.Headers.Set(HttpRequestHeader.ContentType, APIHTTPContentType);
                                wc.Headers.Set(HttpRequestHeader.Accept, APIHTTPAccept);
                                wc.Headers.Set(HttpRequestHeader.UserAgent, APIHTTPUserAgent);
                                string[] ips = wc.DownloadString(endpoint).Split(new char[] { '\n' });
                                foreach (string ip in ips)
                                {
                                    Server server = new Server(ip);
                                    if (server.IsValid)
                                        ret.Add(ip.Trim(), server);
                                }
                            }
                        }
                        catch
                        {
                            //
                        }
                        break;
                }
                maxServers = (uint)(ret.Count);
                return ret;
            }
            set
            {
                if (value != null)
                {
                    switch (serverListType)
                    {
                        case EServerListType.Favourites:
                            try
                            {
                                using (FileStream stream = File.Open(endpoint, FileMode.Create))
                                {
                                    List<FavouriteDataContract> api = new List<FavouriteDataContract>();
                                    foreach (Server server in value.Values)
                                        api.Add(server.FavouriteDataContract);
                                    favouriteListJSONSerializer.WriteObject(stream, api.ToArray());
                                }
                            }
                            catch
                            {
                                //
                            }
                            maxServers = (uint)(value.Count);
                            break;

                        case EServerListType.LegacyFavourites:
                            try
                            {
                                using (FileStream fs = File.Open(endpoint, FileMode.Create))
                                {
                                    using (BinaryWriter writer = new BinaryWriter(fs))
                                    {
                                        writer.Write("SAMP".ToCharArray());
                                        writer.Write(1);
                                        writer.Write(value.Count);
                                        foreach (KeyValuePair<string, Server> kv in value)
                                        {
                                            byte[] data = Encoding.Default.GetBytes(kv.Value.IPv4AddressString);
                                            writer.Write(data.Length);
                                            writer.Write(data);
                                            writer.Write((uint)(kv.Value.Port));
                                            data = Encoding.Default.GetBytes(kv.Value.Hostname);
                                            writer.Write(data.Length);
                                            writer.Write(data);
                                            if (kv.Value is FavouriteServer)
                                                data = Encoding.Default.GetBytes(((FavouriteServer)(kv.Value)).ServerPassword);
                                            else
                                                data = new byte[0];
                                            writer.Write(data.Length);
                                            writer.Write(data);
                                            if (kv.Value is FavouriteServer)
                                                data = Encoding.Default.GetBytes(((FavouriteServer)(kv.Value)).RCONPassword);
                                            else
                                                data = new byte[0];
                                            writer.Write(data.Length);
                                            writer.Write(data);
                                        }
                                    }
                                }
                            }
                            catch
                            {
                                //
                            }
                            maxServers = (uint)(value.Count);
                            break;
                    }
                }
            }
        }

        public APIDataContract APIDataContract
        {
            get
            {
                APIDataContract ret = new APIDataContract();
                ret.name = name;
                ret.type = serverListType.ToString();
                ret.endpoint = endpoint;
                return ret;
            }
        }

        public ServerListConnector(APIDataContract apidc)
        {
            name = apidc.name;
            if (!(Enum.TryParse(apidc.type, out serverListType)))
                serverListType = EServerListType.Error;
            endpoint = apidc.endpoint;
        }

        public ServerListConnector(string name, EServerListType serverListType, string endpoint)
        {
            this.name = name;
            this.serverListType = serverListType;
            this.endpoint = endpoint;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
