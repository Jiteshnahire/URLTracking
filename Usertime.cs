using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class UserActiveTimeFinder
    {
        // Import the required functions from user32.dll
        [DllImport("user32.dll")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        [DllImport("kernel32.dll")]
        private static extern uint GetTickCount();

        // Structure to hold the last input information
        internal struct LASTINPUTINFO
        {
            public uint cbSize;
            public uint dwTime;
        }

        public static TimeSpan GetUserActiveTime()
        {
            LASTINPUTINFO lastInputInfo = new LASTINPUTINFO();
            lastInputInfo.cbSize = (uint)Marshal.SizeOf(lastInputInfo);

            if (!GetLastInputInfo(ref lastInputInfo))
                throw new Exception("Failed to retrieve the last input information.");

            uint lastInputTime = lastInputInfo.dwTime;
            uint currentTickCount = GetTickCount();
            uint activeTime = currentTickCount - lastInputTime;

            return TimeSpan.FromMilliseconds(activeTime);
        }
    }

    public class Usertime
    {
        public static void Main(string[] args)
        {
            TimeSpan activeTime = UserActiveTimeFinder.GetUserActiveTime();
            Console.WriteLine($"User active time: {activeTime.TotalSeconds} seconds");
        }
    }

}