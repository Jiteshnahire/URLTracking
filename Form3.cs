using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeskTimeWindowsForms
{
    public partial class Form3 : Form
    {
        private static uint t1, t2;
        private TimeSpan activeTime = TimeSpan.Zero;
        private TimeSpan inactiveTime = TimeSpan.Zero;
        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label2.Text = "00:00";
            label3.Text = "00:00";
            timer1.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            MessageBox.Show($"Active time: {activeTime.TotalMinutes:F2} minutes, {activeTime.Seconds} seconds\nInactive time: {inactiveTime.TotalMinutes:F2} minutes, {inactiveTime.Seconds} seconds");
            Application.Exit();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            uint idleTime = Win32.GetIdleTime();

            if (idleTime > 1000) // 1 minute
            {
                inactiveTime += TimeSpan.FromMilliseconds(idleTime);
                label3.Text = FormatTimeSpan(inactiveTime);
            }
            else
            {
                activeTime += TimeSpan.FromMilliseconds(idleTime);
                label2.Text = FormatTimeSpan(activeTime);
            }
        }

        private string FormatTimeSpan(TimeSpan timeSpan)
        {
            return $"{timeSpan.Hours:D2}:{timeSpan.Minutes:D2}:{timeSpan.Seconds:D2}";
        }
        internal struct LASTINPUTINFO
        {
            public uint cbSize;
            public uint dwTime;
        }

        public class Win32
        {
            [DllImport("User32.dll")]
            public static extern bool LockWorkStation();

            [DllImport("User32.dll")]
            private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

            [DllImport("Kernel32.dll")]
            private static extern uint GetLastError();

            public static uint GetIdleTime()
            {
                LASTINPUTINFO lastInput = new LASTINPUTINFO();
                lastInput.cbSize = (uint)Marshal.SizeOf(lastInput);
                if (!GetLastInputInfo(ref lastInput))
                {
                    throw new Exception(GetLastError().ToString());
                }

                uint idleTime = (uint)Environment.TickCount - lastInput.dwTime;
                return idleTime;
            }

            public static long GetLastInputTime()
            {
                LASTINPUTINFO lastInPut = new LASTINPUTINFO();
                lastInPut.cbSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf(lastInPut);
                if (!GetLastInputInfo(ref lastInPut))
                {
                    throw new Exception(GetLastError().ToString());
                }

                return lastInPut.dwTime;
            }

            // Rest of the code remains the same
        }
    }
}