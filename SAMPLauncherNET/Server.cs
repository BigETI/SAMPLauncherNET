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
        private static readonly Encoding QueryEncoding = Encoding.Default;

        Socket socket = null;

        private uint ipv4AddressUInt = 0U;

        private ushort port = 0;

        private bool isValid = false;

        private IPAddress ipAddress = null;

        private DateTime[] timestamp = new DateTime[2];

        private bool iRequestRequired = true;

        private bool rRequestRequired = true;

        private bool cRequestRequired = true;

        private bool dRequestRequired = true;

        private bool pRequestRequired = true;

        private bool hasPassword = false;

        private ushort playerCount = 0;

        private ushort maxPlayers = 0;

        private string hostname = "";

        private string gamemode = "";

        private string language = "";

        private Dictionary<string, string> rules = new Dictionary<string, string>();

        private Dictionary<string, int> clients = new Dictionary<string, int>();

        private Dictionary<byte, Player> players = new Dictionary<byte, Player>();

        private byte[] randomNumbers = new byte[4];

        private uint ping = 0U;

        private Thread[] threads = null;

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
                if (iRequestRequired)
                    SendQuery('i');
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
                if (iRequestRequired)
                    SendQuery('i');
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
                if (iRequestRequired)
                    SendQuery('i');
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

        public virtual string Hostname
        {
            get
            {
                if (iRequestRequired)
                    SendQuery('i');
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
                if (iRequestRequired)
                    SendQuery('i');
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
                if (iRequestRequired)
                    SendQuery('i');
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
                if (rRequestRequired)
                    SendQuery('r');
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
                if (cRequestRequired)
                    SendQuery('c');
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
                if (dRequestRequired)
                    SendQuery('d');
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

        public uint Ping
        {
            get
            {
                if (pRequestRequired)
                    SendQuery('p');
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

        public string[] CachedStringData
        {
            get
            {
                string[] ret = new string[7];
                if (pRequestRequired)
                    ret[0] = "-";
                else
                    ret[0] = ping.ToString();
                if (iRequestRequired)
                {
                    ret[1] = "-";
                    ret[2] = "-";
                    ret[3] = "-";
                    ret[4] = "-";
                    ret[5] = "-";
                }
                else
                {
                    ret[1] = hostname;
                    ret[2] = playerCount.ToString();
                    ret[3] = maxPlayers.ToString();
                    ret[4] = gamemode;
                    ret[5] = language;
                }
                ret[6] = IPv4AddressString + ":" + port;
                return ret;
            }
        }

        public object[] CachedRowData
        {
            get
            {
                object[] ret = new object[7];
                if (pRequestRequired)
                    ret[0] = 0U;
                else
                    ret[0] = ping;
                if (iRequestRequired)
                {
                    ret[1] = "";
                    ret[2] = (ushort)0;
                    ret[3] = (ushort)0;
                    ret[4] = "";
                    ret[5] = "";
                }
                else
                {
                    ret[1] = hostname;
                    ret[2] = playerCount;
                    ret[3] = maxPlayers;
                    ret[4] = gamemode;
                    ret[5] = language;
                }
                ret[6] = IPv4AddressString + ":" + port;
                return ret;
            }
        }

        public bool IsRowDataNotFetched
        {
            get
            {
                return (iRequestRequired || pRequestRequired);
            }
        }

        public bool IsRowDataFetched
        {
            get
            {
                return ((!iRequestRequired) && (!pRequestRequired));
            }
        }

        public void FetchAnyData()
        {
            if (threads != null)
            {
                foreach (Thread t in threads)
                {
                    if (t != null)
                        t.Interrupt();
                }
            }
            ForceRequest();
            threads = new Thread[5];
            threads[0] = new Thread(() => SendQuery('p'));
            threads[1] = new Thread(() => SendQuery('i'));
            threads[2] = new Thread(() => SendQuery('r'));
            threads[3] = new Thread(() => SendQuery('c'));
            threads[4] = new Thread(() => SendQuery('d'));
            foreach (Thread t in threads)
            {
                if (t != null)
                    t.Start();
            }
        }

        public void FetchRowData()
        {
            if (threads != null)
            {
                foreach (Thread t in threads)
                {
                    if (t != null)
                        t.Interrupt();
                }
            }
            pRequestRequired = true;
            iRequestRequired = true;
            threads = new Thread[2];
            threads[0] = new Thread(() => SendQuery('p'));
            threads[1] = new Thread(() => SendQuery('i'));
            foreach (Thread t in threads)
            {
                if (t != null)
                    t.Start();
            }
        }

        private bool SendQuery(char opcode)
        {
            bool ret = false;
            try
            {
                EndPoint endpoint = new IPEndPoint(IPAddress, Port);
                using (MemoryStream stream = new MemoryStream())
                {
                    using (BinaryWriter writer = new BinaryWriter(stream))
                    {
                        writer.Write("SAMP".ToCharArray());
                        writer.Write(ipv4AddressUInt);
                        writer.Write(port);
                        writer.Write(opcode);
                        if (opcode == 'p')
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
            uint c = 0U;
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
                                            // Information
                                            case 'i':
                                                hasPassword = (reader.ReadByte() != 0);
                                                playerCount = reader.ReadUInt16();
                                                maxPlayers = reader.ReadUInt16();
                                                byte[] hnbs = reader.ReadBytes(reader.ReadInt32());
                                                hostname = QueryEncoding.GetString(hnbs);
                                                gamemode = QueryEncoding.GetString(reader.ReadBytes(reader.ReadInt32()));
                                                language = QueryEncoding.GetString(reader.ReadBytes(reader.ReadInt32()));
                                                iRequestRequired = false;
                                                break;

                                            // Rules
                                            case 'r':
                                                {
                                                    int rc = reader.ReadInt16();
                                                    string k;
                                                    rules.Clear();
                                                    for (int i = 0; i < rc; i++)
                                                    {
                                                        k = QueryEncoding.GetString(reader.ReadBytes(reader.ReadByte()));
                                                        rules.Add(k, QueryEncoding.GetString(reader.ReadBytes(reader.ReadByte())));
                                                    }
                                                    rRequestRequired = false;
                                                }
                                                break;

                                            // Client list
                                            case 'c':
                                                {
                                                    int pc = reader.ReadInt16();
                                                    string k;
                                                    clients.Clear();
                                                    for (int i = 0; i < pc; i++)
                                                    {
                                                        // Name and score
                                                        k = QueryEncoding.GetString(reader.ReadBytes(reader.ReadByte()));
                                                        clients.Add(k, reader.ReadInt32());
                                                    }
                                                    cRequestRequired = false;
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
                                                    for (ushort i = 0; i != playerCount; i++)
                                                    {
                                                        id = reader.ReadByte();
                                                        pn = QueryEncoding.GetString(reader.ReadBytes(reader.ReadByte()));
                                                        s = reader.ReadInt32();
                                                        p = reader.ReadUInt32();
                                                        players.Add(id, new Player(id, pn, s, p));
                                                    }
                                                    dRequestRequired = false;
                                                }
                                                break;

                                            // Ping
                                            case 'p':
                                                if (Utils.AreEqual(randomNumbers, reader.ReadBytes(4)))
                                                {
                                                    ping = (uint)(timestamp[1].Subtract(timestamp[0]).TotalMilliseconds);
                                                    pRequestRequired = false;
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

        public Server(string ipAddressAndPortString)
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
                        FetchRowData();
                    }
                    else
                    {
                        ipv4AddressUInt = 0U;
                        isValid = false;
                    }
                }
            }
        }

        public void ForceRequest()
        {
            iRequestRequired = true;
            rRequestRequired = true;
            cRequestRequired = true;
            dRequestRequired = true;
            pRequestRequired = true;
        }

        public string GetRuleValue(string ruleName)
        {
            string ret = "";
            if (rRequestRequired)
            {
                SendQuery('r');
            }
            if (rules.ContainsKey(ruleName))
                ret = rules[ruleName];
            return ret;
        }

        public int GetScoreFromClient(string clientName)
        {
            int ret = 0;
            if (cRequestRequired)
                SendQuery('c');
            if (clients.ContainsKey(clientName))
                ret = clients[clientName];
            return ret;
        }

        public Player GetPlayer(byte id)
        {
            Player ret = null;
            if (dRequestRequired)
                SendQuery('d');
            if (players.ContainsKey(id))
                ret = players[id];
            return ret;
        }

        public FavouriteServer ToFavouriteServer(string cachedName = "", string serverPassword = "", string rconPassword = "")
        {
            return new FavouriteServer(IPv4AddressString + ":" + port, serverPassword, rconPassword);
        }

        public void Dispose()
        {
            if (threads != null)
            {
                foreach (Thread t in threads)
                    t.Abort();
                threads = null;
            }
            if (socket != null)
            {
                socket.Dispose();
                socket = null;
            }
        }
    }
}
