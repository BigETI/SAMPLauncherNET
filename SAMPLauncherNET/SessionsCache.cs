using System.Collections.Generic;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Sessions cache class
    /// </summary>
    public static class SessionsCache
    {
        /// <summary>
        /// Sessions
        /// </summary>
        private static Dictionary<string, Session> sessions = new Dictionary<string, Session>();

        /// <summary>
        /// Get session
        /// </summary>
        /// <param name="path">Session path</param>
        /// <returns>Session</returns>
        public static Session GetSession(string path)
        {
            Session ret = null;
            if (path != null)
            {
                string p = path.ToLower();
                lock (sessions)
                {
                    if (sessions.ContainsKey(p))
                    {
                        ret = sessions[p];
                    }
                    else
                    {
                        ret = Session.Load(path);
                        if (ret != null)
                        {
                            sessions.Add(p, ret);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>
        /// Clear session cache
        /// </summary>
        public static void Clear()
        {
            lock (sessions)
            {
                sessions.Clear();
            }
        }

        /// <summary>
        /// Remove session from cache
        /// </summary>
        /// <param name="session">Session</param>
        public static void Remove(Session session)
        {
            if (session != null)
            {
                string path = session.Path.ToLower();
                if (sessions.ContainsKey(path))
                {
                    sessions.Remove(path);
                }
            }
        }
    }
}
