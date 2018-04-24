using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Kernel32 class
    /// </summary>
    public static class Kernel32
    {
        /// <summary>
        /// Process information structure
        /// </summary>
        public struct PROCESS_INFORMATION
        {
            /// <summary>
            /// Process handle
            /// </summary>
            public IntPtr hProcess;

            /// <summary>
            /// Thread handle
            /// </summary>
            public IntPtr hThread;

            /// <summary>
            /// Process ID
            /// </summary>
            public uint dwProcessId;

            /// <summary>
            /// Thread ID
            /// </summary>
            public uint dwThreadId;
        }

        /// <summary>
        /// Startup information structure
        /// </summary>
        public struct STARTUPINFO
        {
            public uint cb;
            public string lpReserved;
            public string lpDesktop;
            public string lpTitle;
            public uint dwX;
            public uint dwY;
            public uint dwXSize;
            public uint dwYSize;
            public uint dwXCountChars;
            public uint dwYCountChars;
            public uint dwFillAttribute;
            public uint dwFlags;
            public short wShowWindow;
            public short cbReserved2;
            public IntPtr lpReserved2;
            public IntPtr hStdInput;
            public IntPtr hStdOutput;
            public IntPtr hStdError;
        }
        
        /// <summary>
        /// Security attributes structure
        /// </summary>
        public struct SECURITY_ATTRIBUTES
        {
            public int length;
            public IntPtr lpSecurityDescriptor;
            public bool bInheritHandle;
        }

        /// <summary>
        /// Get modules handle
        /// </summary>
        /// <param name="lpModuleName">Module name</param>
        /// <returns>Module handle</returns>
        [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        /// <summary>
        /// Get process address
        /// </summary>
        /// <param name="hModule">Module handle</param>
        /// <param name="procName">Process name</param>
        /// <returns>Process address</returns>
        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        internal static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        /// <summary>
        /// Virtually allocate extended
        /// </summary>
        /// <param name="hProcess">Process handle</param>
        /// <param name="lpAddress">Address</param>
        /// <param name="dwSize">Size</param>
        /// <param name="flAllocationType">Allocation type</param>
        /// <param name="flProtect">Protect</param>
        /// <returns>Virtually allocated memory</returns>
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, AllocationType flAllocationType, MemoryProtection flProtect);

        /// <summary>
        /// Virtually free extended
        /// </summary>
        /// <param name="hProcess">Process handle</param>
        /// <param name="lpAddress">Address</param>
        /// <param name="dwSize">Size</param>
        /// <param name="dwFreeType">Free type</param>
        /// <returns>Success</returns>
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        public static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, AllocationType dwFreeType);

        /// <summary>
        /// Create process
        /// </summary>
        /// <param name="lpApplicationName">Application name</param>
        /// <param name="lpCommandLine">Command line</param>
        /// <param name="lpProcessAttributes">Proccess attributes</param>
        /// <param name="lpThreadAttributes">Thread attributes</param>
        /// <param name="bInheritHandles">Inherit handles</param>
        /// <param name="dwCreationFlags">Creation flags</param>
        /// <param name="lpEnvironment">Environment</param>
        /// <param name="lpCurrentDirectory">Current directory</param>
        /// <param name="lpStartupInfo">Startup information</param>
        /// <param name="lpProcessInformation">Process information</param>
        /// <returns>Success</returns>
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, ref SECURITY_ATTRIBUTES lpProcessAttributes, ref SECURITY_ATTRIBUTES lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, [In] ref STARTUPINFO lpStartupInfo, out PROCESS_INFORMATION lpProcessInformation);

        /// <summary>
        /// Create Process
        /// </summary>
        /// <param name="lpApplicationName">Application name</param>
        /// <param name="lpCommandLine">Command line</param>
        /// <param name="lpProcessAttributes">Process attributes</param>
        /// <param name="lpThreadAttributes">Thread attributes</param>
        /// <param name="bInheritHandles">Inherit handles</param>
        /// <param name="dwCreationFlags">Creation flags</param>
        /// <param name="lpEnvironment">Environment</param>
        /// <param name="lpCurrentDirectory">Current directory</param>
        /// <param name="lpStartupInfo">Startup information</param>
        /// <param name="lpProcessInformation"></param>
        /// <returns>Success</returns>
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, [In] ref STARTUPINFO lpStartupInfo, out PROCESS_INFORMATION lpProcessInformation);

        /// <summary>
        /// Write process memory
        /// </summary>
        /// <param name="hProcess">Process handle</param>
        /// <param name="lpBaseAddress">Base address</param>
        /// <param name="lpBuffer">Buffer</param>
        /// <param name="nSize">Size</param>
        /// <param name="lpNumberOfBytesWritten">Number of bytes written</param>
        /// <returns>Success</returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out int lpNumberOfBytesWritten);

        /// <summary>
        /// Create remote thread
        /// </summary>
        /// <param name="hProcess">Process handle</param>
        /// <param name="lpThreadAttributes">Thread attributes</param>
        /// <param name="dwStackSize">Stack size</param>
        /// <param name="lpStartAddress">Start address</param>
        /// <param name="lpParameter">Parameter</param>
        /// <param name="dwCreationFlags">Creation flags</param>
        /// <param name="lpThreadId">Thread ID</param>
        /// <returns>Remote thread handle</returns>
        [DllImport("kernel32")]
        public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, out uint lpThreadId);

        /// <summary>
        /// Resume thread
        /// </summary>
        /// <param name="hThread">Thread handle</param>
        /// <returns>Result</returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern uint ResumeThread(IntPtr hThread);

        /// <summary>
        /// Wait for single object
        /// </summary>
        /// <param name="hHandle">Handle handle</param>
        /// <param name="dwMilliseconds">Milliseconds</param>
        /// <returns>Result</returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern UInt32 WaitForSingleObject(IntPtr hHandle, UInt32 dwMilliseconds);

        /// <summary>
        /// Close handle
        /// </summary>
        /// <param name="hObject">Object handle</param>
        /// <returns>Success</returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        [SuppressUnmanagedCodeSecurity]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseHandle(IntPtr hObject);

        /// <summary>
        /// Allocation type flag enumerator
        /// </summary>
        [Flags]
        public enum AllocationType
        {
            Commit = 0x1000,
            Reserve = 0x2000,
            Decommit = 0x4000,
            Release = 0x8000,
            Reset = 0x80000,
            Physical = 0x400000,
            TopDown = 0x100000,
            WriteWatch = 0x200000,
            LargePages = 0x20000000
        }

        /// <summary>
        /// Memory protection flag enumerator
        /// </summary>
        [Flags]
        public enum MemoryProtection
        {
            Execute = 0x10,
            ExecuteRead = 0x20,
            ExecuteReadWrite = 0x40,
            ExecuteWriteCopy = 0x80,
            NoAccess = 0x01,
            ReadOnly = 0x02,
            ReadWrite = 0x04,
            WriteCopy = 0x08,
            GuardModifierflag = 0x100,
            NoCacheModifierflag = 0x200,
            WriteCombineModifierflag = 0x400
        }
    }
}
