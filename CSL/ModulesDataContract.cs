using System.Runtime.Serialization;

/// <summary>
/// Community San Andreas Multiplayer Launcher namespace
/// </summary>
namespace CSL
{
    /// <summary>
    /// Modules data contract class
    /// </summary>
    [DataContract]
    internal class ModulesDataContract
    {
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        private string name;

        /// <summary>
        /// Author
        /// </summary>
        [DataMember]
        private string author;

        /// <summary>
        /// URL
        /// </summary>
        [DataMember]
        private string url;

        /// <summary>
        /// Path
        /// </summary>
        [DataMember]
        private string path;

        /// <summary>
        /// Is enabled
        /// </summary>
        [DataMember]
        private bool isEnabled;

        /// <summary>
        /// Name
        /// </summary>
        public string Name
        {
            get
            {
                if (name == null)
                {
                    name = "";
                }
                return name;
            }
        }

        /// <summary>
        /// Author
        /// </summary>
        public string Author
        {
            get
            {
                if (author == null)
                {
                    author = "";
                }
                return author;
            }
        }

        /// <summary>
        /// URL
        /// </summary>
        public string URL
        {
            get
            {
                if (url == null)
                {
                    url = "";
                }
                return url;
            }
        }

        /// <summary>
        /// Path
        /// </summary>
        public string Path
        {
            get
            {
                if (path == null)
                {
                    path = "";
                }
                return path;
            }
        }

        /// <summary>
        /// Is enabled
        /// </summary>
        public bool IsEnabled
        {
            get
            {
                return isEnabled;
            }
        }
    }
}
