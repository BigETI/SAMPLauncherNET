using System;
using System.Collections.Generic;
using System.IO;

/// <summary>
/// SA:MP launcher.NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Media state class
    /// </summary>
    public class MediaState
    {
        /// <summary>
        /// Paths
        /// </summary>
        private string[] paths;

        /// <summary>
        /// File states
        /// </summary>
        private Dictionary<string, FileState> fileStates = new Dictionary<string, FileState>();

        /// <summary>
        /// Media state
        /// </summary>
        public MediaState(params string[] paths)
        {
            if (paths == null)
            {
                this.paths = new string[0];
            }
            if (paths != null)
            {
                this.paths = paths;
                foreach (string path in paths)
                {
                    AddFilesState(path);
                }
            }
        }

        /// <summary>
        /// Add files state
        /// </summary>
        /// <param name="path">Path</param>
        private void AddFilesState(string path)
        {
            try
            {
                if (path != null)
                {
                    if (Directory.Exists(path))
                    {
                        string[] paths = Directory.GetFiles(path);
                        if (paths != null)
                        {
                            foreach (string p in paths)
                            {
                                AddFilesState(p);
                            }
                        }
                    }
                    else if (File.Exists(path))
                    {
                        fileStates.Add(path, new FileState(path));
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
            }
        }

        /// <summary>
        /// Get files
        /// </summary>
        /// <param name="path">File or directory path</param>
        /// <returns>File paths</returns>
        private IEnumerable<string> GetFiles(string path)
        {
            List<string> ret = new List<string>();
            try
            {
                if (path != null)
                {
                    if (Directory.Exists(path))
                    {
                        string[] paths = Directory.GetFiles(path);
                        if (paths != null)
                        {
                            foreach (string p in paths)
                            {
                                ret.AddRange(GetFiles(p));
                            }
                        }
                    }
                    else if (File.Exists(path))
                    {
                        ret.Add(path);
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
            }
            return ret;
        }

        /// <summary>
        /// Get modified or added file paths
        /// </summary>
        /// <returns>File paths</returns>
        public string[] GetModifiedAdded()
        {
            List<string> ret = new List<string>();
            List<string> paths = new List<string>();
            foreach (string path in this.paths)
            {
                paths.AddRange(GetFiles(path));
            }
            foreach (string path in paths)
            {
                if (fileStates.ContainsKey(path))
                {
                    try
                    {
                        // Check for modified
                        DateTime last_write_date_time = File.GetLastWriteTime(path);
                        if (last_write_date_time > fileStates[path].LastWriteDateTime)
                        {
                            ret.Add(path);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
                    }
                }
                else
                {
                    ret.Add(path);
                }
            }
            return ret.ToArray();
        }
    }
}
