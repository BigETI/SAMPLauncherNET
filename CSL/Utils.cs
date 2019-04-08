using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows;
using Ude;

/// <summary>
/// Community San Andreas Multiplayer Launcher namespace
/// </summary>
namespace CSL
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
        /// Charset detector
        /// </summary>
        private static readonly CharsetDetector charsetDetector = new CharsetDetector();

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
        /// Guessed string encoding
        /// </summary>
        /// <param name="bytes">Bytes to encode</param>
        /// <returns>Encoded string</returns>
        public static string GuessedStringEncoding(byte[] bytes)
        {
            string ret = null;
            if (bytes != null)
            {
                charsetDetector.Reset();
                charsetDetector.Feed(bytes, 0, bytes.Length);
                charsetDetector.DataEnd();
                try
                {
                    string charset_name = charsetDetector.Charset;
                    if (charset_name != null)
                    {
                        Encoding encoding = Encoding.GetEncoding(charset_name);
                        if (encoding != null)
                        {
                            ret = encoding.GetString(bytes);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                }
                if (ret == null)
                {
                    try
                    {
                        ret = Encoding.Default.GetString(bytes);
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
                    }
                }
            }
            if (ret == null)
            {
                ret = "";
            }
            return ret;
        }

        /// <summary>
        /// Is file available
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Is available</returns>
        public static bool IsFileAvailable(string path)
        {
            bool ret = true;
            try
            {
                using (File.Open(path, FileMode.Open, FileAccess.Read))
                {
                    //
                }
            }
            catch (Exception e)
            {
                ret = false;
                Debug.WriteLine(e);
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
        /// Save text file
        /// </summary>
        /// <param name="fileName">File name</param>
        /// <param name="text">Text</param>
        public static bool SaveTextFile(string fileName, string text)
        {
            bool ret = false;
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.Write(text);
                    ret = true;
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
            }
            return ret;
        }

        /// <summary>
        /// Export resource
        /// </summary>
        /// <param name="resourceName">Resource name</param>
        /// <param name="destinationPath">Destination path</param>
        /// <returns>"true" if successful, otherwise "false"</returns>
        public static bool ExportResource(string resourceName, string destinationPath)
        {
            bool ret = false;
            try
            {
                if (File.Exists(destinationPath))
                {
                    File.Delete(destinationPath);
                }
                using (Stream resource_stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
                {
                    if (resource_stream != null)
                    {
                        using (Stream file_stream = File.OpenWrite(destinationPath))
                        {
                            resource_stream.CopyTo(file_stream);
                        }
                        ret = true;
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
            }
            return ret;
        }
    }
}
