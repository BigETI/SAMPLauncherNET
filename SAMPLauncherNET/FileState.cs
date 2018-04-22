using System;
using System.IO;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// File state class
    /// </summary>
    public class FileState
    {
        /// <summary>
        /// Path
        /// </summary>
        private string path;

        /// <summary>
        /// Last write date and time
        /// </summary>
        private DateTime lastWriteDateTime;

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
        /// Last write date and time
        /// </summary>
        public DateTime LastWriteDateTime
        {
            get
            {
                return lastWriteDateTime;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="path">Path</param>
        public FileState(string path)
        {
            this.path = path;
            if (File.Exists(path))
            {
                try
                {
                    lastWriteDateTime = File.GetLastWriteTime(path);
                }
                catch (Exception e)
                {
                    lastWriteDateTime = DateTime.Now;
                    Console.Error.WriteLine(e.Message);
                }
            }
            else
            {
                lastWriteDateTime = DateTime.Now;
            }
        }
    }
}
