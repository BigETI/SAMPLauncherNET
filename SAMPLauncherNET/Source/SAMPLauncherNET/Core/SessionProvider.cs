using System;
using System.Collections.Generic;
using System.IO;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Session provider class
    /// </summary>
    public static class SessionProvider
    {
        /// <summary>
        /// Sessions directory
        /// </summary>
        private static readonly string sessionsDirectory = Path.GetFullPath("./sessions");

        /// <summary>
        /// Sessions directory
        /// </summary>
        public static string SessionsDirectory
        {
            get
            {
                return sessionsDirectory;
            }
        }

        /// <summary>
        /// Sessions
        /// </summary>
        public static Session[] Sessions
        {
            get
            {
                List<Session> ret = new List<Session>();
                try
                {
                    if (Directory.Exists(sessionsDirectory))
                    {
                        string[] files = Directory.GetFiles(sessionsDirectory, "*.samp-session", SearchOption.AllDirectories);
                        if (files != null)
                        {
                            foreach (string file in files)
                            {
                                Session session = SessionsCache.GetSession(file);
                                if (session != null)
                                {
                                    ret.Add(session);
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                }
                return ret.ToArray();
            }
        }

        /// <summary>
        /// Get current media state
        /// </summary>
        /// <returns>Media state</returns>
        public static MediaState GetCurrentMediaState()
        {
            return new MediaState(SAMP.GalleryPath, SAMP.ChatlogPath, SAMP.SavedPositionsPath);
        }
    }
}
