using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Forms;
using WinFormsTranslator;

namespace SAMPLauncherNET
{
    static class Program
    {
        // Dirty
        private const string RegistryKey = "HKEY_CURRENT_USER\\SOFTWARE\\SAMP";

        private static readonly string ConfigPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\GTA San Andreas User Files\\SAMP";

        public static bool IsSAMPInstalled
        {
            get
            {
                bool ret = false;
                try
                {
                    ret = (Registry.GetValue(RegistryKey, "gta_sa_exe", null) != null) && (Registry.GetValue(RegistryKey, "PlayerName", null) != null) && Directory.Exists(ConfigPath);
                }
                catch
                {
                    //
                }
                return ret;
            }
        }

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Translator.TranslatorInterface = new TranslatorInterface();
                if (IsSAMPInstalled)
                {
                    if (!Directory.Exists(ConfigPath + "\\screens"))
                        Directory.CreateDirectory(ConfigPath + "\\screens");
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainForm());
                }
                else
                    MessageBox.Show("San Andreas Multiplayer is not installed.\r\nTo use this application, you have to install GTA San Andreas and San Andreas Multiplayer first.", "San Andreas Multiplayer is not installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show("A fatal error has occured:\r\n\r\n" + e.Message, "Fatal error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Application.Exit();
        }
    }
}
