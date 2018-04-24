using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Taskbar progress
    /// </summary>
    public static class TaskbarProgress
    {
        /// <summary>
        /// Taskbar states enumerator
        /// </summary>
        public enum TaskbarStates
        {
            /// <summary>
            /// No progress
            /// </summary>
            NoProgress = 0,

            /// <summary>
            /// Indeterminate
            /// </summary>
            Indeterminate = 0x1,

            /// <summary>
            /// Normal
            /// </summary>
            Normal = 0x2,

            /// <summary>
            /// Error
            /// </summary>
            Error = 0x4,

            /// <summary>
            /// Paused
            /// </summary>
            Paused = 0x8
        }

        /// <summary>
        /// Taskbar list interface
        /// </summary>
        [ComImport()]
        [Guid("ea1afb91-9e28-4b86-90e9-9e9f8a5eefaf")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        private interface ITaskbarList3
        {
            // ITaskbarList

            /// <summary>
            /// Hr init
            /// </summary>
            [PreserveSig]
            void HrInit();

            /// <summary>
            /// Add tab
            /// </summary>
            /// <param name="hwnd">Window handle</param>
            [PreserveSig]
            void AddTab(IntPtr hwnd);

            /// <summary>
            /// Delete tabe
            /// </summary>
            /// <param name="hwnd">Window handle</param>
            [PreserveSig]
            void DeleteTab(IntPtr hwnd);

            /// <summary>
            /// Activate tab
            /// </summary>
            /// <param name="hwnd">Window handle</param>
            [PreserveSig]
            void ActivateTab(IntPtr hwnd);

            /// <summary>
            /// Set active alternate
            /// </summary>
            /// <param name="hwnd">Window handle</param>
            [PreserveSig]
            void SetActiveAlt(IntPtr hwnd);

            // ITaskbarList2

            /// <summary>
            /// Mark fullscreen window
            /// </summary>
            /// <param name="hwnd">Window handle</param>
            /// <param name="fFullscreen">Fullscreen</param>
            [PreserveSig]
            void MarkFullscreenWindow(IntPtr hwnd, [MarshalAs(UnmanagedType.Bool)] bool fFullscreen);

            // ITaskbarList3

            /// <summary>
            /// Set progress value
            /// </summary>
            /// <param name="hwnd">Window handle</param>
            /// <param name="ullCompleted">Completed</param>
            /// <param name="ullTotal">Total</param>
            [PreserveSig]
            void SetProgressValue(IntPtr hwnd, UInt64 ullCompleted, UInt64 ullTotal);

            /// <summary>
            /// Set progress state
            /// </summary>
            /// <param name="hwnd">Window handle</param>
            /// <param name="state">Taskbar state</param>
            [PreserveSig]
            void SetProgressState(IntPtr hwnd, TaskbarStates state);
        }

        /// <summary>
        /// Taskbar instance class
        /// </summary>
        [ComImport()]
        [Guid("56fdf344-fd6d-11d0-958a-006097c9a090")]
        [ClassInterface(ClassInterfaceType.None)]
        private class TaskbarInstance
        {
            //
        }

        /// <summary>
        /// Taskbar instance
        /// </summary>
        private static ITaskbarList3 taskbarInstance = (ITaskbarList3)new TaskbarInstance();

        /// <summary>
        /// Taskbar supported
        /// </summary>
        private static bool taskbarSupported = Environment.OSVersion.Version >= new Version(6, 1);

        /// <summary>
        /// Set state
        /// </summary>
        /// <param name="form">Form</param>
        /// <param name="taskbarState">Taskbar state</param>
        public static void SetState(Form form, TaskbarStates taskbarState)
        {
            if (taskbarSupported)
            {
                taskbarInstance.SetProgressState(form.Handle, taskbarState);
            }
        }

        /// <summary>
        /// Set value
        /// </summary>
        /// <param name="form">Form</param>
        /// <param name="progressValue">Progress value</param>
        /// <param name="progressMax">Progress maximal</param>
        public static void SetValue(Form form, double progressValue, double progressMax)
        {
            if (taskbarSupported)
            {
                taskbarInstance.SetProgressValue(form.Handle, (ulong)progressValue, (ulong)progressMax);
            }
        }
    }
}
