using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WinFormsTranslator;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// SA:MP class
    /// </summary>
    public static class SAMP
    {
        /// <summary>
        /// Registry key
        /// </summary>
        public static readonly string RegistryKey = "HKEY_CURRENT_USER\\SOFTWARE\\SAMP";

        /// <summary>
        /// Configuration path
        /// </summary>
        public static readonly string ConfigPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\GTA San Andreas User Files\\SAMP";

        /// <summary>
        /// Executable directory
        /// </summary>
        public static readonly string ExeDir = GTASAExe.Substring(0, GTASAExe.Length - 11);

        /// <summary>
        /// SA:MP DLL path
        /// </summary>
        public static readonly string SAMPDLLPath = ExeDir + "\\samp.dll";

        /// <summary>
        /// SA:MP debug path
        /// </summary>
        public static readonly string SAMPDebugPath = ExeDir + "\\samp_debug.exe";

        /// <summary>
        /// Launcher config path
        /// </summary>
        public static readonly string LauncherConfigPath = "./config.json";

        /// <summary>
        /// Server list API path
        /// </summary>
        public static readonly string ServerListAPIPath = "./api.json";

        /// <summary>
        /// Plugins data path
        /// </summary>
        public static readonly string PluginsDataPath = "./plugins.json";

        /// <summary>
        /// Developer tools config file name
        /// </summary>
        public static readonly string DeveloperToolsConfigFileName = "samp.json";

        /// <summary>
        /// Gallery path
        /// </summary>
        public static readonly string GalleryPath = ConfigPath + "\\screens";

        /// <summary>
        /// Chatlog path
        /// </summary>
        public static readonly string ChatlogPath = ConfigPath + "\\chatlog.txt";

        /// <summary>
        /// Saved positions path
        /// </summary>
        public static readonly string SavedPositionsPath = ConfigPath + "\\savedpositions.txt";

        /// <summary>
        /// SA:MP configuration path
        /// </summary>
        public static readonly string SAMPConfigPath = ConfigPath + "\\sa-mp.cfg";

        /// <summary>
        /// Favourites path
        /// </summary>
        public static readonly string FavouritesPath = ".\\favourites.json";

        /// <summary>
        /// Legacy favourites path
        /// </summary>
        public static readonly string LegacyFavouritesPath = ConfigPath + "\\USERDATA.DAT";

        /// <summary>
        /// Forums URL
        /// </summary>
        public static readonly string ForumsURL = "http://forum.sa-mp.com/index.php";

        /// <summary>
        /// GitHub project URL
        /// </summary>
        public static readonly string GitHubProjectURL = "https://github.com/BigETI/SAMPLauncherNET";

        /// <summary>
        /// Launcher configuration serializer
        /// </summary>
        public static readonly DataContractJsonSerializer launcherConfigSerializer = new DataContractJsonSerializer(typeof(LauncherConfigDataContract));

        /// <summary>
        /// API serializer
        /// </summary>
        public static readonly DataContractJsonSerializer apiSerializer = new DataContractJsonSerializer(typeof(APIDataContract[]));

        /// <summary>
        /// Plugins data serializer
        /// </summary>
        public static readonly DataContractJsonSerializer pluginsDataSerializer = new DataContractJsonSerializer(typeof(PluginDataContract[]));

        /// <summary>
        /// Developer tools serializer
        /// </summary>
        public static readonly DataContractJsonSerializer developerToolsConfigSerializer = new DataContractJsonSerializer(typeof(DeveloperToolsConfigDataContract));

        /// <summary>
        /// API
        /// </summary>
        public static List<ServerListConnector> api;

        /// <summary>
        /// Plugins data
        /// </summary>
        public static PluginDataContract[] pluginsData;

        /// <summary>
        /// Last server process
        /// </summary>
        private static Process lastServerProcess;

        /// <summary>
        /// Last media state
        /// </summary>
        private static MediaState lastMediaState;

        /// <summary>
        /// Last session data
        /// </summary>
        private static SessionDataContract lastSessionData;

        /// <summary>
        /// Last media state
        /// </summary>
        public static MediaState LastMediaState
        {
            get
            {
                return lastMediaState;
            }
        }

        /// <summary>
        /// Last session data
        /// </summary>
        public static SessionDataContract LastSessionData
        {
            get
            {
                return lastSessionData;
            }
        }

        /// <summary>
        /// Username
        /// </summary>
        public static string Username
        {
            get
            {
                string ret = "";
                try
                {
                    ret = Registry.GetValue(RegistryKey, "PlayerName", "").ToString();
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                }
                return ret;
            }
            set
            {
                try
                {
                    Registry.SetValue(RegistryKey, "PlayerName", value);
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                }
            }
        }

        /// <summary>
        /// GTA San Andreas executable
        /// </summary>
        public static string GTASAExe
        {
            get
            {
                string ret = "";
                try
                {
                    ret = Registry.GetValue(RegistryKey, "gta_sa_exe", "").ToString();
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                }
                return ret;
            }
        }

        /// <summary>
        /// Is GTA San Andreas running
        /// </summary>
        public static bool IsGTASanAndreasRunning
        {
            get
            {
                Process[] processes = Process.GetProcessesByName("gta_sa");
                return ((processes == null) ? false : (processes.Length > 0));
            }
        }

        /// <summary>
        /// API I/O
        /// </summary>
        public static List<ServerListConnector> APIIO
        {
            get
            {
                if (api == null)
                {
                    api = new List<ServerListConnector>();
                    try
                    {
                        if (File.Exists(ServerListAPIPath))
                        {
                            using (FileStream stream = File.Open(ServerListAPIPath, FileMode.Open, FileAccess.Read))
                            {
                                APIDataContract[] api_arr = (APIDataContract[])(apiSerializer.ReadObject(stream));
                                foreach (APIDataContract apidc in api_arr)
                                {
                                    api.Add(new ServerListConnector(apidc));
                                }
                            }
                        }
                        else
                        {
                            api = RevertAPIs();
                        }
                    }
                    catch (Exception e)
                    {
                        api = RevertAPIs();
                        Console.Error.WriteLine(e);
                    }
                }
                return new List<ServerListConnector>(api);
            }
            set
            {
                if (value != null)
                {
                    APIDataContract[] api_arr = new APIDataContract[value.Count];
                    api = value;
                    for (int i = 0; i < api_arr.Length; i++)
                    {
                        api_arr[i] = api[i].APIDataContract;
                    }
                    try
                    {
                        using (FileStream stream = File.Open(ServerListAPIPath, FileMode.Create))
                        {
                            apiSerializer.WriteObject(stream, api_arr);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
                    }
                }
            }
        }

        /// <summary>
        /// Plugins data IO
        /// </summary>
        public static PluginDataContract[] PluginsDataIO
        {
            get
            {
                if (pluginsData == null)
                {
                    try
                    {
                        if (File.Exists(PluginsDataPath))
                        {
                            using (FileStream stream = File.Open(PluginsDataPath, FileMode.Open, FileAccess.Read))
                            {
                                pluginsData = pluginsDataSerializer.ReadObject(stream) as PluginDataContract[];
                            }
                        }
                        else
                        {
                            RevertPluginsData();
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
                    }
                }
                if (pluginsData == null)
                {
                    pluginsData = new PluginDataContract[0];
                    PluginsDataIO = pluginsData;
                }
                return pluginsData;
            }
            set
            {
                if (value != null)
                {
                    pluginsData = value;
                    try
                    {
                        if (File.Exists(PluginsDataPath))
                        {
                            File.Delete(PluginsDataPath);
                        }
                        using (FileStream stream = File.Open(PluginsDataPath, FileMode.Create))
                        {
                            pluginsDataSerializer.WriteObject(stream, pluginsData);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
                    }
                }
            }
        }

        /// <summary>
        /// Chatlog
        /// </summary>
        public static string Chatlog
        {
            get
            {
                string ret = "";
                try
                {
                    using (FileStream fs = File.Open(ChatlogPath, FileMode.Open, FileAccess.Read))
                    {
                        using (StreamReader sr = new StreamReader(fs, Encoding.Default))
                        {
                            ret = sr.ReadToEnd();
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                }
                return ret;
            }
        }

        /// <summary>
        /// Saved positions
        /// </summary>
        public static string SavedPositions
        {
            get
            {
                string ret = "";
                try
                {
                    using (FileStream fs = File.Open(SavedPositionsPath, FileMode.Open, FileAccess.Read))
                    {
                        using (StreamReader sr = new StreamReader(fs, Encoding.Default))
                        {
                            ret = sr.ReadToEnd();
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                }
                return ret;
            }
        }

        /// <summary>
        /// Launcher configuration I/O
        /// </summary>
        public static LauncherConfigDataContract LauncherConfigIO
        {
            get
            {
                LauncherConfigDataContract ret = null;
                if (File.Exists(LauncherConfigPath))
                {
                    try
                    {
                        using (StreamReader reader = new StreamReader(LauncherConfigPath))
                        {
                            ret = launcherConfigSerializer.ReadObject(reader.BaseStream) as LauncherConfigDataContract;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
                    }
                }
                if (ret == null)
                {
                    ret = new LauncherConfigDataContract();
                }
                return ret;
            }
            set
            {
                if (value != null)
                {
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(LauncherConfigPath))
                        {
                            launcherConfigSerializer.WriteObject(writer.BaseStream, value);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
                    }
                }
            }
        }

        /// <summary>
        /// SA:MP configuration
        /// </summary>
        public static SAMPConfig SAMPConfig
        {
            get
            {
                return new SAMPConfig(SAMPConfigPath);
            }
        }

        /// <summary>
        /// Developer tools config I/O
        /// </summary>
        public static DeveloperToolsConfigDataContract DeveloperToolsConfigIO
        {
            get
            {
                DeveloperToolsConfigDataContract ret = null;
                string path = Utils.AppendCharacterToString(LauncherConfigIO.DevelopmentDirectory, '\\') + DeveloperToolsConfigFileName;
                if (File.Exists(path))
                {
                    try
                    {
                        using (StreamReader reader = new StreamReader(path))
                        {
                            ret = developerToolsConfigSerializer.ReadObject(reader.BaseStream) as DeveloperToolsConfigDataContract;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
                    }
                }
                if (ret == null)
                {
                    ret = new DeveloperToolsConfigDataContract();
                }
                return ret;
            }
            set
            {
                if (value != null)
                {
                    try
                    {
                        string directory = Utils.AppendCharacterToString(LauncherConfigIO.DevelopmentDirectory, '\\');
                        if (!(Directory.Exists(directory)))
                        {
                            Directory.CreateDirectory(directory);
                        }
                        using (StreamWriter writer = new StreamWriter(directory + DeveloperToolsConfigFileName))
                        {
                            developerToolsConfigSerializer.WriteObject(writer.BaseStream, value);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
                    }
                }
            }
        }

        /// <summary>
        /// Check if GTA San Andreas is launchable
        /// </summary>
        public static bool CheckIfGTASanAndreasIsLaunchable
        {
            get
            {
                bool ret = true;
                if (IsGTASanAndreasRunning)
                {
                    ret = (MessageBox.Show(Utils.Translator.GetTranslation("GTA_SA_IS_RUNNING"), Utils.Translator.GetTranslation("GTA_SA_IS_RUNNING_TITLE"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes);
                    if (ret)
                    {
                        CloseGTASanAndreas();
                    }
                }
                return ret;
            }
        }

        /// <summary>
        /// Close GTA San Andreas
        /// </summary>
        public static void CloseGTASanAndreas()
        {
            Process[] processes = Process.GetProcessesByName("gta_sa");
            if (processes != null)
            {
                foreach (Process process in processes)
                {
                    try
                    {
                        process.Kill();
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
                    }
                }
            }
        }

        /// <summary>
        /// Revert APIs
        /// </summary>
        /// <returns>APIs</returns>
        public static List<ServerListConnector> RevertAPIs()
        {
            List<ServerListConnector> ret = null;
            try
            {
                using (WebClientEx wc = new WebClientEx(3000))
                {
                    wc.Headers.Set(HttpRequestHeader.Accept, "application/json");
                    wc.Headers.Set(HttpRequestHeader.UserAgent, "Mozilla/3.0 (compatible; SA:MP launcher .NET)");
                    try
                    {
                        using (MemoryStream stream = new MemoryStream(wc.DownloadData(GitHubProjectURL + "/master/api.json")))
                        {
                            APIDataContract[] api_arr = apiSerializer.ReadObject(stream) as APIDataContract[];
                            ret = new List<ServerListConnector>();
                            ret.Add(new ServerListConnector("{$SHOW_FAVOURITES$}", EServerListType.Favourites, FavouritesPath));
                            ret.Add(new ServerListConnector("{$SHOW_LEGACY_FAVOURITES$}", EServerListType.LegacyFavourites, LegacyFavouritesPath));
                            ret.Add(new ServerListConnector("{$SHOW_LEGACY_HOSTED_LIST$}", EServerListType.LegacySAMP, "{$HOSTED_LIST_URL$}"));
                            ret.Add(new ServerListConnector("{$SHOW_LEGACY_MASTER_LIST$}", EServerListType.LegacySAMP, "{$MASTER_LIST_URL$}"));
                            ret.Add(new ServerListConnector("{$SHOW_LEGACY_OFFICIAL_LIST$}", EServerListType.LegacySAMP, "{$OFFICIAL_LIST_URL$}"));
                            foreach (APIDataContract apidc in api_arr)
                            {
                                ret.Add(new ServerListConnector(apidc));
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
            }
            if (ret == null)
            {
                ret = new List<ServerListConnector>();
                ret.Add(new ServerListConnector("{$SHOW_FAVOURITES$}", EServerListType.Favourites, FavouritesPath));
                ret.Add(new ServerListConnector("{$SHOW_LEGACY_FAVOURITES$}", EServerListType.LegacyFavourites, LegacyFavouritesPath));
                ret.Add(new ServerListConnector("{$SHOW_LEGACY_HOSTED_LIST$}", EServerListType.LegacySAMP, "{$HOSTED_LIST_URL$}"));
                ret.Add(new ServerListConnector("{$SHOW_LEGACY_MASTER_LIST$}", EServerListType.LegacySAMP, "{$MASTER_LIST_URL$}"));
                ret.Add(new ServerListConnector("{$SHOW_LEGACY_OFFICIAL_LIST$}", EServerListType.LegacySAMP, "{$OFFICIAL_LIST_URL$}"));
                ret.Add(new ServerListConnector("{$SHOW_SOUTHCLAWS_LIST$}", EServerListType.BackendRESTful, "https://api.samp-servers.net/v2/servers"));
                ret.Add(new ServerListConnector("{$SHOW_SACNR_LIST$}", EServerListType.LegacySAMP, "http://monitor.sacnr.com/list/masterlist.txt"));
            }
            APIIO = ret;
            return ret;
        }

        /// <summary>
        /// Revert plugins data
        /// </summary>
        /// <returns>Plugins data</returns>
        public static PluginDataContract[] RevertPluginsData()
        {
            PluginDataContract[] ret = null;
            try
            {
                using (WebClientEx wc = new WebClientEx(3000))
                {
                    wc.Headers.Set(HttpRequestHeader.Accept, "application/json");
                    wc.Headers.Set(HttpRequestHeader.UserAgent, "Mozilla/3.0 (compatible; SA:MP launcher .NET)");
                    try
                    {
                        using (MemoryStream stream = new MemoryStream(wc.DownloadData(GitHubProjectURL + "/master/plugins.json")))
                        {
                            ret = pluginsDataSerializer.ReadObject(stream) as PluginDataContract[];
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
            }
            if (ret == null)
            {
                ret = new PluginDataContract[]
                {
                    new PluginDataContract("SA:MP Discord Rich Presence plugin", EPluginProvider.GitHub, "https://github.com/Hual/samp-discord-plugin", false, EUpdateFrequency.WhenNewer)
                };
            }
            PluginsDataIO = ret;
            return ret;
        }

        /// <summary>
        /// Inject plugin
        /// </summary>
        /// <param name="pluginPath">Plugin path</param>
        /// <param name="processHandle">Process handle</param>
        /// <param name="loadLibraryW">LoadLibraryW function pointer</param>
        private static void InjectPlugin(string pluginPath, IntPtr processHandle, IntPtr loadLibraryW)
        {
            if (File.Exists(pluginPath))
            {
                IntPtr ptr = Kernel32.VirtualAllocEx(processHandle, IntPtr.Zero, (uint)(pluginPath.Length + 1) * 2U, Kernel32.AllocationType.Reserve | Kernel32.AllocationType.Commit, Kernel32.MemoryProtection.ReadWrite);
                if (ptr != IntPtr.Zero)
                {
                    int nobw = 0;
                    byte[] p = Encoding.Unicode.GetBytes(pluginPath);
                    byte[] nt = Encoding.Unicode.GetBytes("\0");
                    if (Kernel32.WriteProcessMemory(processHandle, ptr, p, (uint)(p.Length), out nobw) && Kernel32.WriteProcessMemory(processHandle, new IntPtr(ptr.ToInt64() + p.LongLength), nt, (uint)(nt.Length), out nobw))
                    {
                        uint tid = 0U;
                        IntPtr rt = Kernel32.CreateRemoteThread(processHandle, IntPtr.Zero, 0U, loadLibraryW, ptr, /* CREATE_SUSPENDED */ 0x4, out tid);
                        if (rt != IntPtr.Zero)
                        {
                            Kernel32.ResumeThread(rt);
                            unchecked
                            {
                                Kernel32.WaitForSingleObject(rt, (uint)(Timeout.Infinite));
                            }
                        }
                    }
                    Kernel32.VirtualFreeEx(processHandle, ptr, 0, Kernel32.AllocationType.Release);
                }
            }
        }

        /// <summary>
        /// Launch SA:MP
        /// </summary>
        /// <param name="server">Server</param>
        /// <param name="username">Username</param>
        /// <param name="serverPassword">Server password</param>
        /// <param name="rconPassword">RCON password</param>
        /// <param name="debug">Debug mode</param>
        /// <param name="quitWhenDone">Quit when done</param>
        /// <param name="createSessionLog">Create session log</param>
        /// <param name="plugins">Plugins</param>
        /// <param name="f">Form to close</param>
        public static void LaunchSAMP(Server server, string username, string serverPassword, string rconPassword, bool debug, bool quitWhenDone, bool createSessionLog, PluginDataContract[] plugins, Form f)
        {
            if ((server != null) || debug)
            {
                if (debug || server.IsValid)
                {
                    IntPtr mh = Kernel32.GetModuleHandle("kernel32.dll");
                    if (mh != IntPtr.Zero)
                    {
                        IntPtr load_library_w = Kernel32.GetProcAddress(mh, "LoadLibraryW");
                        if (load_library_w != IntPtr.Zero)
                        {
                            Kernel32.PROCESS_INFORMATION process_info;
                            Kernel32.STARTUPINFO startup_info = new Kernel32.STARTUPINFO();
                            if (CheckIfGTASanAndreasIsLaunchable)
                            {
                                string modified_username = ((username == null) ? "" : username.Trim().Replace(' ', '_'));
                                if (createSessionLog)
                                {
                                    lastMediaState = SessionProvider.GetCurrentMediaState();
                                    lastSessionData = new SessionDataContract(DateTime.Now, TimeSpan.Zero, SAMPProvider.CurrentVersion.Name, modified_username, (server == null) ? "" : server.IPPortString, (server == null) ? "" : server.Hostname, (server == null) ? "" : server.Gamemode, (server == null) ? "" : server.Language);
                                }
                                if (Kernel32.CreateProcess(GTASAExe, debug ? "-d" : "-c " + ((rconPassword == null) ? "" : rconPassword) + " -h " + server.IPv4AddressString + " -p " + server.Port + " -n " + modified_username + ((serverPassword == null) ? "" : (" -z " + serverPassword)), IntPtr.Zero, IntPtr.Zero, false, /* DETACHED_PROCESS */ 0x8 | /* CREATE_SUSPENDED */ 0x4, IntPtr.Zero, ExeDir, ref startup_info, out process_info))
                                {
                                    InjectPlugin(SAMPDLLPath, process_info.hProcess, load_library_w);
                                    PluginDataContract[] load_plugins = ((plugins == null) ? PluginsDataIO : plugins);
                                    foreach (PluginDataContract plugin in load_plugins)
                                    {
                                        if (plugin != null)
                                        {
                                            if (plugin.Enabled)
                                            {
                                                InstalledPlugin installed_plugin = PluginProvider.Update(plugin);
                                                if (installed_plugin != null)
                                                {
                                                    InjectPlugin(installed_plugin.Path, process_info.hProcess, load_library_w);
                                                }
                                            }
                                        }
                                    }
                                    Kernel32.ResumeThread(process_info.hThread);
                                    Kernel32.CloseHandle(process_info.hProcess);
                                    if ((f != null))
                                    {
                                        if (quitWhenDone && (!createSessionLog))
                                        {
                                            f.Close();
                                        }
                                        f.WindowState = FormWindowState.Minimized;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Close last server
        /// </summary>
        public static void CloseLastServer()
        {
            if (lastServerProcess != null)
            {
                try
                {
                    lastServerProcess.CloseMainWindow();
                    lastServerProcess = null;
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                }
            }
        }

        /// <summary>
        /// Launch SA:MP server
        /// </summary>
        public static void LaunchSAMPServer()
        {
            LauncherConfigDataContract lcdc = LauncherConfigIO;
            if (File.Exists("sampctl.exe"))
            {
                try
                {
                    CloseLastServer();
                    ProcessStartInfo process_start_info = new ProcessStartInfo(Path.Combine(Directory.GetCurrentDirectory(), "sampctl.exe"), "server run");
                    process_start_info.WorkingDirectory = lcdc.DevelopmentDirectory;
                    lastServerProcess = Process.Start(process_start_info);
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (MessageBox.Show(string.Format(Utils.Translator.GetTranslation("SAMPCTL_MISSING"), SAMPCTLProvider.SAMPCTLURI), Utils.Translator.GetTranslation("SAMPCTL_MISSING_TITLE"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        Process.Start(SAMPCTLProvider.SAMPCTLURI);
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
                    }
                }
            }
        }

        /// <summary>
        /// Launch SA:MP debug mode
        /// </summary>
        /// <param name="quitWhenDone">Quit when done</param>
        /// <param name="createSessionLog">Create session log</param>
        /// <param name="f">Form to close</param>
        public static void LaunchSAMPDebugMode(bool quitWhenDone, bool createSessionLog, Form f)
        {
            try
            {
                LaunchSAMP(null, "", null, null, true, quitWhenDone, createSessionLog, PluginsDataIO, f);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
            }
        }

        /// <summary>
        /// Change SA:MP version
        /// </summary>
        /// <param name="version">Version</param>
        /// <param name="useInstaller">Use installer</param>
        public static void ChangeSAMPVersion(SAMPVersionDataContract version, bool useInstaller)
        {
            if (version != null)
            {
                DownloadProgressForm dpf = new DownloadProgressForm(useInstaller ? version.InstallationURI : version.ZipURI, Path.GetFullPath("./downloads/" + (useInstaller ? "install.exe" : "client.zip")));
                if (dpf.ShowDialog() == DialogResult.OK)
                {
                    SAMPProvider.ResetVersionCache();
                    try
                    {
                        if (File.Exists(dpf.Path))
                        {
                            if (useInstaller)
                            {
                                Process.Start(dpf.Path);
                                Application.Exit();
                            }
                            else
                            {
                                using (ZipArchive archive = ZipFile.Open(dpf.Path, ZipArchiveMode.Read))
                                {
                                    foreach (ZipArchiveEntry entry in archive.Entries)
                                    {
                                        string path = ExeDir + "\\" + entry.FullName.Replace('/', '\\');
                                        try
                                        {
                                            using (Stream stream = entry.Open())
                                            {
                                                using (FileStream file_stream = new FileStream(path, FileMode.Create))
                                                {
                                                    int b = -1;
                                                    while ((b = stream.ReadByte()) != -1)
                                                    {
                                                        file_stream.WriteByte((byte)b);
                                                    }
                                                }
                                            }
                                        }
                                        catch (Exception e)
                                        {
                                            Console.Error.WriteLine(e);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
                        MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Launch singleplayer mode
        /// </summary>
        /// <param name="quitWhenDone">Quit when done</param>
        /// <param name="f">Form tom close</param>
        public static void LaunchSingleplayerMode(bool quitWhenDone, Form f)
        {
            if (CheckIfGTASanAndreasIsLaunchable)
            {
                try
                {
                    Process.Start(GTASAExe);
                    if (quitWhenDone)
                    {
                        f.Close();
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                }
            }
        }

        /// <summary>
        /// Show gallery
        /// </summary>
        public static void ShowGallery()
        {
            try
            {
                Process.Start("explorer.exe", GalleryPath);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
            }
        }

        /// <summary>
        /// Gallery image paths
        /// </summary>
        public static string[] GalleryImagePaths
        {
            get
            {
                return Directory.GetFiles(GalleryPath, "*.png");
            }
        }

        /// <summary>
        /// Open forums
        /// </summary>
        public static void OpenForums()
        {
            try
            {
                Process.Start(ForumsURL);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
            }
        }

        /// <summary>
        /// Open GitHub project
        /// </summary>
        public static void OpenGitHubProject()
        {
            try
            {
                Process.Start(GitHubProjectURL);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
            }
        }
    }
}
