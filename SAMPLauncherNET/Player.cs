/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Player class
    /// </summary>
    public class Player
    {
        /// <summary>
        /// ID
        /// </summary>
        private byte id;

        /// <summary>
        /// Name
        /// </summary>
        private string name;

        /// <summary>
        /// Score
        /// </summary>
        private int score;

        /// <summary>
        /// Ping
        /// </summary>
        private uint ping;

        /// <summary>
        /// ID
        /// </summary>
        public byte ID
        {
            get
            {
                return id;
            }
        }

        /// <summary>
        /// Name
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Score
        /// </summary>
        public int Score
        {
            get
            {
                return score;
            }
        }

        /// <summary>
        /// Ping
        /// </summary>
        public uint Ping
        {
            get
            {
                return ping;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="name">Name</param>
        /// <param name="score">Score</param>
        /// <param name="ping">Ping</param>
        public Player(byte id, string name, int score, uint ping)
        {
            this.id = id;
            this.name = name;
            this.score = score;
            this.ping = ping;
        }

    }
}
