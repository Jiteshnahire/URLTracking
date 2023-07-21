using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace ConsoleApp1
{
     class Program
    {
        private static Timer _timer;
        private static int _count;

        static void SetTimer()
        {
            _timer = new Timer(1000);
            _count = 0;
            _timer.Elapsed += TimerOnElapsed;
            _timer.AutoReset = true;
            _timer.Enabled = true;
        }
        private static void TimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            _count++;
            Console.WriteLine($"Timer event raised at {e.SignalTime}  Event Count : {_count}");
        }
        static void Main(string[] args)
        {
            /* SetTimer();
             Console.WriteLine($"press any key to exit");
             Console.WriteLine($"application started at{DateTime.UtcNow:F}");
             Console.ReadLine();
             if (_timer!=null )
             {
                 _timer.Stop();
                 _timer.Dispose();
             }*/
            Console.WriteLine("Application started");
            Console.WriteLine("press any to exit");
            var time = new System.Threading.Timer(obj => 
            {
                Console.WriteLine($"System.Threading.Timer Event raised at {DateTime.UtcNow:F}");
            },null,TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));
            Console.ReadLine();
            Console.WriteLine("timer terminating");

        }
    }
}
