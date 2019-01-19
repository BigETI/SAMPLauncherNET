/// <summary>
/// Community San Andreas Multiplayer Launcher programming interface namespace
/// </summary>
namespace CSLPI
{
    /// <summary>
    /// Community San Andreas Multiplayer Launcher interface
    /// </summary>
    public interface ICSL
    {
        /// <summary>
        /// Community San Andreas Multiplayer launcher modules
        /// </summary>
        ICSLModule[] Modules { get; }

        /// <summary>
        /// Community San Andreas Multiplayer launcher modules
        /// </summary>
        ICSLPage[] Pages { get; }

        /// <summary>
        /// Global configuration
        /// </summary>
        ACSLConfiguration GlobalConfiguration { get; }

        /// <summary>
        /// Get Community San Andreas Multiplayer launcher modules by name
        /// </summary>
        /// <param name="modulesName">Modules name</param>
        /// <returns>Community San Andreas Multiplayer launcher modules</returns>
        ICSLModule[] GetModulesByName(string modulesName);

        /// <summary>
        /// Get Community San Andreas Multiplayer launcher pages by name
        /// </summary>
        /// <param name="pagesName">Modules name</param>
        /// <returns>Community San Andreas Multiplayer launcher pages</returns>
        ICSLPage[] GetPagesByName(string pagesName);
    }
}
