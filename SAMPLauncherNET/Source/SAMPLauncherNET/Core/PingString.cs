using System;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Ping string class
    /// </summary>
    public class PingString : IComparable, IComparable<PingString>
    {
        /// <summary>
        /// Ping
        /// </summary>
        private readonly uint ping;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ping">Ping</param>
        public PingString(uint ping)
        {
            this.ping = ping;
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
                ret = CompareTo(obj as PingString);
            }
            return ret;
        }

        /// <summary>
        /// CompareTo
        /// </summary>
        /// <param name="other">Other</param>
        /// <returns>Result</returns>
        public int CompareTo(PingString other)
        {
            int ret = 1;
            if (other != null)
            {
                ret = ping.CompareTo(other.ping);
            }
            return ret;
        }

        /// <summary>
        /// To string
        /// </summary>
        /// <returns>String representation</returns>
        public override string ToString()
        {
            return ((ping == uint.MaxValue) ? "-" : ping.ToString());
        }
    }
}
