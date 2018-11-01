using System;

namespace MobilePhone
{
    class Program
    {
        static void Main()
        {
            GSMTest test = new GSMTest(4);
            GSMTest.GenerateStaticIPhone4S();
            test.CreateGSMArray();
            test.DisplayInfo();
            test.DisplayIPhone4S();

            Console.WriteLine("\n" + new String('=', 60) + "\n");

            GSMCallHistoryTest callTest = new GSMCallHistoryTest();
            callTest.AddCalls();
            callTest.DisplayCallInfo();
            Console.WriteLine("\n\nThe PRICE of all CALLS is {0}\n", callTest.GetPrice(0.37M));
            callTest.RemoveLongestCall();
            Console.WriteLine("REMOVING LONGEST CALL FROM LIST...");
            Console.WriteLine("The PRICE of all CALLS is {0}\n", callTest.GetPrice(0.37M));
            callTest.ClearCallHistory();
            Console.WriteLine("Prining the cleared call history: ");
            callTest.DisplayCallInfo();
            Console.WriteLine();
        }
    }
}
