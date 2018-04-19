/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Chatlog format type enumerator
    /// </summary>
    public enum EChatlogFormatType
    {
        /// <summary>
        /// Plain text
        /// </summary>
        /// <remarks>
        /// Coloring is not supported
        /// </remarks>
        Plain,

        /// <summary>
        /// Rich text format
        /// </summary>
        RTF,

        /// <summary>
        /// HTML snippet
        /// </summary>
        HTMLSnippet,

        /// <summary>
        /// HTML document
        /// </summary>
        HTML
    }
}
