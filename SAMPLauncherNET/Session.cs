using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization.Json;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Session class
    /// </summary>
    public class Session : IDisposable
    {
        /// <summary>
        /// Session data
        /// </summary>
        private SessionDataContract sessionData;

        /// <summary>
        /// Path
        /// </summary>
        private string path;

        /// <summary>
        /// Chatlog
        /// </summary>
        private string chatlog;

        /// <summary>
        /// Saved positons
        /// </summary>
        private string savedPositions;

        /// <summary>
        /// Screenshots
        /// </summary>
        private Dictionary<string, Image> screenshots;

        /// <summary>
        /// Serializer
        /// </summary>
        private static readonly DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(SessionDataContract));

        /// <summary>
        /// Path
        /// </summary>
        public string Path
        {
            get
            {
                return path;
            }
        }

        /// <summary>
        /// Session data
        /// </summary>
        public SessionDataContract SessionData
        {
            get
            {
                return sessionData;
            }
        }

        /// <summary>
        /// Date and time
        /// </summary>
        public DateTime DateTime
        {
            get
            {
                return sessionData.DateTime;
            }
        }

        /// <summary>
        /// Time span
        /// </summary>
        public TimeSpan TimeSpan
        {
            get
            {
                return sessionData.TimeSpan;
            }
        }

        /// <summary>
        /// Game version
        /// </summary>
        public string GameVersion
        {
            get
            {
                return sessionData.GameVersion;
            }
        }

        /// <summary>
        /// Username
        /// </summary>
        public string Username
        {
            get
            {
                return sessionData.Username;
            }
        }

        /// <summary>
        /// IP and port
        /// </summary>
        public string IPPort
        {
            get
            {
                return sessionData.IPPort;
            }
        }

        /// <summary>
        /// Hostname
        /// </summary>
        public string Hostname
        {
            get
            {
                return sessionData.Hostname;
            }
        }

        /// <summary>
        /// Mode
        /// </summary>
        public string Mode
        {
            get
            {
                return sessionData.Mode;
            }
        }

        /// <summary>
        /// Language
        /// </summary>
        public string Language
        {
            get
            {
                return sessionData.Language;
            }
        }

        /// <summary>
        /// Chatlog
        /// </summary>
        public string Chatlog
        {
            get
            {
                if (chatlog == null)
                {
                    if (File.Exists(path))
                    {
                        try
                        {
                            using (ZipArchive archive = ZipFile.Open(path, ZipArchiveMode.Read))
                            {
                                ZipArchiveEntry entry = archive.GetEntry("chatlog.txt");
                                if (entry != null)
                                {
                                    using (StreamReader reader = new StreamReader(entry.Open()))
                                    {
                                        chatlog = reader.ReadToEnd();
                                    }
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Error.WriteLine(e.Message);
                        }
                    }
                }
                if (chatlog == null)
                {
                    chatlog = "";
                }
                return chatlog;
            }
        }

        /// <summary>
        /// Saved positions
        /// </summary>
        public string SavedPositions
        {
            get
            {
                if (savedPositions == null)
                {
                    if (File.Exists(path))
                    {
                        try
                        {
                            using (ZipArchive archive = ZipFile.Open(path, ZipArchiveMode.Read))
                            {
                                ZipArchiveEntry entry = archive.GetEntry("saved-positions.txt");
                                if (entry != null)
                                {
                                    using (StreamReader reader = new StreamReader(entry.Open()))
                                    {
                                        savedPositions = reader.ReadToEnd();
                                    }
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Error.WriteLine(e.Message);
                        }
                    }
                }
                if (savedPositions == null)
                {
                    savedPositions = "";
                }
                return savedPositions;
            }
        }

        /// <summary>
        /// Screenshots
        /// </summary>
        public IDictionary<string, Image> Screenshots
        {
            get
            {
                if (screenshots == null)
                {
                    screenshots = new Dictionary<string, Image>();
                    try
                    {
                        if (path != null)
                        {
                            if (File.Exists(path))
                            {
                                using (ZipArchive archive = ZipFile.Open(path, ZipArchiveMode.Read))
                                {
                                    foreach (ZipArchiveEntry entry in archive.Entries)
                                    {
                                        if (entry.FullName.StartsWith("screenshots/") && entry.FullName.EndsWith(".png"))
                                        {
                                            try
                                            {
                                                using (Stream stream = entry.Open())
                                                {
                                                    Image image = Image.FromStream(stream);
                                                    if (image != null)
                                                    {
                                                        screenshots.Add(entry.FullName, image);
                                                    }
                                                }
                                            }
                                            catch (Exception e)
                                            {
                                                Console.Error.WriteLine(e.Message);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e.Message);
                    }
                }
                return screenshots;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="path">Path</param>
        /// <param name="sessionData">Session data</param>
        private Session(string path, SessionDataContract sessionData)
        {
            this.path = path;
            this.sessionData = sessionData;
        }

        /// <summary>
        /// Create session
        /// </summary>
        /// <param name="path">Path</param>
        /// <param name="dateTime">Date and time</param>
        /// <param name="timeSpan">Time span</param>
        /// <param name="gameVersion">Game version</param>
        /// <param name="username">Username</param>
        /// <param name="ipPort">IP and port</param>
        /// <param name="hostname">Hostname</param>
        /// <param name="mode">Mode</param>
        /// <param name="language">Language</param>
        /// <param name="screenshotPaths">Screenshot paths</param>
        /// <param name="chatlogPath">Chatlog path</param>
        /// <param name="savedPositionsPath">Saved positions path</param>
        /// <returns>New session</returns>
        public static Session Create(string path, DateTime dateTime, TimeSpan timeSpan, string gameVersion, string username, string ipPort, string hostname, string mode, string language, string[] screenshotPaths, string chatlogPath, string savedPositionsPath)
        {
            Session ret = null;
            if (path != null)
            {
                if (path != null)
                {
                    SessionDataContract session_data = new SessionDataContract(dateTime, timeSpan, gameVersion, username, ipPort, hostname, mode, language);
                    try
                    {
                        if (File.Exists(path))
                        {
                            File.Delete(path);
                        }
                        using (ZipArchive archive = ZipFile.Open(path, ZipArchiveMode.Create))
                        {
                            ZipArchiveEntry entry = archive.CreateEntry("meta.json");
                            if (entry != null)
                            {
                                using (Stream stream = entry.Open())
                                {
                                    serializer.WriteObject(stream, session_data);
                                }
                            }
                            if (screenshotPaths != null)
                            {
                                foreach (string screenshot_path in screenshotPaths)
                                {
                                    if (screenshot_path != null)
                                    {
                                        if (File.Exists(screenshot_path))
                                        {
                                            archive.CreateEntryFromFile(screenshot_path, "screenshots/" + System.IO.Path.GetFileName(screenshot_path));
                                        }
                                    }
                                }
                            }
                            if (chatlogPath != null)
                            {
                                if (File.Exists(chatlogPath))
                                {
                                    archive.CreateEntryFromFile(chatlogPath, "chatlog.txt");
                                }
                            }
                            if (savedPositionsPath != null)
                            {
                                if (File.Exists(savedPositionsPath))
                                {
                                    archive.CreateEntryFromFile(savedPositionsPath, "saved-positions.txt");
                                }
                            }
                        }
                        ret = new Session(path, session_data);
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e.Message);
                    }
                }
            }
            return ret;
        }

        /// <summary>
        /// Load session
        /// </summary>
        /// <param name="path">Path</param>
        /// <returns>Session if successful, otherwise "null"</returns>
        public static Session Load(string path)
        {
            Session ret = null;
            try
            {
                if (path != null)
                {
                    if (File.Exists(path))
                    {
                        using (ZipArchive archive = ZipFile.Open(path, ZipArchiveMode.Read))
                        {
                            ZipArchiveEntry entry = archive.GetEntry("meta.json");
                            if (entry != null)
                            {
                                using (Stream stream = entry.Open())
                                {
                                    SessionDataContract session_data = serializer.ReadObject(stream) as SessionDataContract;
                                    if (session_data != null)
                                    {
                                        ret = new Session(path, session_data);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
            return ret;
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            if (screenshots != null)
            {
                foreach (Image screenshot in screenshots.Values)
                {
                    screenshot.Dispose();
                }
                screenshots.Clear();
                screenshots = null;
            }
        }
    }
}
