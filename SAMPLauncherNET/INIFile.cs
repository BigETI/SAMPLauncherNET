using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace SAMPLauncherNET
{
    public class INIFile
    {
        private string path;

        private string exeFileName = Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public INIFile(string iniFile)
        {
            path = new FileInfo(iniFile).FullName.ToString();
        }

        public string Read(string Key, string Section = null, string DefaultValue = "")
        {
            StringBuilder ret = new StringBuilder(255);
            GetPrivateProfileString(Section ?? exeFileName, Key, "", ret, 255, path);
            return ret.ToString();
        }

        public bool ReadBool(string Key, bool DefaultValue = false, string Section = null)
        {
            bool ret = false;
            string v = Read(Key, DefaultValue.ToString(), Section);
            if (!(bool.TryParse(v, out ret)))
            {
                int iv = 0;
                if (int.TryParse(v, out iv))
                    ret = iv != 0;
                else
                    ret = DefaultValue;
            }
            return ret;
        }

        public int ReadInt(string Key, int DefaultValue = 0, string Section = null)
        {
            int ret = 0;
            if (!(int.TryParse(Read(Key, DefaultValue.ToString(), Section), out ret)))
                ret = DefaultValue;
            return ret;
        }

        public long ReadLong(string Key, long DefaultValue = 0, string Section = null)
        {
            long ret = 0;
            if (!(long.TryParse(Read(Key, DefaultValue.ToString(), Section), out ret)))
                ret = DefaultValue;
            return ret;
        }

        public float ReadFloat(string Key, float DefaultValue = 0.0f, string Section = null)
        {
            float ret = 0.0f;
            if (!(float.TryParse(Read(Key, DefaultValue.ToString(), Section), out ret)))
                ret = DefaultValue;
            return ret;
        }

        public double ReadDouble(string Key, double DefaultValue = 0.0, string Section = null)
        {
            double ret = 0.0;
            if (!(double.TryParse(Read(Key, DefaultValue.ToString(), Section), out ret)))
                ret = DefaultValue;
            return ret;
        }

        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? exeFileName, Key, Value, path);
        }

        public void WriteBool(string Key, bool Value, bool numeric = false, string Section = null)
        {
            if (numeric)
                Write(Key, (Value ? 1 : 0).ToString(), Section);
            else
                Write(Key, Value.ToString(), Section);
        }

        public void WriteInt(string Key, int Value, string Section = null)
        {
            Write(Key, Value.ToString(), Section);
        }

        public void WriteLong(string Key, long Value, string Section = null)
        {
            Write(Key, Value.ToString(), Section);
        }

        public void WriteFloat(string Key, float Value, string Section = null)
        {
            Write(Key, Value.ToString(), Section);
        }

        public void WriteDouble(string Key, double Value, string Section = null)
        {
            Write(Key, Value.ToString(), Section);
        }

        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? exeFileName);
        }

        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? exeFileName);
        }

        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }
    }
}
