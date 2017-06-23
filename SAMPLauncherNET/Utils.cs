using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SAMPLauncherNET
{
    public static class Utils
    {

        public static readonly string APIHTTPURL = "http://lists.sa-mp.com/0.3.7/";

        public static readonly string APIHTTPContentType = "text/html";

        public static readonly string APIHTTPHost = "lists.sa-mp.com";

        public static readonly string APIHTTPAccept = "text/html, */*";

        public static readonly string APIHTTPUserAgent = "Mozilla/3.0 (compatible; SA:MP v0.3.7)";

        public static readonly string RegistryKey = "HKEY_CURRENT_USER\\SOFTWARE\\SAMP";

        public static readonly string ConfigPath = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Documents\\GTA San Andreas User Files\\SAMP";

        public static readonly string ExeDir = GTASAExe.Substring(0, GTASAExe.Length - 11);

        public static readonly string SAMPDLLPath = ExeDir + "\\samp.dll";

        public static readonly string SAMPDebugPath = ExeDir + "\\samp_debug.exe";

        public static readonly string GalleryPath = ConfigPath + "\\screens";

        public static readonly string ChatlogPath = ConfigPath + "\\chatlog.txt";

        public static readonly string SAMPConfigPath = ConfigPath + "\\sa-mp.cfg";

        public static readonly string ForumsURL = "http://forum.sa-mp.com/index.php";

        public static readonly string GitHubProjectURL = "https://github.com/BigETI/SAMPLauncherNET";

        public static Dictionary<string, Server> FetchMasterList
        {
            get
            {
                return FetchIPList("servers");
            }
        }

        public static Dictionary<string, Server> FetchHostedList
        {
            get
            {
                return FetchIPList("hosted");
            }
        }

        public static string Username
        {
            get
            {
                string ret = "";
                try
                {
                    ret = Registry.GetValue(RegistryKey, "PlayerName", "").ToString();
                }
                catch
                {
                    //
                }
                return ret;
            }
            set
            {
                Registry.SetValue(RegistryKey, "PlayerName", value);
            }
        }

        public static string GTASAExe
        {
            get
            {
                string ret = "";
                try
                {
                    ret = Registry.GetValue(RegistryKey, "gta_sa_exe", "").ToString();
                }
                catch
                {
                    //
                }
                return ret;
            }
        }

        public static Dictionary<string, FavouriteServer> FavouritesIO
        {
            get
            {
                Dictionary<string, FavouriteServer> ret = new Dictionary<string, FavouriteServer>();
                try
                {
                    using (FileStream fs = File.Open(ConfigPath + "\\USERDATA.DAT", FileMode.Open))
                    {
                        using (BinaryReader reader = new BinaryReader(fs))
                        {
                            if (fs.Length >= 16)
                            {
                                string samp = new string(reader.ReadChars(4));
                                if (samp == "SAMP")
                                {
                                    if (reader.ReadUInt32() == 1U)
                                    {
                                        int sc = reader.ReadInt32();
                                        for (int i = 0; i < sc; i++)
                                        {
                                            string ip = new string(reader.ReadChars(reader.ReadInt32()));
                                            ushort port = (ushort)(reader.ReadUInt32());
                                            string cn = new string(reader.ReadChars(reader.ReadInt32()));
                                            string sp = new string(reader.ReadChars(reader.ReadInt32()));
                                            string rp = new string(reader.ReadChars(reader.ReadInt32()));
                                            ip = ip + ":" + port;
                                            FavouriteServer s = new FavouriteServer(ip, cn, sp, rp);
                                            if (s.IsValid)
                                                ret.Add(ip, s);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return ret;
            }
            set
            {
                if (value != null)
                {
                    try
                    {
                        using (FileStream fs = File.Open(Environment.GetEnvironmentVariable("USERPROFILE") + "\\Documents\\GTA San Andreas User Files\\SAMP\\USERDATA.DAT", FileMode.Create))
                        {
                            using (BinaryWriter writer = new BinaryWriter(fs))
                            {
                                writer.Write("SAMP");
                                writer.Write(1);
                                writer.Write(value.Count);
                                foreach (KeyValuePair<string, FavouriteServer> kv in value)
                                {
                                    writer.Write(kv.Key.Length);
                                    writer.Write(kv.Key);
                                    writer.Write(kv.Value.Port);
                                    string t = kv.Value.Hostname;
                                    writer.Write(t.Length);
                                    writer.Write(t);
                                    t = kv.Value.ServerPassword;
                                    writer.Write(t.Length);
                                    writer.Write(t);
                                    t = kv.Value.RCONPassword;
                                    writer.Write(t.Length);
                                    writer.Write(t);
                                }
                            }
                        }
                    }
                    catch
                    {
                        //
                    }
                }
            }
        }

        public static string Chatlog
        {
            get
            {
                string ret = "";
                try
                {
                    using (FileStream fs = File.Open(ChatlogPath, FileMode.Open))
                    {
                        using (StreamReader sr = new StreamReader(fs, Encoding.Default))
                        {
                            ret = sr.ReadToEnd();
                        }
                    }
                }
                catch
                {

                }
                return ret;
            }
        }

        public static SAMPConfig SAMPConfig
        {
            get
            {
                return new SAMPConfig(new INIFile(SAMPConfigPath));
            }
        }

        private static Dictionary<string, Server> FetchIPList(string listName)
        {
            Dictionary<string, Server> ret = new Dictionary<string, Server>();
            using (WebClient wc = new WebClient())
            {
                wc.Headers.Set(HttpRequestHeader.ContentType, APIHTTPContentType);
                wc.Headers.Set(HttpRequestHeader.Host, APIHTTPHost);
                wc.Headers.Set(HttpRequestHeader.Accept, APIHTTPAccept);
                wc.Headers.Set(HttpRequestHeader.UserAgent, APIHTTPUserAgent);
                string[] ips = wc.DownloadString(APIHTTPURL + listName).Split(new char[] { '\n' });
                foreach (string ip in ips)
                {
                    Server s = new Server(ip);
                    if (s.IsValid)
                        ret.Add(ip.Trim(), s);
                }
            }
            return ret;
        }

        public static void LaunchSAMP(Server server, string username, bool quitWhenDone, Form f)
        {
            if (server != null)
            {
                if (server.IsValid)
                {
                    IntPtr mh = Kernel32.GetModuleHandle("kernel32.dll");
                    if (mh != IntPtr.Zero)
                    {
                        IntPtr pa = Kernel32.GetProcAddress(mh, "LoadLibraryW");
                        if (pa != IntPtr.Zero)
                        {
                            Kernel32.PROCESS_INFORMATION process_info;
                            Kernel32.STARTUPINFO startup_info = new Kernel32.STARTUPINFO();
                            if (Kernel32.CreateProcess(GTASAExe, "-c -h " + server.IPv4AddressString + " -p " + server.Port + " -n " + username, IntPtr.Zero, IntPtr.Zero, false, /* DETACHED_PROCESS */ 0x8 | /* CREATE_SUSPENDED */ 0x4, IntPtr.Zero, ExeDir, ref startup_info, out process_info))
                            {
                                IntPtr ptr = Kernel32.VirtualAllocEx(process_info.hProcess, IntPtr.Zero, (uint)(SAMPDLLPath.Length + 1) * 2U, Kernel32.AllocationType.Reserve | Kernel32.AllocationType.Commit, Kernel32.MemoryProtection.ReadWrite);
                                if (ptr != IntPtr.Zero)
                                {
                                    int nobw = 0;
                                    byte[] p = Encoding.Unicode.GetBytes(SAMPDLLPath);
                                    byte[] nt = Encoding.Unicode.GetBytes("\0");
                                    if (Kernel32.WriteProcessMemory(process_info.hProcess, ptr, p, (uint)(p.Length), out nobw) && Kernel32.WriteProcessMemory(process_info.hProcess, new IntPtr(ptr.ToInt64() + p.LongLength), nt, (uint)(nt.Length), out nobw))
                                    {
                                        uint tid = 0U;
                                        IntPtr rt = Kernel32.CreateRemoteThread(process_info.hProcess, IntPtr.Zero, 0U, pa, ptr, /* CREATE_SUSPENDED */ 0x4, out tid);
                                        if (rt != IntPtr.Zero)
                                        {
                                            Kernel32.ResumeThread(rt);
                                            unchecked
                                            {
                                                Kernel32.WaitForSingleObject(rt, (uint)(Timeout.Infinite));
                                            }
                                        }
                                    }
                                    Kernel32.VirtualFreeEx(process_info.hProcess, ptr, 0, Kernel32.AllocationType.Release);
                                }
                                Kernel32.ResumeThread(process_info.hThread);
                                Kernel32.CloseHandle(process_info.hProcess);
                                if (quitWhenDone)
                                    f.Close();
                            }
                        }
                    }
                }
            }
        }

        public static void LaunchSAMPDebugMode(bool quitWhenDone, Form f)
        {
            try
            {
                Process.Start(SAMPDebugPath);
                if (quitWhenDone)
                    f.Close();
            }
            catch
            {
                //
            }
        }

        public static void LaunchSingleplayerMode(bool quitWhenDone, Form f)
        {
            try
            {
                Process.Start(GTASAExe);
                if (quitWhenDone)
                    f.Close();
            }
            catch
            {
                //
            }
        }

        public static void ShowGallery()
        {
            try
            {
                Process.Start("explorer.exe", GalleryPath);
            }
            catch
            {
                //
            }
        }

        public static void OpenForums()
        {
            try
            {
                Process.Start(ForumsURL);
            }
            catch
            {

            }
        }

        public static void OpenGitHubProject()
        {
            try
            {
                Process.Start(GitHubProjectURL);
            }
            catch
            {

            }
        }

        public static bool AreEqual<T>(T[] a, T[] b)
        {
            bool ret = false;
            if ((a != null) && (b != null))
            {
                if (a.Length == b.Length)
                {
                    ret = true;
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (!(a[i].Equals(b[i])))
                        {
                            ret = false;
                            break;
                        }
                    }
                }
            }
            return ret;
        }

        public static void DisposeAll(IDisposable[] list)
        {
            if (list != null)
            {
                foreach (IDisposable i in list)
                {
                    if (i != null)
                        i.Dispose();
                }
            }
        }
    }
}
