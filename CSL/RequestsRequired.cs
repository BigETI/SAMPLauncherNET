using CSLPI;
using System;

/// <summary>
/// Community San Andreas Multiplayer Launcher namespace
/// </summary>
namespace CSL
{
    /// <summary>
    /// Requests required class
    /// </summary>
    public class RequestsRequired
    {
        /// <summary>
        /// Request type count
        /// </summary>
        private static readonly int requestTypeCount = Enum.GetValues(typeof(ERequestResponseType)).Length;

        /// <summary>
        /// Values
        /// </summary>
        private readonly bool[] values;

        /// <summary>
        /// Available
        /// </summary>
        private readonly bool[] available;

        /// <summary>
        /// Last request time
        /// </summary>
        private readonly DateTime[] lastRequestTime;

        /// <summary>
        /// Operation codes
        /// </summary>
        private static readonly char[] opCodes = new[] { 'p', 'i', 'r', 'c', 'd' };

        /// <summary>
        /// Array element access operator
        /// </summary>
        /// <param name="requestType">Request type</param>
        /// <returns>Request required</returns>
        public bool this[ERequestResponseType requestType]
        {
            get
            {
                return values[(int)requestType];
            }
            set
            {
                if (available[(int)requestType])
                {
                    values[(int)requestType] = value;
                }
            }
        }

        /// <summary>
        /// Get operation code
        /// </summary>
        /// <param name="requestType">Request type</param>
        /// <returns>Operation code</returns>
        public static char GetOpCode(ERequestResponseType requestType)
        {
            return opCodes[(int)requestType];
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="initialValue">Initial value</param>
        public RequestsRequired(bool initialValue)
        {
            int i;
            DateTime now = DateTime.Now;
            values = new bool[requestTypeCount];
            lastRequestTime = new DateTime[values.Length];
            available = new bool[values.Length];
            for (i = 0; i < values.Length; i++)
            {
                values[i] = initialValue;
                lastRequestTime[i] = now;
                available[i] = true;
            }
        }

        /// <summary>
        /// Get last request time
        /// </summary>
        /// <param name="requestType">Request type</param>
        /// <returns>Last request time</returns>
        public DateTime GetLastRequestTime(ERequestResponseType requestType)
        {
            return lastRequestTime[(int)requestType];
        }

        /// <summary>
        /// Set last request time
        /// </summary>
        /// <param name="requestType">Request type</param>
        public void SetLastRequestTime(ERequestResponseType requestType)
        {
            lastRequestTime[(int)requestType] = DateTime.Now;
        }

        /// <summary>
        /// Lock
        /// </summary>
        /// <param name="requestType">Request type</param>
        public void Lock(ERequestResponseType requestType)
        {
            available[(int)requestType] = false;
            values[(int)requestType] = false;
        }
    }
}
