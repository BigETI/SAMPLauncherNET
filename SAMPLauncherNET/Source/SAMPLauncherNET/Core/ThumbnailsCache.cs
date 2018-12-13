using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Thumnails cache class
    /// </summary>
    public static class ThumbnailsCache
    {
        /// <summary>
        /// Cache
        /// </summary>
        private static Dictionary<string, Image> cache = new Dictionary<string, Image>();

        /// <summary>
        /// Clear
        /// </summary>
        public static void Clear()
        {
            foreach (Image image in cache.Values)
            {
                image.Dispose();
            }
            cache.Clear();
        }

        /// <summary>
        /// Get thumbnail
        /// </summary>
        /// <param name="path">Path</param>
        /// <returns>Image</returns>
        public static Image GetThumbnail(string path)
        {
            Image ret = null;
            string p = path.ToLowerInvariant();
            if (cache.ContainsKey(p))
            {
                ret = cache[p];
            }
            else
            {
                if (File.Exists(p))
                {
                    try
                    {
                        if (Utils.IsFileAvailable(p))
                        {
                            Image image = Image.FromFile(p);
                            if (image != null)
                            {
                                ret = Utils.GetThumbnail(image);
                                image.Dispose();
                                if (ret != null)
                                {
                                    cache.Add(p, ret);
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
                    }
                }
            }
            return ret;
        }

        /// <summary>
        /// Remove from cache
        /// </summary>
        /// <param name="path">Path</param>
        public static void RemoveFromCache(string path)
        {
            string p = path.ToLowerInvariant();
            if (cache.ContainsKey(p))
            {
                cache[p].Dispose();
                cache.Remove(p);
            }
        }
    }
}
