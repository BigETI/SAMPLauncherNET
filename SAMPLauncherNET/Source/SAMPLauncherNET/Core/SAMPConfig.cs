using INIEngine;
using System.IO;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// SA:MP configuration class
    /// </summary>
    public class SAMPConfig
    {
        /// <summary>
        /// Path
        /// </summary>
        private readonly string path;

        /// <summary>
        /// INI
        /// </summary>
        private readonly INI ini;

        /// <summary>
        /// Page size
        /// </summary>
        public int PageSize
        {
            get
            {
                return ini.GetInt32("pagesize", 10);
            }
            set
            {
                ini.SetValue("pagesize", value);
            }
        }

        /// <summary>
        /// FPS limit
        /// </summary>
        public int FPSLimit
        {
            get
            {
                int ret = ini.GetInt32("fpslimit", 50);
                if (ret < 20)
                {
                    ret = 20;
                }
                else if (ret > 90)
                {
                    ret = 90;
                }
                return ret;
            }
            set
            {
                int v = value;
                if (v < 20)
                {
                    v = 20;
                }
                else if (v > 90)
                {
                    v = 90;
                }
                ini.SetValue("fpslimit", v);
            }
        }

        /// <summary>
        /// Disable head movement
        /// </summary>
        public bool DisableHeadMovement
        {
            get
            {
                return ini.GetBool("disableheadmove", false);
            }
            set
            {
                ini.SetValue("disableheadmove", value ? 1 : 0);
            }
        }

        /// <summary>
        /// Time stamp
        /// </summary>
        public bool Timestamp
        {
            get
            {
                return ini.GetBool("timestamp");
            }
            set
            {
                ini.SetValue("timestamp", value ? 1 : 0);
            }
        }

        /// <summary>
        /// IME
        /// </summary>
        public bool IME
        {
            get
            {
                return ini.GetBool("ime");
            }
            set
            {
                ini.SetValue("ime", value ? 1 : 0);
            }
        }

        /// <summary>
        /// Multi core
        /// </summary>
        public bool MultiCore
        {
            get
            {
                return ini.GetBool("multicore", true);
            }
            set
            {
                ini.SetValue("multicore", value ? 1 : 0);
            }
        }

        /// <summary>
        /// Direct mode
        /// </summary>
        public bool DirectMode
        {
            get
            {
                return ini.GetBool("directmode", false);
            }
            set
            {
                ini.SetValue("directmode", value ? 1 : 0);
            }
        }

        /// <summary>
        /// Audio message off
        /// </summary>
        public bool AudioMessageOff
        {
            get
            {
                return ini.GetBool("audiomsgoff", false);
            }
            set
            {
                ini.SetValue("audiomsgoff", value ? 1 : 0);
            }
        }

        /// <summary>
        /// Audio proxy off
        /// </summary>
        public bool AudioProxyOff
        {
            get
            {
                return ini.GetBool("audioproxyoff", false);
            }
            set
            {
                ini.SetValue("audiomsgoff", value ? 1 : 0);
            }
        }

        /// <summary>
        /// No nametag status
        /// </summary>
        public bool NoNametagStatus
        {
            get
            {
                return ini.GetBool("nonametagstatus", false);
            }
            set
            {
                ini.SetValue("nonametagstatus", value ? 1 : 0);
            }
        }

        /// <summary>
        /// Font face
        /// </summary>
        public string FontFace
        {
            get
            {
                return ini.GetString("fontface");
            }
            set
            {
                ini.SetString("fontface", value);
            }
        }

        /// <summary>
        /// Font weight
        /// </summary>
        public bool FontWeight
        {
            get
            {
                return ini.GetBool("fontweight", false);
            }
            set
            {
                ini.SetValue("fontweight", value ? 1 : 0);
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="path">Path</param>
        public SAMPConfig(string path)
        {
            this.path = path;
            if (!(File.Exists(path)))
            {
                using (StreamWriter stream = new StreamWriter(path))
                {
                    stream.WriteLine("pagesize=10");
                    stream.WriteLine("fpslimit=50");
                    stream.WriteLine("disableheadmove=0");
                    stream.WriteLine("timestamp=0");
                    stream.WriteLine("ime=0");
                    stream.WriteLine("multicore=1");
                    stream.WriteLine("directmode=0");
                    stream.WriteLine("audiomsgoff=0");
                    stream.WriteLine("nonametagstatus=0");
                    stream.WriteLine("fontweight=0");
                    stream.WriteLine("audioproxyoff=0");
                }
            }
            ini = INIFile.Open(path);
        }

        /// <summary>
        /// Save
        /// </summary>
        public void Save()
        {
            try
            {
                using (FileStream fs = File.Open(path, FileMode.Create))
                {
                    Stream s = ini.ToStream();
                    s.CopyTo(fs);
                }
            }
            catch
            {
                //
            }
        }
    }
}
