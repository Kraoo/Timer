using System;
using System.Timers;

namespace TimerExample
{
    class Program
    {
        static System.Timers.Timer? timer;

        static void Main(string[] args)
        {
            int interval = 1000;

            timer = new System.Timers.Timer(interval);

            if (timer != null)
            {
                timer.Elapsed += Timer_Elapsed;

                timer.Start();
            }

            Console.WriteLine("Timer started. Press any key to stop...");
            Console.ReadKey();

            if (timer != null)
            {
                timer.Stop();
            }

            Console.WriteLine("Timer stopped. Press any key to exit...");
            Console.ReadKey();
        }

        static void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            Console.WriteLine($"Elapsed time: {e.SignalTime}");
        }
    }
}
