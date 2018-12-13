using SAMPLauncherNETUpdater.UI;
using System;
using System.Windows.Forms;

/// <summary>
/// SA:MP launcher .NET updater namespace
/// </summary>
namespace SAMPLauncherNETUpdater
{
    /// <summary>
    /// Program class
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Main entry point
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
