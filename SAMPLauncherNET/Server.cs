using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Server class
    /// </summary>
    public class Server : IDisposable
    {
        /// <summary>
        /// IPv4 regular expression
        /// </summary>
        private static Regex ipv4regex = new Regex(@"\b((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)(\.|$)){4}\b");

        /// <summary>
        /// Socket
        /// </summary>
        private Socket socket = null;

        /// <summary>
        /// IPv4 address
        /// </summary>
        private uint ipv4AddressUInt = 0U;

        /// <summary>
        /// Port
        /// </summary>
        private ushort port = 0;

        /// <summary>
        /// Is server valid
        /// </summary>
        private bool isValid = false;

        /// <summary>
        /// IP address
        /// </summary>
        private IPAddress ipAddress = null;

        /// <summary>
        /// Timestamp
        /// </summary>
        private DateTime[] timestamp = new DateTime[2];

        /// <summary>
        /// Request required
        /// </summary>
        protected RequestsRequired requestsRequired = new RequestsRequired();

        /// <summary>
        /// Has password
        /// </summary>
        protected bool hasPassword = false;

        /// <summary>
        /// Player count
        /// </summary>
        protected ushort playerCount = 0;

        /// <summary>
        /// Maximal players
        /// </summary>
        protected ushort maxPlayers = 0;

        /// <summary>
        /// Hostname
        /// </summary>
        protected string hostname = "";

        /// <summary>
        /// Gamemode
        /// </summary>
        protected string gamemode = "";

        /// <summary>
        /// Language
        /// </summary>
        protected string language = "";

        /// <summary>
        /// Rules
        /// </summary>
        private Dictionary<string, string> rules = new Dictionary<string, string>();

        /// <summary>
        /// Clients
        /// </summary>
        private Dictionary<string, int> clients = new Dictionary<string, int>();

        /// <summary>
        /// Players
        /// </summary>
        private Dictionary<byte, Player> players = new Dictionary<byte, Player>();

        /// <summary>
        /// Random numbers
        /// </summary>
        private byte[] randomNumbers = new byte[4];

        /// <summary>
        /// Ping
        /// </summary>
        private uint ping = 0U;

        /// <summary>
        /// Threads
        /// </summary>
        private Thread[] threads = new Thread[5];

        /// <summary>
        /// IPv4 address
        /// </summary>
        public uint IPv4AddressInt
        {
            get
            {
                return ipv4AddressUInt;
            }
        }

        /// <summary>
        /// Port
        /// </summary>
        public ushort Port
        {
            get
            {
                return port;
            }
        }

        /// <summary>
        /// Is valid
        /// </summary>
        public bool IsValid
        {
            get
            {
                return isValid;
            }
        }

        /// <summary>
        /// IPv4 address string
        /// </summary>
        public string IPv4AddressString
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 4; i++)
                {
                    if (i > 0)
                        sb.Append(".");
                    sb.Append(((ipv4AddressUInt >> (i * 8)) & 0xFF).ToString());
                }
                return sb.ToString();
            }
        }

        /// <summary>
        /// IP address
        /// </summary>
        public IPAddress IPAddress
        {
            get
            {
                if (ipAddress == null)
                {
                    try
                    {
                        ipAddress = Dns.GetHostAddresses(IPv4AddressString)[0];
                    }
                    catch
                    {
                        //
                    }
                }
                return ipAddress;
            }
        }

        /// <summary>
        /// Has password
        /// </summary>
        public bool HasPassword
        {
            get
            {
                SendQueryWhenRequired(ERequestType.Information);
                return hasPassword;
            }
        }

        /// <summary>
        /// Has password asynchronous
        /// </summary>
        public Task<bool> HasPasswordAsync
        {
            get
            {
                return Task.Factory.StartNew(() => HasPassword);
            }
        }

        /// <summary>
        /// Player count
        /// </summary>
        public ushort PlayerCount
        {
            get
            {
                SendQueryWhenRequired(ERequestType.Information);
                return playerCount;
            }
        }

        /// <summary>
        /// Player count asynchronous
        /// </summary>
        public Task<ushort> PlayerCountAsync
        {
            get
            {
                return Task.Factory.StartNew(() => PlayerCount);
            }
        }

        /// <summary>
        /// Maximal players
        /// </summary>
        public ushort MaxPlayers
        {
            get
            {
                SendQueryWhenRequired(ERequestType.Information);
                return maxPlayers;
            }
        }

        /// <summary>
        /// Maximal players asynchronous
        /// </summary>
        public Task<ushort> MaxPlayersAsync
        {
            get
            {
                return Task.Factory.StartNew(() => MaxPlayers);
            }
        }

        /// <summary>
        /// Hostname
        /// </summary>
        public string Hostname
        {
            get
            {
                SendQueryWhenRequired(ERequestType.Information);
                return hostname;
            }
        }

        /// <summary>
        /// Hostname asynchronous
        /// </summary>
        public Task<string> HostnameAsync
        {
            get
            {
                return Task.Factory.StartNew(() => Hostname);
            }
        }

        /// <summary>
        /// Gamemode
        /// </summary>
        public string Gamemode
        {
            get
            {
                SendQueryWhenRequired(ERequestType.Information);
                return gamemode;
            }
        }

        /// <summary>
        /// Gamemode asynchronous
        /// </summary>
        public Task<string> GamemodeAsync
        {
            get
            {
                return Task.Factory.StartNew(() => Gamemode);
            }
        }

        /// <summary>
        /// Language
        /// </summary>
        public string Language
        {
            get
            {
                SendQueryWhenRequired(ERequestType.Information);
                return language;
            }
        }

        /// <summary>
        /// Geo location
        /// </summary>
        public GeoLocationData GeoLocation
        {
            get
            {
                return GeoLocator.Locate(IPv4AddressString);
            }
        }

        /// <summary>
        /// Language asynchronous
        /// </summary>
        public Task<string> LanguageAsync
        {
            get
            {
                return Task.Factory.StartNew(() => Language);
            }
        }

        /// <summary>
        /// Rule keys
        /// </summary>
        public Dictionary<string, string>.KeyCollection RuleKeys
        {
            get
            {
                SendQueryWhenRequired(ERequestType.Rules);
                return rules.Keys;
            }
        }

        /// <summary>
        /// Rule keys asynchronous
        /// </summary>
        public Task<Dictionary<string, string>.KeyCollection> RuleKeysAsync
        {
            get
            {
                return Task.Factory.StartNew(() => RuleKeys);
            }
        }

        /// <summary>
        /// Client keys
        /// </summary>
        public Dictionary<string, int>.KeyCollection ClientKeys
        {
            get
            {
                SendQueryWhenRequired(ERequestType.Clients);
                return clients.Keys;
            }
        }

        /// <summary>
        /// Client keys asynchronous
        /// </summary>
        public Task<Dictionary<string, int>.KeyCollection> ClientKeysAsync
        {
            get
            {
                return Task.Factory.StartNew(() => ClientKeys);
            }
        }

        /// <summary>
        /// Player keys
        /// </summary>
        public Dictionary<byte, Player>.KeyCollection PlayerKeys
        {
            get
            {
                SendQueryWhenRequired(ERequestType.DetailedClients);
                return players.Keys;
            }
        }

        /// <summary>
        /// Player keys asynchronous
        /// </summary>
        public Task<Dictionary<byte, Player>.KeyCollection> PlayerKeysAsync
        {
            get
            {
                return Task.Factory.StartNew(() => PlayerKeys);
            }
        }

        /// <summary>
        /// Player values
        /// </summary>
        public Dictionary<byte, Player>.ValueCollection PlayerValues
        {
            get
            {
                SendQueryWhenRequired(ERequestType.DetailedClients);
                return players.Values;
            }
        }

        /// <summary>
        /// Player values asynchronous
        /// </summary>
        public Task<Dictionary<byte, Player>.ValueCollection> PlayerValuesAsync
        {
            get
            {
                return Task.Factory.StartNew(() => PlayerValues);
            }
        }

        /// <summary>
        /// Geo location asynchronous
        /// </summary>
        public Task<GeoLocationData> GeoLocationAsync
        {
            get
            {
                return GeoLocator.LocateAsync(IPv4AddressString);
            }
        }

        /// <summary>
        /// Ping
        /// </summary>
        public uint Ping
        {
            get
            {
                SendQueryWhenRequired(ERequestType.Ping);
                return ping;
            }
        }

        /// <summary>
        /// Ping asynchronous
        /// </summary>
        public Task<uint> PingAsync
        {
            get
            {
                return Task.Factory.StartNew(() => Ping);
            }
        }

        /// <summary>
        /// IP and port string
        /// </summary>
        public string IPPortString
        {
            get
            {
                return IPv4AddressString + ":" + port;
            }
        }

        /// <summary>
        /// Favourite data contract
        /// </summary>
        public FavouriteDataContract FavouriteDataContract
        {
            get
            {
                FavouriteDataContract ret = new FavouriteDataContract();
                ret.host = IPPortString;
                ret.hostname = Hostname;
                ret.mode = Gamemode;
                return ret;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="hostAndPort">Host and port</param>
        /// <param name="fetchData">Fetch data</param>
        public Server(string hostAndPort, bool fetchData = true)
        {
            try
            {
                string[] hp = hostAndPort.Trim().Split(new char[] { ':' });
                IPAddress[] ips = null;
                if ((hp.Length == 1) || (hp.Length == 2))
                    ips = Dns.GetHostAddresses(hp[0]);
                if (ips != null)
                {
                    if (ips.Length > 0)
                    {
                        foreach (IPAddress ip in ips)
                        {
                            if (ipv4regex.IsMatch(ip.ToString()))
                            {
                                string[] parts = ip.MapToIPv4().ToString().Trim().Split(new char[] { '.' });
                                uint n;
                                if (parts.Length == 4)
                                {
                                    isValid = true;
                                    for (int i = 0; i < 4; i++)
                                    {
                                        if (uint.TryParse(parts[i], out n))
                                            ipv4AddressUInt |= n << (i * 8);
                                        else
                                        {
                                            isValid = false;
                                            break;
                                        }
                                    }
                                    if (isValid)
                                    {
                                        bool success = true;
                                        if (hp.Length == 1)
                                            port = 7777;
                                        else
                                            success = ushort.TryParse(hp[1], out port);
                                        if (success)
                                        {
                                            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                                            socket.SendTimeout = 1000;
                                            socket.ReceiveTimeout = 1000;
                                            if (fetchData)
                                            {
                                                FetchDataAsync(ERequestType.Ping);
                                                FetchDataAsync(ERequestType.Information);
                                            }
                                        }
                                        else
                                        {
                                            ipv4AddressUInt = 0U;
                                            isValid = false;
                                        }
                                    }
                                }
                                break;
                            }
                        }
                    }
                }
            }
            catch
            {
                //
            }
        }

        /// <summary>
        /// Is data fetched
        /// </summary>
        /// <param name="requestType">Request type</param>
        /// <returns>Data fetched</returns>
        public bool IsDataFetched(ERequestType requestType)
        {
            return !(requestsRequired[requestType]);
        }

        /// <summary>
        /// Fetch any data
        /// </summary>
        public void FetchAnyData()
        {
            FetchAnyDataAsync();
            JoinAllThreads();
        }

        /// <summary>
        /// Fetch any data asynchronous
        /// </summary>
        public void FetchAnyDataAsync()
        {
            AbortAllThreads();
            ForceRequest();
            threads = new Thread[5];
            lock (threads)
            {
                threads[0] = new Thread(() => SendQuery(ERequestType.Ping));
                threads[1] = new Thread(() => SendQuery(ERequestType.Information));
                threads[2] = new Thread(() => SendQuery(ERequestType.Rules));
                threads[3] = new Thread(() => SendQuery(ERequestType.Clients));
                threads[4] = new Thread(() => SendQuery(ERequestType.DetailedClients));
                StartAllThreads();
            }
        }

        /// <summary>
        /// Fetch multiple data
        /// </summary>
        /// <param name="requestTypes">Request types</param>
        public void FetchMultiData(ERequestType[] requestTypes)
        {
            Dictionary<ERequestType, Thread> ts = new Dictionary<ERequestType, Thread>();
            foreach (ERequestType rt in requestTypes)
            {
                if (!(ts.ContainsKey(rt)))
                {
                    AbortThread(rt);
                    requestsRequired[rt] = true;
                    Thread t = new Thread(() => SendQuery(rt));
                    threads[(int)rt] = t;
                    ts.Add(rt, t);
                    try
                    {
                        t.Start();
                    }
                    catch
                    {
                        //
                    }
                }
            }
            foreach (Thread t in ts.Values)
            {
                t.Join();
            }
        }

        /// <summary>
        /// Fetch data
        /// </summary>
        /// <param name="requestType">Request type</param>
        public void FetchData(ERequestType requestType)
        {
            AbortThread(requestType);
            requestsRequired[requestType] = true;
            SendQuery(requestType);
        }

        /// <summary>
        /// Fetch data asynchronous
        /// </summary>
        /// <param name="requestType">Request type</param>
        public void FetchDataAsync(ERequestType requestType)
        {
            AbortThread(requestType);
            requestsRequired[requestType] = true;
            SendQueryAsync(requestType);
        }

        /// <summary>
        /// Abort thread
        /// </summary>
        /// <param name="requestType"></param>
        private void AbortThread(ERequestType requestType)
        {
            lock (threads)
            {
                int index = (int)requestType;
                if (threads[index] != null)
                {
                    threads[index].Abort();
                    threads[index] = null;
                }
            }
        }

        /// <summary>
        /// Abort all threads
        /// </summary>
        private void AbortAllThreads()
        {
            if (threads != null)
            {
                lock (threads)
                {
                    for (int i = 0; i < threads.Length; i++)
                    {
                        if (threads[i] != null)
                        {
                            threads[i].Abort();
                            threads[i] = null;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Start all threads
        /// </summary>
        private void StartAllThreads()
        {
            foreach (Thread t in threads)
            {
                if (t != null)
                {
                    try
                    {
                        t.Start();
                    }
                    catch
                    {
                        //
                    }
                }
            }
        }

        /// <summary>
        /// Join all threads
        /// </summary>
        private void JoinAllThreads()
        {
            foreach (Thread t in threads)
            {
                if (t != null)
                {
                    try
                    {
                        t.Join();
                    }
                    catch
                    {
                        //
                    }
                }
            }
        }

        /// <summary>
        /// Send query asynchronous
        /// </summary>
        /// <param name="requestType">Request type</param>
        private void SendQueryAsync(ERequestType requestType)
        {
            int index = (int)requestType;
            threads[index] = new Thread(() => SendQuery(requestType));
            requestsRequired.SetLastRequestTime(requestType);
            threads[index].Start();
        }

        /// <summary>
        /// Send query when required
        /// </summary>
        /// <param name="requestType">Request type</param>
        /// <returns>Success</returns>
        private bool SendQueryWhenRequired(ERequestType requestType)
        {
            bool ret = true;
            if (requestsRequired[requestType])
                ret = SendQuery(requestType);
            return ret;
        }

        /// <summary>
        /// Send query when expired
        /// </summary>
        /// <param name="requestType">Request type</param>
        /// <param name="milliseconds">Milliseconds</param>
        public void SendQueryWhenExpired(ERequestType requestType, uint milliseconds)
        {
            uint t = (uint)(DateTime.Now.Subtract(requestsRequired.GetLastRequestTime(requestType)).TotalMilliseconds);
            if (t >= milliseconds)
                SendQueryAsync(requestType);
        }

        /// <summary>
        /// Send query
        /// </summary>
        /// <param name="requestType">Request type</param>
        /// <returns>Success</returns>
        private bool SendQuery(ERequestType requestType)
        {
            bool ret = false;
            requestsRequired.SetLastRequestTime(requestType);
            try
            {
                EndPoint endpoint = new IPEndPoint(IPAddress, Port);
                using (MemoryStream stream = new MemoryStream())
                {
                    using (BinaryWriter writer = new BinaryWriter(stream))
                    {
                        char op_code = RequestsRequired.GetOpCode(requestType);
                        writer.Write("SAMP".ToCharArray());
                        writer.Write(ipv4AddressUInt);
                        writer.Write(port);
                        writer.Write(op_code);
                        if (op_code == 'p')
                        {
                            Random r = new Random();
                            r.NextBytes(randomNumbers);
                            writer.Write(randomNumbers);
                        }
                        timestamp[0] = DateTime.Now;
                    }
                    if (socket.SendTo(stream.ToArray(), endpoint) > 0)
                    {
                        ret = true;
                        Receive();
                    }
                }
            }
            catch
            {
                //
            }
            return ret;
        }

        /// <summary>
        /// Recieve
        /// </summary>
        private void Receive()
        {
            try
            {
                EndPoint endpoint = new IPEndPoint(IPAddress, port);
                byte[] rBuffer = new byte[3402];
                socket.ReceiveFrom(rBuffer, ref endpoint);
                timestamp[1] = DateTime.Now;
                using (MemoryStream stream = new MemoryStream(rBuffer))
                {
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        if (stream.Length > 10)
                        {
                            string samp = new string(reader.ReadChars(4));
                            if (samp == "SAMP")
                            {
                                if (ipv4AddressUInt == reader.ReadUInt32())
                                {
                                    if (port == reader.ReadUInt16())
                                    {
                                        switch (reader.ReadChar())
                                        {
                                            // Ping
                                            case 'p':
                                                if (Utils.AreEqual(randomNumbers, reader.ReadBytes(4)))
                                                {
                                                    ping = (uint)(timestamp[1].Subtract(timestamp[0]).TotalMilliseconds);
                                                    requestsRequired[ERequestType.Ping] = false;
                                                }
                                                break;

                                            // Information
                                            case 'i':
                                                hasPassword = (reader.ReadByte() != 0);
                                                playerCount = reader.ReadUInt16();
                                                maxPlayers = reader.ReadUInt16();
                                                hostname = Encoding.Default.GetString(reader.ReadBytes(reader.ReadInt32()));
                                                gamemode = Encoding.Default.GetString(reader.ReadBytes(reader.ReadInt32()));
                                                language = Encoding.Default.GetString(reader.ReadBytes(reader.ReadInt32()));
                                                requestsRequired[ERequestType.Information] = false;
                                                break;

                                            // Rules
                                            case 'r':
                                                {
                                                    int rc = reader.ReadInt16();
                                                    string k;
                                                    rules.Clear();
                                                    try
                                                    {
                                                        for (int i = 0; i < rc; i++)
                                                        {
                                                            k = Encoding.Default.GetString(reader.ReadBytes(reader.ReadByte()));
                                                            rules.Add(k, Encoding.Default.GetString(reader.ReadBytes(reader.ReadByte())));
                                                        }
                                                    }
                                                    catch
                                                    {
                                                        //
                                                    }
                                                    requestsRequired[ERequestType.Rules] = false;
                                                }
                                                break;

                                            // Client list
                                            case 'c':
                                                {
                                                    int pc = reader.ReadInt16();
                                                    string k;
                                                    clients.Clear();
                                                    try
                                                    {
                                                        for (int i = 0; i < pc; i++)
                                                        {
                                                            // Name and score
                                                            k = Encoding.Default.GetString(reader.ReadBytes(reader.ReadByte()));
                                                            clients.Add(k, reader.ReadInt32());
                                                        }
                                                    }
                                                    catch
                                                    {
                                                        //
                                                    }
                                                    requestsRequired[ERequestType.Clients] = false;
                                                }
                                                break;

                                            // Detailed player information
                                            case 'd':
                                                {
                                                    byte id;
                                                    string pn;
                                                    int s;
                                                    uint p;
                                                    playerCount = reader.ReadUInt16();
                                                    players.Clear();
                                                    try
                                                    {
                                                        for (ushort i = 0; i != playerCount; i++)
                                                        {
                                                            id = reader.ReadByte();
                                                            pn = Encoding.Default.GetString(reader.ReadBytes(reader.ReadByte()));
                                                            s = reader.ReadInt32();
                                                            p = reader.ReadUInt32();
                                                            players.Add(id, new Player(id, pn, s, p));
                                                        }
                                                    }
                                                    catch
                                                    {
                                                        //
                                                    }
                                                    requestsRequired[ERequestType.DetailedClients] = false;
                                                }
                                                break;
                                        }
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
        }

        /// <summary>
        /// Force request
        /// </summary>
        public void ForceRequest()
        {
            requestsRequired[ERequestType.Ping] = true;
            requestsRequired[ERequestType.Information] = true;
            requestsRequired[ERequestType.Rules] = true;
            requestsRequired[ERequestType.Clients] = true;
            requestsRequired[ERequestType.DetailedClients] = true;
        }

        /// <summary>
        /// Get rule value
        /// </summary>
        /// <param name="ruleName">Rule name</param>
        /// <returns>Rule value</returns>
        public string GetRuleValue(string ruleName)
        {
            string ret = "";
            SendQueryWhenRequired(ERequestType.Rules);
            if (rules.ContainsKey(ruleName))
                ret = rules[ruleName];
            return ret;
        }

        /// <summary>
        /// Get score from client
        /// </summary>
        /// <param name="clientName">Client name</param>
        /// <returns></returns>
        public int GetScoreFromClient(string clientName)
        {
            int ret = 0;
            SendQueryWhenRequired(ERequestType.Clients);
            if (clients.ContainsKey(clientName))
                ret = clients[clientName];
            return ret;
        }

        /// <summary>
        /// Get player
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Player</returns>
        public Player GetPlayer(byte id)
        {
            Player ret = null;
            SendQueryWhenRequired(ERequestType.DetailedClients);
            if (players.ContainsKey(id))
                ret = players[id];
            return ret;
        }

        /// <summary>
        /// To favourites server
        /// </summary>
        /// <param name="cachedName">Cached name</param>
        /// <param name="cachedGamemode">Cahced gamemode</param>
        /// <param name="serverPassword">Server password</param>
        /// <param name="rconPassword">RCON password</param>
        /// <returns></returns>
        public FavouriteServer ToFavouriteServer(string cachedName = "", string cachedGamemode = "", string serverPassword = "", string rconPassword = "")
        {
            return new FavouriteServer(IPPortString, cachedName, cachedGamemode, serverPassword, rconPassword);
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            AbortAllThreads();
            if (socket != null)
            {
                socket.Dispose();
                socket = null;
            }
        }
    }
}
