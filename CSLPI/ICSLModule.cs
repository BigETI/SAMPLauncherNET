/// <summary>
/// Community San Andreas Multiplayer Launcher programming interface namespace
/// </summary>
namespace CSLPI
{
    /// <summary>
    /// Community San Andreas Multiplayer Launcher module interface
    /// </summary>
    public interface ICSLModule
    {
        /// <summary>
        /// Community San Andreas Multiplayer Launcher module configuration
        /// </summary>
        ACSLConfiguration ModuleConfiguration { get; }

        /// <summary>
        /// Initialize module
        /// </summary>
        /// <param name="csl">Community San Andreas Multiplayer Launcher</param>
        void Init(ICSL csl);

        /// <summary>
        /// Exit module
        /// </summary>
        void Exit();
    }
}
