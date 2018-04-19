/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Update frequency enumerator
    /// </summary>
    public enum EUpdateFrequency
    {
        /// <summary>
        /// If missing
        /// </summary>
        IfMissing,

        /// <summary>
        /// When newer
        /// </summary>
        /// <remarks>
        /// Only works with GitHub provider
        /// </remarks>
        WhenNewer,

        /// <summary>
        /// Always at launch
        /// </summary>
        Always
    }
}
