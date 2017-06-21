namespace SAMPLauncherNET
{
    public class Player
    {
        private byte id;

        private string name;

        private int score;

        private uint ping;

        public byte ID
        {
            get
            {
                return id;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Score
        {
            get
            {
                return score;
            }
        }

        public uint Ping
        {
            get
            {
                return ping;
            }
        }

        public Player(byte id, string name, int score, uint ping)
        {
            this.id = id;
            this.name = name;
            this.score = score;
            this.ping = ping;
        }

    }
}
