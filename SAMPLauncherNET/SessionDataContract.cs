using System;
using System.Runtime.Serialization;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Session data contract class
    /// </summary>
    [DataContract]
    public class SessionDataContract
    {
        /// <summary>
        /// Date and time
        /// </summary>
        [DataMember]
        private DateTime dateTime;

        /// <summary>
        /// Time span
        /// </summary>
        [DataMember]
        private TimeSpan timeSpan;

        /// <summary>
        /// Game version
        /// </summary>
        [DataMember]
        private string gameVersion;

        /// <summary>
        /// Username
        /// </summary>
        [DataMember]
        private string username;

        /// <summary>
        /// IP and port
        /// </summary>
        [DataMember]
        private string ipPort;

        /// <summary>
        /// Hostname
        /// </summary>
        [DataMember]
        private string hostname;

        /// <summary>
        /// Mode
        /// </summary>
        [DataMember]
        private string mode;

        /// <summary>
        /// Language
        /// </summary>
        [DataMember]
        private string language;

        /// <summary>
        /// Date and time
        /// </summary>
        public DateTime DateTime
        {
            get
            {
                return dateTime;
            }
        }

        /// <summary>
        /// Time span
        /// </summary>
        public TimeSpan TimeSpan
        {
            get
            {
                return timeSpan;
            }
        }

        /// <summary>
        /// Game version
        /// </summary>
        public string GameVersion
        {
            get
            {
                return gameVersion;
            }
        }

        /// <summary>
        /// Username
        /// </summary>
        public string Username
        {
            get
            {
                return username;
            }
        }

        /// <summary>
        /// IP and port
        /// </summary>
        public string IPPort
        {
            get
            {
                return ipPort;
            }
        }

        /// <summary>
        /// Hostname
        /// </summary>
        public string Hostname
        {
            get
            {
                return hostname;
            }
        }

        /// <summary>
        /// Mode
        /// </summary>
        public string Mode
        {
            get
            {
                return mode;
            }
        }

        /// <summary>
        /// Language
        /// </summary>
        public string Language
        {
            get
            {
                return language;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dateTime">Date and time</param>
        /// <param name="timeSpan">Time span</param>
        /// <param name="gameVersion">Game version</param>
        /// <param name="username">Username</param>
        /// <param name="ipPort">IP and port</param>
        /// <param name="hostname">Hostname</param>
        /// <param name="mode">Mode</param>
        /// <param name="language">Language</param>
        public SessionDataContract(DateTime dateTime, TimeSpan timeSpan, string gameVersion, string username, string ipPort, string hostname, string mode, string language)
        {
            this.dateTime = dateTime;
            this.timeSpan = timeSpan;
            this.gameVersion = gameVersion;
            this.username = username;
            this.ipPort = ipPort;
            this.hostname = hostname;
            this.mode = mode;
            this.language = language;
        }
    }
}
