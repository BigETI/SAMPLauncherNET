using CSLPI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

/// <summary>
/// Community San Andreas Multiplayer Launcher programming interface namespace
/// </summary>
namespace CSL
{
    /// <summary>
    /// San Andreas Multiplayer server class
    /// </summary>
    public class SAMPServer : ISAMPServer
    {
        /// <summary>
        /// IPv4 regular expression
        /// </summary>
        private static readonly Regex ipv4RegEx = new Regex(@"\b((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)(\.|$)){4}\b");

        /// <summary>
        /// Socket
        /// </summary>
        private Socket socket;

        /// <summary>
        /// IP address
        /// </summary>
        private IPAddress ipAddress;

        /// <summary>
        /// Timestamp
        /// </summary>
        private readonly DateTime[] timestamp = new DateTime[2];

        /// <summary>
        /// Request required
        /// </summary>
        protected RequestsRequired requestsRequired = new RequestsRequired(true);

        /// <summary>
        /// Has password
        /// </summary>
        protected bool hasPassword;

        /// <summary>
        /// Player count
        /// </summary>
        protected ushort playerCount;

        /// <summary>
        /// Maximal players
        /// </summary>
        protected ushort maxPlayers;

        /// <summary>
        /// Hostname
        /// </summary>
        protected string hostname;

        /// <summary>
        /// Gamemode
        /// </summary>
        protected string gamemode;

        /// <summary>
        /// Language
        /// </summary>
        protected string language;

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
        private Dictionary<byte, SAMPServerPlayer> players = new Dictionary<byte, SAMPServerPlayer>();

        /// <summary>
        /// Random numbers
        /// </summary>
        private readonly byte[] randomNumbers = new byte[4];

        /// <summary>
        /// Threads
        /// </summary>
        private Thread[] threads = new Thread[5];

        /// <summary>
        /// On San Andreas Multiplayer server response
        /// </summary>
        public event SAMPServerResponseDelegate OnResponse;

        /// <summary>
        /// IPv4 address
        /// </summary>
        public uint IPv4AddressUInt { get; private set; }

        /// <summary>
        /// Port
        /// </summary>
        public ushort Port { get; private set; }

