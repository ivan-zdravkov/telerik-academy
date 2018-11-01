using System;

namespace MobilePhone
{
    class GSMCallHistoryTest
    {
        static Battery htcBattery = new Battery("htcOneBattery", "1200", "200", 0);
        static Display htcDisplay = new Display("1024x768", "65000000");
        GSM htcOne = new GSM("htcOne", "htc", "$1400", "Ivan", htcBattery, htcDisplay);

        public void AddCalls()
        {
            htcOne.AddToCallHistory = new Call(DateTime.Now, "0883333666", 123);
            htcOne.AddToCallHistory = new Call(DateTime.Now, "0164624675", 12);
            htcOne.AddToCallHistory = new Call(DateTime.Now, "6136136316", 1351);
            htcOne.AddToCallHistory = new Call(DateTime.Now, "4616161366", 44);
        }

        public void DisplayCallInfo()
        {
            for (int i = 0; i < htcOne.GetCallHistory.Count; i++)
            {
                Console.WriteLine("Date:         {0}", htcOne.GetCallHistory[i].GetDate());
                Console.WriteLine("Time:         {0}", htcOne.GetCallHistory[i].GetTime());
                Console.WriteLine("Dialed Phone: {0}", htcOne.GetCallHistory[i].DialedPhone);
                Console.WriteLine("Seconds:      {0}", htcOne.GetCallHistory[i].Seconds);
                Console.WriteLine(new String('-', 40));
            }
        }

        public decimal GetPrice(decimal price)
        {
            return htcOne.CalculatePrice(price);
        }

        public void RemoveLongestCall()
        {
            Call longestCall = new Call(DateTime.Now, "0", 0);
            int maxLength = 0;
            for (int i = 0; i < htcOne.GetCallHistory.Count; i++)
            {
                if (htcOne.GetCallHistory[i].Seconds > maxLength)
                {
                    longestCall = htcOne.GetCallHistory[i];
                    maxLength = htcOne.GetCallHistory[i].Seconds;
                }
            }

            htcOne.DeleteFromCallHistory(longestCall);
        }

        public void ClearCallHistory()
        {
            htcOne.ClearCallHistory();
        }
    }
}
