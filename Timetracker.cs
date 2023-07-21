using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class SystemIdleTimeFinder
    {
        // Import the required function from user32.dll
        [DllImport("user32.dll")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        // Structure to hold the last input information
        internal struct LASTINPUTINFO
        {
            public uint cbSize;
            public uint dwTime;
        }

        public static TimeSpan GetSystemIdleTime()
        {
            LASTINPUTINFO lastInputInfo = new LASTINPUTINFO();
            lastInputInfo.cbSize = (uint)Marshal.SizeOf(lastInputInfo);

            if (!GetLastInputInfo(ref lastInputInfo))
                throw new Exception("Failed to retrieve the last input information.");

            uint lastInputTime = lastInputInfo.dwTime;
            uint currentTickCount = (uint)Environment.TickCount;
            uint idleTime = currentTickCount - lastInputTime;

            return TimeSpan.FromMilliseconds(idleTime);
        }
    }

    public class Timetracker
    {
        public static void Main(string[] args)
        {
            TimeSpan idleTime = SystemIdleTimeFinder.GetSystemIdleTime();
            Console.WriteLine($"System idle time: {idleTime.TotalSeconds} seconds");
        }
    }

}
