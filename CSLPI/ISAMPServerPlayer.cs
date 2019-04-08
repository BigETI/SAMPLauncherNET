/// <summary>
/// Community San Andreas Multiplayer Launcher programming interface namespace
/// </summary>
namespace CSLPI
{
    /// <summary>
    /// San Andreas Multiplayer server player interface
    /// </summary>
    public interface ISAMPServerPlayer
    {
        /// <summary>
        /// ID
        /// </summary>
        byte ID { get; }

        /// <summary>
        /// Name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Score
        /// </summary>
        int Score { get; }

        /// <summary>
        /// Ping
        /// </summary>
        uint Ping { get; }
    }
}
