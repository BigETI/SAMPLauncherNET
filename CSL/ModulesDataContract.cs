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
    }
}
