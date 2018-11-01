using System;
using System.Threading;

namespace DelegatesTimer
{
    public delegate void Delegate ();

    static class Timer
    {
        static private int loopInterval = 1000;

        public static void startTimer(Delegate function)
        {
            while (true)
            {
                function();
                Thread.Sleep(loopInterval);
            }
        }

        public static void startTimer(Delegate function, int miliSeconds)
        {
            while (true)
            {
                function();
                Thread.Sleep(miliSeconds);
            }
        }
    }
}
