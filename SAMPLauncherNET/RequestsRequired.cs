using System;

namespace SAMPLauncherNET
{
    public class RequestsRequired
    {
        bool[] values;

        bool[] locked;

        DateTime[] lastRequestTime;

        static readonly char[] opCodes = new char[(int)(ERequestType.NumOfItems)] { 'p', 'i', 'r', 'c', 'd' };

        public bool this[ERequestType requestType]
        {
            get
            {
                return values[(int)requestType];
            }
            set
            {
                if (!(locked[(int)requestType]))
                    values[(int)requestType] = value;
            }
        }

        public static char GetOpCode(ERequestType requestType)
        {
            return opCodes[(int)requestType];
        }

        public RequestsRequired(bool initialValue = true)
        {
            int i;
            DateTime now = DateTime.Now;
            values = new bool[(int)(ERequestType.NumOfItems)];
            lastRequestTime = new DateTime[values.Length];
            locked = new bool[values.Length];
            for (i = 0; i < values.Length; i++)
            {
                values[i] = initialValue;
                lastRequestTime[i] = now;
                locked[i] = false;
            }
        }

        public DateTime GetLastRequestTime(ERequestType requestType)
        {
            return lastRequestTime[(int)requestType];
        }

        public void SetLastRequestTime(ERequestType requestType)
        {
            lastRequestTime[(int)requestType] = DateTime.Now;
        }

        public void Lock(ERequestType requestType)
        {
            locked[(int)requestType] = true;
        }
    }
}
