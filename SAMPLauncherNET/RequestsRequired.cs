namespace SAMPLauncherNET
{
    public class RequestsRequired
    {
        bool[] values = new bool[(int)(ERequestType.NumOfItems)] { true, true, true, true, true };

        static readonly char[] opCodes = new char[(int)(ERequestType.NumOfItems)] { 'p', 'i', 'r', 'c', 'd' };

        public bool this[ERequestType requestType]
        {
            get
            {
                return values[(int)requestType];
            }
            set
            {
                values[(int)requestType] = value;
            }
        }

        public static char GetOpCode(ERequestType requestType)
        {
            return opCodes[(int)requestType];
        }
    }
}
