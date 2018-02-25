using System;
using System.Runtime.InteropServices;


namespace ToggleMuteForegroundApplication
{
    class Program
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);

        static void Main()
        {
            // Get the foreground window
            IntPtr hWnd = GetForegroundWindow();

            if (hWnd == IntPtr.Zero)
                return;


            uint pid;
            // Get the process ID
            GetWindowThreadProcessId(hWnd, out pid);

            if (pid == 0)
                return;

            bool? muted = VolumeMixer.GetApplicationMute((int)pid);

            if(muted != null)
                VolumeMixer.SetApplicationMute((int)pid, ! (bool) muted);

        }
    }
}
