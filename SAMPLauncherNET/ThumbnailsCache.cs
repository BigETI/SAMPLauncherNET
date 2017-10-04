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
            path = path.ToLower();
            if (cache.ContainsKey(path))
            {
                ret = cache[path];
            }
            else
            {
                if (File.Exists(path))
                {
                    Image image = Image.FromFile(path);
                    if (image != null)
                    {
                        ret = Utils.GetThumbnail(image);
                        image.Dispose();
                        cache.Add(path, ret);
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
