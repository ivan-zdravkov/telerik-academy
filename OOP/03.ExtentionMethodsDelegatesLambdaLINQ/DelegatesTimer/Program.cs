using System;
using System.Linq;

namespace DelegatesTimer
{
    class Program
    {
        static void Main()
        {
            Delegate func = new Delegate(PrintMessage);
           
            decimal seconds = 0.75M;
            int miliSeconds = (int)(seconds * 1000);

            Timer.startTimer(func, miliSeconds);
        }

        public static void PrintMessage()
        {
            DateTime time = DateTime.Now;
            Console.WriteLine("This is called from a delagete and the time is: {0}:{1}:{2}:{3}", time.Hour, time.Minute, time.Second, time.Millisecond);
        }
    }
}
