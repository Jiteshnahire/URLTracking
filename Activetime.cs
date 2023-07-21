using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    public class ActivityTracker
    {
        private Timer timer;
        private DateTime lastActivityTime;
        private TimeSpan inactiveThreshold;
        private TimeSpan inactiveTime;

        public event EventHandler InactiveTimeExceeded;

        public TimeSpan InactiveTime => inactiveTime;

        public ActivityTracker(TimeSpan inactiveThreshold)
        {
            this.inactiveThreshold = inactiveThreshold;
            this.lastActivityTime = DateTime.Now;

            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Elapsed += Timer_Elapsed;
        }

        public void StartTracking()
        {
            timer.Start();
        }

        public void StopTracking()
        {
            timer.Stop();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var currentTime = DateTime.Now;
            var elapsedTime = currentTime - lastActivityTime;

            if (elapsedTime > inactiveThreshold && inactiveTime < inactiveThreshold)
            {
                inactiveTime = elapsedTime;
                OnInactiveTimeExceeded();
            }

            lastActivityTime = currentTime;
        }

        protected virtual void OnInactiveTimeExceeded()
        {
            InactiveTimeExceeded?.Invoke(this, EventArgs.Empty);
        }
    }


    public class Activetime
    {
        private static ActivityTracker activityTracker;

        public static void Main()
        {
            activityTracker = new ActivityTracker(TimeSpan.FromSeconds(5)); // Set inactive threshold to 5 seconds
            activityTracker.InactiveTimeExceeded += ActivityTracker_InactiveTimeExceeded;
            activityTracker.StartTracking();

            Console.WriteLine("Tracking started. Press any key to stop...");
            Console.ReadKey();

            activityTracker.StopTracking();
            Console.WriteLine("Tracking stopped. Total inactive time: " + activityTracker);
        }

        private static void ActivityTracker_InactiveTimeExceeded(object sender, EventArgs e)
        {
            Console.WriteLine("Inactive time threshold exceeded!");
        }
    }
}

