namespace SAMPLauncherNET
{
    public class SAMPConfig
    {

        private INIFile iniFile;

        public int PageSize
        {
            get
            {
                return iniFile.ReadInt("pagesize", 10);
            }
            set
            {
                iniFile.WriteInt("pagesize", value);
            }
        }

        public int FPSLimit
        {
            get
            {
                int ret = iniFile.ReadInt("fpslimit", 50);
                if (ret < 20)
                    ret = 20;
                else if (ret > 90)
                    ret = 90;
                return ret;
            }
            set
            {
                if (value < 20)
                    value = 20;
                else if (value > 90)
                    value = 90;
                iniFile.WriteInt("fpslimit", value);
            }
        }

        public bool DisableHeadMovement
        {
            get
            {
                return iniFile.ReadBool("disableheadmove", false);
            }
            set
            {
                iniFile.WriteBool("disableheadmove", value, true);
            }
        }

        public bool Timestamp
        {
            get
            {
                return iniFile.ReadBool("timestamp");
            }
            set
            {
                iniFile.WriteBool("timestamp", value, true);
            }
        }

        public bool IME
        {
            get
            {
                return iniFile.ReadBool("ime");
            }
            set
            {
                iniFile.WriteBool("ime", value, true);
            }
        }

        public bool MultiCore
        {
            get
            {
                return iniFile.ReadBool("multicore", true);
            }
            set
            {
                iniFile.WriteBool("multicore", value, true);
            }
        }

        public bool DirectMode
        {
            get
            {
                return iniFile.ReadBool("directmode", false);
            }
            set
            {
                iniFile.WriteBool("directmode", value, true);
            }
        }

        public bool AudioMessageOff
        {
            get
            {
                return iniFile.ReadBool("audiomsgoff", false);
            }
            set
            {
                iniFile.WriteBool("audiomsgoff", value, true);
            }
        }

        public bool AudioProxyOff
        {
            get
            {
                return iniFile.ReadBool("audioproxyoff", false);
            }
            set
            {
                iniFile.WriteBool("audiomsgoff", value, true);
            }
        }

        public bool NoNametagStatus
        {
            get
            {
                return iniFile.ReadBool("nonametagstatus", false);
            }
            set
            {
                iniFile.WriteBool("nonametagstatus", value, true);
            }
        }

        public string FontFace
        {
            get
            {
                return iniFile.Read("fontface");
            }
            set
            {
                iniFile.Write("fontface", value);
            }
        }

        public bool FontWeight
        {
            get
            {
                return iniFile.ReadBool("fontweight", false);
            }
            set
            {
                iniFile.WriteBool("fontweight", value, true);
            }
        }

        public SAMPConfig(INIFile iniFile)
        {
            this.iniFile = iniFile;
        }
    }
}
