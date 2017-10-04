using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Utility class
    /// </summary>
    public static class Utils
    {
        /// <summary>
        /// Gallery image size
        /// </summary>
        public static readonly Size GalleryImageSize = new Size(256, 256);

        /// <summary>
        /// Are arrays equal
        /// </summary>
        /// <typeparam name="T">Array type</typeparam>
        /// <param name="a">Left hand array</param>
        /// <param name="b">Right hand array</param>
        /// <returns></returns>
        public static bool AreEqual<T>(T[] a, T[] b)
        {
            bool ret = false;
            if ((a != null) && (b != null))
            {
                if (a.Length == b.Length)
                {
                    ret = true;
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (!(a[i].Equals(b[i])))
                        {
                            ret = false;
                            break;
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>
        /// Dispose all
        /// </summary>
        /// <param name="list">List</param>
        public static void DisposeAll(IDisposable[] list)
        {
            if (list != null)
            {
                foreach (IDisposable i in list)
                {
                    if (i != null)
                    {
                        i.Dispose();
                    }
                }
            }
        }

        /// <summary>
        /// Append character to string
        /// </summary>
        /// <param name="str">String</param>
        /// <param name="character">Character</param>
        /// <returns>String with character</returns>
        public static string AppendCharacterToString(string str, char character)
        {
            string ret = (str == null) ? "" : str;
            if (ret.Length > 0)
            {
                if (ret[ret.Length - 1] != character)
                {
                    ret += character;
                }
            }
            else
            {
                ret += character;
            }
            return ret;
        }

        /// <summary>
        /// Not available string
        /// </summary>
        /// <param name="str">String</param>
        /// <returns>String representation</returns>
        public static string NAString(string str)
        {
            return ((str == null) ? "N/A" : ((str.Length > 0) ? str : "N/A"));
        }

        /// <summary>
        /// Get file resources from directory
        /// </summary>
        /// <param name="directory">Directory</param>
        /// <param name="searchPattern">Search pattern</param>
        /// <param name="searchOption">Search option</param>
        /// <returns>File resources</returns>
        public static FileResource[] GetFilesFromDirectory(string directory, string searchPattern, SearchOption searchOption)
        {
            FileResource[] ret = null;
            if (Directory.Exists(directory))
            {
                string[] files = Directory.GetFiles(directory, searchPattern, searchOption);
                ret = new FileResource[files.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = new FileResource(files[i]);
                }
            }
            if (ret == null)
            {
                ret = new FileResource[0];
            }
            return ret;
        }

        /// <summary>
        /// Get integer from text
        /// </summary>
        /// <param name="text">Text</param>
        /// <returns>Integer</returns>
        public static int GetInt(string text)
        {
            return GetInt(text, 0);
        }

        /// <summary>
        /// Get integer from text
        /// </summary>
        /// <param name="text">Text</param>
        /// <param name="defaultValue">Default value</param>
        /// <returns>Integer</returns>
        public static int GetInt(string text, int defaultValue)
        {
            int ret = 0;
            if (!(int.TryParse(text, out ret)))
            {
                ret = 0;
            }
            return ret;
        }

        /// <summary>
        /// Get floating point number from text
        /// </summary>
        /// <param name="text">Text</param>
        /// <returns>Floating point number</returns>
        public static float GetFloat(string text)
        {
            return GetFloat(text, 0.0f);
        }

        /// <summary>
        /// Get floating point number from text
        /// </summary>
        /// <param name="text">Text</param>
        /// <param name="defaultValue">Default value</param>
        /// <returns>Floating point number</returns>
        public static float GetFloat(string text, float defaultValue)
        {
            float ret = 0.0f;
            if (!(float.TryParse(text, out ret)))
            {
                ret = 0.0f;
            }
            return ret;
        }

        /// <summary>
        /// Get random string
        /// </summary>
        /// <param name="length">Length</param>
        /// <param name="characters">Characters</param>
        /// <returns>Randomized string</returns>
        public static string GetRandomString(uint length, string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz")
        {
            char[] ret = new char[length];
            if (characters.Length > 0)
            {
                Random rand = new Random();
                for (uint i = 0U; i != length; i++)
                {
                    ret[i] = characters[rand.Next(characters.Length)];
                }
            }
            return new string(ret);
        }

        /// <summary>
        /// Get thumbnail
        /// </summary>
        /// <param name="image">Image</param>
        /// <returns>Thumbnail</returns>
        public static Image GetThumbnail(Image image)
        {
            Bitmap ret = new Bitmap(GalleryImageSize.Width, GalleryImageSize.Height, PixelFormat.Format32bppArgb);
            Size sz = (image.Width >= image.Height) ? new Size(GalleryImageSize.Width, (int)(GalleryImageSize.Width * ((double)(image.Height) / image.Width))) : new Size(GalleryImageSize.Height, (int)(GalleryImageSize.Height * ((double)(image.Width) / image.Height)));
            Graphics g = Graphics.FromImage(ret);
            g.Clear(Color.Transparent);
            g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            g.DrawImage(image, new Rectangle(new Point((GalleryImageSize.Width - sz.Width) / 2, (GalleryImageSize.Height - sz.Height) / 2), sz), new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
            return ret;
        }
    }
}
