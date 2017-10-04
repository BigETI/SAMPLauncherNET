using System;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Player count string class
    /// </summary>
    public class PlayerCountString : IComparable, IComparable<PlayerCountString>
    {
        /// <summary>
        /// Player count
        /// </summary>
        private readonly uint playerCount;

        /// <summary>
        /// Max players
        /// </summary>
        private readonly uint maxPlayers;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="playerCount">Player count</param>
        /// <param name="maxPlayers">Max players</param>
        public PlayerCountString(uint playerCount, uint maxPlayers)
        {
            this.playerCount = playerCount;
            this.maxPlayers = maxPlayers;
        }

        /// <summary>
        /// Compare to
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>Result</returns>
        public int CompareTo(object obj)
        {
            int ret = 1;
            if (obj != null)
            {
                if (obj is PlayerCountString)
                {
                    ret = CompareTo((PlayerCountString)obj);
                }
            }
            return ret;
        }

        /// <summary>
        /// CompareTo
        /// </summary>
        /// <param name="other">Other</param>
        /// <returns>Result</returns>
        public int CompareTo(PlayerCountString other)
        {
            int ret = 1;
            if (other != null)
            {
                if (playerCount == other.playerCount)
                {
                    ret = ((maxPlayers == other.maxPlayers) ? 0 : ((maxPlayers > other.maxPlayers) ? 1 : -1));
                }
                else
                {
                    ret = ((playerCount > other.playerCount) ? 1 : -1);
                }
            }
            return ret;
        }

        /// <summary>
        /// To string
        /// </summary>
        /// <returns>String representation</returns>
        public override string ToString()
        {
            return playerCount + "/" + maxPlayers;
        }
    }
}
