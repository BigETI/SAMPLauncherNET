using CSLPI;

/// <summary>
/// Community San Andreas Multiplayer Launcher namespace
/// </summary>
namespace CSL
{
    /// <summary>
    /// Server response delegate
    /// </summary>
    /// <param name="server">San Andreas Multiplayer server</param>
    /// <param name="responseType">Response type</param>
    public delegate void SAMPServerResponseDelegate(SAMPServer server, ERequestResponseType responseType);
}