        /// <summary>
        /// Is server valid
        /// </summary>
        public bool IsValid { get; private set; }

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
                    {
                        sb.Append(".");
                    }
                    sb.Append(((IPv4AddressUInt >> (i * 8)) & 0xFF).ToString());
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
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
                    }
                }
                return ipAddress;
            }
        }

        /// <summary>
        /// Has password
        /// </summary>
        public bool HasPassword { get; protected set; }

        /// <summary>
        /// Player count
        /// </summary>
        public ushort PlayerCount { get; protected set; }

        /// <summary>
        /// Maximal players
        /// </summary>
        public ushort MaxPlayers { get; protected set; }

        /// <summary>
        /// Hostname
        /// </summary>
        public string Hostname
        {
            get
            {
                return ((hostname == null) ? (IPPortString + " ...") : hostname);
            }
        }

        /// <summary>
        /// Gamemode
        /// </summary>
        public string Gamemode
        {
            get
            {
                if (gamemode == null)
                {
                    gamemode = "";
                }
                return gamemode;
            }
        }

        /// <summary>
        /// Language
        /// </summary>
        public string Language
        {
            get
            {
                if (language == null)
                {
                    language = "";
                }
                return language;
            }
        }

        /// <summary>
        /// Geo location
        /// </summary>
        public IGeoLocation GeoLocation
        {
            get
            {
                return GeoLocator.Locate(IPv4AddressString);
            }
        }

        /// <summary>
        /// Rule keys
        /// </summary>
        public string[] RuleKeys
        {
            get
            {
                string[] ret = new string[rules.Keys.Count];
                rules.Keys.CopyTo(ret, 0);
                return ret;
            }
        }

        /// <summary>
        /// Client keys
        /// </summary>
        public string[] ClientKeys
        {
            get
            {
                string[] ret = new string[clients.Keys.Count];
                clients.Keys.CopyTo(ret, 0);
                return ret;
            }
        }

        /// <summary>
        /// Player keys
        /// </summary>
        public byte[] PlayerKeys
        {
            get
            {
                byte[] ret = new byte[players.Keys.Count];
                players.Keys.CopyTo(ret, 0);
                return ret;
            }
        }

        /// <summary>
        /// Player values
        /// </summary>
        public ISAMPServerPlayer[] PlayerValues
        {
            get
            {
                SAMPServerPlayer[] ret = new SAMPServerPlayer[players.Values.Count];
                players.Values.CopyTo(ret, 0);
                return ret;
            }
        }

        /// <summary>
        /// Ping
        /// </summary>
        public uint Ping { get; private set; } = uint.MaxValue;

        /// <summary>
        /// IP and port string
        /// </summary>
        public string IPPortString
        {
            get
            {
                return IPv4AddressString + ":" + Port;
            }
        }

        /// <summary>
        /// Favourite data contract
        /// </summary>
        public FavouriteDataContract FavouriteDataContract
        {
            get
            {
                return new FavouriteDataContract(IPPortString, Hostname, Gamemode);
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="hostAndPort">Host and port</param>
        /// <param name="fetchData">Fetch data</param>
        public SAMPServer(string hostAndPort, bool fetchData)
        {
            try
            {
                string[] hp = hostAndPort.Trim().Split(new[] { ':' });
                IPAddress[] ips = null;
                if ((hp.Length == 1) || (hp.Length == 2))
                {
                    ips = Dns.GetHostAddresses(hp[0]);
                }
                if (ips != null)
                {
                    if (ips.Length > 0)
                    {
                        foreach (IPAddress ip in ips)
                        {
                            if (ipv4RegEx.IsMatch(ip.ToString()))
                            {
                                string[] parts = ip.MapToIPv4().ToString().Trim().Split(new[] { '.' });
                                uint n;
                                if (parts.Length == 4)
                                {
                                    IsValid = true;
                                    for (int i = 0; i < 4; i++)
                                    {
                                        if (uint.TryParse(parts[i], out n))
                                        {
                                            IPv4AddressUInt |= n << (i * 8);
                                        }
                                        else
                                        {
                                            IsValid = false;
                                            break;
                                        }
                                    }
                                    if (IsValid)
                                    {
                                        bool success = true;
                                        if (hp.Length == 1)
                                        {
                                            Port = 7777;
                                        }
                                        else
                                        {
                                            ushort port;
                                            success = ushort.TryParse(hp[1], out port);
                                            Port = port;
                                        }
                                        if (success)
                                        {
                                            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                                            socket.SendTimeout = 1000;
                                            socket.ReceiveTimeout = 1000;
                                            if (fetchData)
                                            {
                                                FetchDataAsync(ERequestResponseType.Ping);
                                                FetchDataAsync(ERequestResponseType.Information);
                                            }
                                        }
                                        else
                                        {
                                            IPv4AddressUInt = 0U;
                                            IsValid = false;
                                        }
                                    }
                                }
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
            }
        }

        /// <summary>
        /// Is data fetched
        /// </summary>
        /// <param name="requestType">Request type</param>
        /// <returns>Data fetched</returns>
        public bool IsDataFetched(ERequestResponseType requestType)
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
                threads[0] = new Thread(() => SendQuery(ERequestResponseType.Ping));
                threads[1] = new Thread(() => SendQuery(ERequestResponseType.Information));
                threads[2] = new Thread(() => SendQuery(ERequestResponseType.Rules));
                threads[3] = new Thread(() => SendQuery(ERequestResponseType.Clients));
                threads[4] = new Thread(() => SendQuery(ERequestResponseType.DetailedClients));
                StartAllThreads();
            }
        }

        /// <summary>
        /// Fetch multiple data
        /// </summary>
        /// <param name="requestTypes">Request types</param>
        public void FetchMultiData(ERequestResponseType[] requestTypes)
        {
            Dictionary<ERequestResponseType, Thread> ts = new Dictionary<ERequestResponseType, Thread>();
            foreach (ERequestResponseType rt in requestTypes)
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
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
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
        public void FetchData(ERequestResponseType requestType)
        {
            AbortThread(requestType);
            requestsRequired[requestType] = true;
            SendQuery(requestType);
        }

        /// <summary>
        /// Fetch data asynchronous
        /// </summary>
        /// <param name="requestType">Request type</param>
        public void FetchDataAsync(ERequestResponseType requestType)
        {
            AbortThread(requestType);
            requestsRequired[requestType] = true;
            SendQueryAsync(requestType);
        }

        /// <summary>
        /// Abort thread
        /// </summary>
        /// <param name="requestType"></param>
        private void AbortThread(ERequestResponseType requestType)
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
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
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
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
                    }
                }
            }
        }

        /// <summary>
        /// Send query asynchronous
        /// </summary>
        /// <param name="requestType">Request type</param>
        private void SendQueryAsync(ERequestResponseType requestType)
        {
            int index = (int)requestType;
            threads[index] = new Thread(() => SendQuery(requestType));
            requestsRequired.SetLastRequestTime(requestType);
            threads[index].Start();
        }

        /// <summary>
        /// Send query when expired
        /// </summary>
        /// <param name="requestType">Request type</param>
        /// <param name="milliseconds">Milliseconds</param>
        /// <returns>"true" if attempted sending query, othewrwise "false"</returns>
        public bool SendQueryWhenExpiredAsync(ERequestResponseType requestType, uint milliseconds)
        {
            uint t = (uint)(DateTime.Now.Subtract(requestsRequired.GetLastRequestTime(requestType)).TotalMilliseconds);
            bool ret = (t >= milliseconds);
            if (ret)
            {
                SendQueryAsync(requestType);
            }
            return ret;
        }

        /// <summary>
        /// Send query
        /// </summary>
        /// <param name="requestType">Request type</param>
        /// <returns>Success</returns>
        private bool SendQuery(ERequestResponseType requestType)
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
                        writer.Write(IPv4AddressUInt);
                        writer.Write(Port);
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
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
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
                EndPoint endpoint = new IPEndPoint(IPAddress, Port);
                byte[] buffer = new byte[3402];
                socket.ReceiveFrom(buffer, ref endpoint);
                timestamp[1] = DateTime.Now;
                using (MemoryStream stream = new MemoryStream(buffer))
                {
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        if (stream.Length > 10)
                        {
                            string samp = new string(reader.ReadChars(4));
                            if (samp == "SAMP")
                            {
                                if (IPv4AddressUInt == reader.ReadUInt32())
                                {
                                    if (Port == reader.ReadUInt16())
                                    {
                                        switch (reader.ReadChar())
                                        {
                                            // Ping
                                            case 'p':
                                                if (Utils.AreEqual(randomNumbers, reader.ReadBytes(4)))
                                                {
                                                    Ping = (uint)(timestamp[1].Subtract(timestamp[0]).TotalMilliseconds);
                                                    requestsRequired[ERequestResponseType.Ping] = false;
                                                    OnResponse?.Invoke(this, ERequestResponseType.Ping);
                                                }
                                                break;

                                            // Information
                                            case 'i':
                                                hasPassword = (reader.ReadByte() != 0);
                                                playerCount = reader.ReadUInt16();
                                                maxPlayers = reader.ReadUInt16();
                                                hostname = Utils.GuessedStringEncoding(reader.ReadBytes(reader.ReadInt32()));
                                                gamemode = Utils.GuessedStringEncoding(reader.ReadBytes(reader.ReadInt32()));
                                                language = Utils.GuessedStringEncoding(reader.ReadBytes(reader.ReadInt32()));
                                                requestsRequired[ERequestResponseType.Information] = false;
                                                OnResponse?.Invoke(this, ERequestResponseType.Information);
                                                break;

                                            // Rules
                                            case 'r':
                                                {
                                                    int rc = reader.ReadInt16();
                                                    string k;
                                                    Dictionary<string, string> rules = new Dictionary<string, string>();
                                                    Dictionary<string, string> old_rules = this.rules;
                                                    try
                                                    {
                                                        for (int i = 0; i < rc; i++)
                                                        {
                                                            k = Utils.GuessedStringEncoding(reader.ReadBytes(reader.ReadByte()));
                                                            rules.Add(k, Utils.GuessedStringEncoding(reader.ReadBytes(reader.ReadByte())));
                                                        }
                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.Error.WriteLine(e);
                                                    }
                                                    requestsRequired[ERequestResponseType.Rules] = false;
                                                    this.rules = rules;
                                                    old_rules.Clear();
                                                    OnResponse?.Invoke(this, ERequestResponseType.Rules);
                                                }
                                                break;

                                            // Client list
                                            case 'c':
                                                {
                                                    int pc = reader.ReadInt16();
                                                    string k;
                                                    Dictionary<string, int> clients = new Dictionary<string, int>();
                                                    Dictionary<string, int> old_clients = this.clients;
                                                    try
                                                    {
                                                        for (int i = 0; i < pc; i++)
                                                        {
                                                            // Name and score
                                                            k = Utils.GuessedStringEncoding(reader.ReadBytes(reader.ReadByte()));
                                                            clients.Add(k, reader.ReadInt32());
                                                        }
                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.Error.WriteLine(e);
                                                    }
                                                    requestsRequired[ERequestResponseType.Clients] = false;
                                                    this.clients = clients;
                                                    old_clients.Clear();
                                                    OnResponse?.Invoke(this, ERequestResponseType.Clients);
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
                                                    Dictionary<byte, SAMPServerPlayer> players = new Dictionary<byte, SAMPServerPlayer>();
                                                    Dictionary<byte, SAMPServerPlayer> old_players = this.players;
                                                    try
                                                    {
                                                        for (ushort i = 0; i != playerCount; i++)
                                                        {
                                                            id = reader.ReadByte();
                                                            pn = Utils.GuessedStringEncoding(reader.ReadBytes(reader.ReadByte()));
                                                            s = reader.ReadInt32();
                                                            p = reader.ReadUInt32();
                                                            players.Add(id, new SAMPServerPlayer(id, pn, s, p));
                                                        }
                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.Error.WriteLine(e);
                                                    }
                                                    requestsRequired[ERequestResponseType.DetailedClients] = false;
                                                    this.players = players;
                                                    old_players.Clear();
                                                    OnResponse?.Invoke(this, ERequestResponseType.DetailedClients);
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
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
            }
        }

        /// <summary>
        /// Force request
        /// </summary>
        public void ForceRequest()
        {
            requestsRequired[ERequestResponseType.Ping] = true;
            requestsRequired[ERequestResponseType.Information] = true;
            requestsRequired[ERequestResponseType.Rules] = true;
            requestsRequired[ERequestResponseType.Clients] = true;
            requestsRequired[ERequestResponseType.DetailedClients] = true;
        }

        /// <summary>
        /// Get rule value
        /// </summary>
        /// <param name="ruleName">Rule name</param>
        /// <returns>Rule value</returns>
        public string GetRuleValue(string ruleName)
        {
            string ret = "";
            if (rules != null)
            {
                if (rules.ContainsKey(ruleName))
                {
                    ret = rules[ruleName];
                }
            }
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
            if (clients != null)
            {
                if (clients.ContainsKey(clientName))
                {
                    ret = clients[clientName];
                }
            }
            return ret;
        }

        /// <summary>
        /// Get player
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Player</returns>
        public ISAMPServerPlayer GetPlayer(byte id)
        {
            SAMPServerPlayer ret = null;
            if (players != null)
            {
                if (players.ContainsKey(id))
                {
                    ret = players[id];
                }
            }
            return ret;
        }

        /// <summary>
        /// To favourites server
        /// </summary>
        /// <param name="serverPassword">Server password</param>
        /// <param name="rconPassword">RCON password</param>
        /// <returns></returns>
        public IFavouriteSAMPServer ToFavouriteServer(string serverPassword, string rconPassword)
        {
            return new FavouriteSAMPServer(IPPortString, hostname, gamemode, serverPassword, rconPassword);
        }

        /// <summary>
        /// To favourites server
        /// </summary>
        /// <param name="serverPassword">Server password</param>
        /// <param name="rconPassword">RCON password</param>
        /// <returns></returns>
        public IFavouriteSAMPServer ToFavouriteServer()
        {
            return ToFavouriteServer("", "");
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

        /// <summary>
        /// Compare to
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>Comparison result</returns>
        public int CompareTo(object obj)
        {
            return ((obj is SAMPServer) ? CompareTo((SAMPServer)obj) : -1);
        }

        /// <summary>
        /// Compare to
        /// </summary>
        /// <param name="other">Other</param>
        /// <returns>Comparison result</returns>
        public int CompareTo(ISAMPServer other)
        {
            int ret = -1;
            if (other != null)
            {
                ret = IPPortString.CompareTo(other.IPPortString);
            }
            return ret;
        }
    }
}
