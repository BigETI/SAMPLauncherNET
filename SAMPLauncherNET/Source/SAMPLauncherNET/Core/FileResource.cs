/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// File resource class
    /// </summary>
    public class FileResource
    {
        /// <summary>
        /// Path
        /// </summary>
        private readonly string path;

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
        /// File name
        /// </summary>
        public string FileName
        {
            get
            {
                return System.IO.Path.GetFileName(path);
            }
        }

        /// <summary>
        /// File name without extension
        /// </summary>
        public string FileNameWithoutExtension
        {
            get
            {
                return System.IO.Path.GetFileNameWithoutExtension(path);
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="path">Path</param>
        public FileResource(string path)
        {
            this.path = path;
        }

        /// <summary>
        /// To string
        /// </summary>
        /// <returns>String representation</returns>
        public override string ToString()
        {
            return FileNameWithoutExtension;
        }
    }
}
