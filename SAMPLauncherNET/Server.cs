using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SAMPLauncherNET
{
    public class Server : IDisposable
    {

        private Socket socket = null;

        private uint ipv4AddressUInt = 0U;

        private ushort port = 0;

        private bool isValid = false;

        private IPAddress ipAddress = null;

        private DateTime[] timestamp = new DateTime[2];

        protected RequestsRequired requestsRequired = new RequestsRequired();

        private bool hasPassword = false;

        private ushort playerCount = 0;

        private ushort maxPlayers = 0;

        protected string hostname = "";

        protected string gamemode = "";

        private string language = "";

        private Dictionary<string, string> rules = new Dictionary<string, string>();

        private Dictionary<string, int> clients = new Dictionary<string, int>();

        private Dictionary<byte, Player> players = new Dictionary<byte, Player>();

        private byte[] randomNumbers = new byte[4];

        private uint ping = 0U;

        private Thread[] threads = new Thread[5];

        public uint IPv4AddressInt
        {
            get
            {
                return ipv4AddressUInt;
            }
        }

        public ushort Port
        {
            get
            {
                return port;
            }
        }

        public bool IsValid
        {
            get
            {
                return isValid;
            }
        }

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

        public bool HasPassword
        {
            get
            {
                SendQueryWhenRequired(ERequestType.Information);
                return hasPassword;
            }
        }

        public Task<bool> HasPasswordAsync
        {
            get
            {
                return Task.Factory.StartNew(() => HasPassword);
            }
        }

        public ushort PlayerCount
        {
            get
            {
                SendQueryWhenRequired(ERequestType.Information);
                return playerCount;
            }
        }

        public Task<ushort> PlayerCountAsync
        {
            get
            {
                return Task.Factory.StartNew(() => PlayerCount);
            }
        }

        public ushort MaxPlayers
        {
            get
            {
                SendQueryWhenRequired(ERequestType.Information);
                return maxPlayers;
            }
        }

        public Task<ushort> MaxPlayersAsync
        {
            get
            {
                return Task.Factory.StartNew(() => MaxPlayers);
            }
        }

        public string Hostname
        {
            get
            {
                SendQueryWhenRequired(ERequestType.Information);
                return hostname;
            }
        }

        public Task<string> HostnameAsync
        {
            get
            {
                return Task.Factory.StartNew(() => Hostname);
            }
        }

        public string Gamemode
        {
            get
            {
                SendQueryWhenRequired(ERequestType.Information);
                return gamemode;
            }
        }

        public Task<string> GamemodeAsync
        {
            get
            {
                return Task.Factory.StartNew(() => Gamemode);
            }
        }

        public string Language
        {
            get
            {
                SendQueryWhenRequired(ERequestType.Information);
                return language;
            }
        }

        public Task<string> LanguageAsync
        {
            get
            {
                return Task.Factory.StartNew(() => Language);
            }
        }

        public Dictionary<string, string>.KeyCollection RuleKeys
        {
            get
            {
                SendQueryWhenRequired(ERequestType.Rules);
                return rules.Keys;
            }
        }

        public Task<Dictionary<string, string>.KeyCollection> RuleKeysAsync
        {
            get
            {
                return Task.Factory.StartNew(() => RuleKeys);
            }
        }

        public Dictionary<string, int>.KeyCollection ClientKeys
        {
            get
            {
                SendQueryWhenRequired(ERequestType.Clients);
                return clients.Keys;
            }
        }

        public Task<Dictionary<string, int>.KeyCollection> ClientKeysAsync
        {
            get
            {
                return Task.Factory.StartNew(() => ClientKeys);
            }
        }

        public Dictionary<byte, Player>.KeyCollection PlayerKeys
        {
            get
            {
                SendQueryWhenRequired(ERequestType.DetailedClients);
                return players.Keys;
            }
        }

        public Task<Dictionary<byte, Player>.KeyCollection> PlayerKeysAsync
        {
            get
            {
                return Task.Factory.StartNew(() => PlayerKeys);
            }
        }

        public Dictionary<byte, Player>.ValueCollection PlayerValues
        {
            get
            {
                SendQueryWhenRequired(ERequestType.DetailedClients);
                return players.Values;
            }
        }

        public Task<Dictionary<byte, Player>.ValueCollection> PlayerValuesAsync
        {
            get
            {
                return Task.Factory.StartNew(() => PlayerValues);
            }
        }

        public uint Ping
        {
            get
            {
                SendQueryWhenRequired(ERequestType.Ping);
                return ping;
            }
        }

        public Task<uint> PingAsync
        {
            get
            {
                return Task.Factory.StartNew(() => Ping);
            }
        }

        public string IPPortString
        {
            get
            {
                return IPv4AddressString + ":" + port;
            }
        }

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

        public Server(string ipAddressAndPortString, bool fetchData = true)
        {
            string[] parts = ipAddressAndPortString.Trim().Split(new char[] { '.', ':' });
            uint n;
            if (parts.Length == 5)
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
                    if (ushort.TryParse(parts[4], out port))
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
        }

        public bool IsDataFetched(ERequestType requestType)
        {
            return !(requestsRequired[requestType]);
        }

        public void FetchAnyData()
        {
            FetchAnyDataAsync();
            JoinAllThreads();
        }

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

        public void FetchData(ERequestType requestType)
        {
            AbortThread(requestType);
            requestsRequired[requestType] = true;
            SendQuery(requestType);
        }

        public void FetchDataAsync(ERequestType requestType)
        {
            AbortThread(requestType);
            requestsRequired[requestType] = true;
            SendQueryAsync(requestType);
        }

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

        private void SendQueryAsync(ERequestType requestType)
        {
            int index = (int)requestType;
            threads[index] = new Thread(() => SendQuery(requestType));
            requestsRequired.SetLastRequestTime(requestType);
            threads[index].Start();
        }

        private bool SendQueryWhenRequired(ERequestType requestType)
        {
            bool ret = true;
            if (requestsRequired[requestType])
                ret = SendQuery(requestType);
            return ret;
        }

        public void SendQueryWhenExpired(ERequestType requestType, uint milliseconds)
        {
            uint t = (uint)(DateTime.Now.Subtract(requestsRequired.GetLastRequestTime(requestType)).TotalMilliseconds);
            if (t >= milliseconds)
                SendQueryAsync(requestType);
                
        }

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

        public void ForceRequest()
        {
            requestsRequired[ERequestType.Ping] = true;
            requestsRequired[ERequestType.Information] = true;
            requestsRequired[ERequestType.Rules] = true;
            requestsRequired[ERequestType.Clients] = true;
            requestsRequired[ERequestType.DetailedClients] = true;
        }

        public string GetRuleValue(string ruleName)
        {
            string ret = "";
            SendQueryWhenRequired(ERequestType.Rules);
            if (rules.ContainsKey(ruleName))
                ret = rules[ruleName];
            return ret;
        }

        public int GetScoreFromClient(string clientName)
        {
            int ret = 0;
            SendQueryWhenRequired(ERequestType.Clients);
            if (clients.ContainsKey(clientName))
                ret = clients[clientName];
            return ret;
        }

        public Player GetPlayer(byte id)
        {
            Player ret = null;
            SendQueryWhenRequired(ERequestType.DetailedClients);
            if (players.ContainsKey(id))
                ret = players[id];
            return ret;
        }

        public FavouriteServer ToFavouriteServer(string cachedName = "", string cachedGamemode = "", string serverPassword = "", string rconPassword = "")
        {
            return new FavouriteServer(IPPortString, cachedName, cachedGamemode, serverPassword, rconPassword);
        }

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
