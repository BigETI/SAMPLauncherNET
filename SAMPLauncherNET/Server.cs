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
    public class Server
    {
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
                {
                    SendQuery('c');
                }
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

        public string[] CachedRowData
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

        public string[] FetchRowData
        {
            get
            {
                ForceRequest();
                Thread t = new Thread(delegate () { SendQuery('p'); });
                t.Start();
                t.Join(1000);
                t = new Thread(delegate () { SendQuery('i'); });
                t.Start();
                t.Join(1000);
                return CachedRowData;
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
                                                hostname = new string(reader.ReadChars(reader.ReadInt32()));
                                                gamemode = new string(reader.ReadChars(reader.ReadInt32()));
                                                language = new string(reader.ReadChars(reader.ReadInt32()));
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
                                                        k = new string(reader.ReadChars(reader.ReadByte()));
                                                        rules.Add(k, new string(reader.ReadChars(reader.ReadByte())));
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
                                                        k = new string(reader.ReadChars(reader.ReadByte()));
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
                                                        pn = new string(reader.ReadChars(reader.ReadByte()));
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
                                                    ping = (uint)(timestamp[1].Subtract(timestamp[0]).Milliseconds);
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
                        socket.SendTimeout = 5000;
                        socket.ReceiveTimeout = 5000;
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

        public string GetRule(string ruleName)
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

        public int GetClient(string clientName)
        {
            int ret = 0;
            if (cRequestRequired)
            {
                SendQuery('c');
            }
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
    }
}
