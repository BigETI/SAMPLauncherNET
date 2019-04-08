using CSLPI;

/// <summary>
/// Community San Andreas Multiplayer Launcher programming interface namespace
/// </summary>
namespace CSL
{
    /// <summary>
    /// San Andreas Multiplayer server player class
    /// </summary>
    public class SAMPServerPlayer : ISAMPServerPlayer
    {
        /// <summary>
        /// Name
        /// </summary>
        private string name;

        /// <summary>
        /// ID
        /// </summary>
        public byte ID { get; private set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name
        {
            get
            {
                if (name == null)
                {
                    name = "";
                }
                return name;
            }
        }

        /// <summary>
        /// Score
        /// </summary>
        public int Score { get; private set; }

        /// <summary>
        /// Ping
        /// </summary>
        public uint Ping { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="name">Name</param>
        /// <param name="score">Score</param>
        /// <param name="ping">Ping</param>
        public SAMPServerPlayer(byte id, string name, int score, uint ping)
        {
            ID = id;
            this.name = name;
            Score = score;
            Ping = ping;
        }
    }
}
