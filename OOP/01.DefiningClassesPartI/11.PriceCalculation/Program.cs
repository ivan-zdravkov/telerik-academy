using System;

namespace MobilePhone
{
    class Program
    {
        static void Main()
        {
            GenerateStaticIPhone4S();
            
            GSMTest test = new GSMTest(4);
            test.CreateGSMArray();
            test.DisplayInfo();
            test.DisplayIPhone4S();
        }

        private static void GenerateStaticIPhone4S()
        {
            Battery iPhoneBattery = new Battery("iPhoneBattery", "200", "80", 0);
            Display iPhoneDisplay = new Display("1920x1080", "15000000");
            GSM iPhone = new GSM("4S", "Apple", "$1200", "Ivan", iPhoneBattery, iPhoneDisplay);
            GSM.IPhone4S = iPhone;
        }
    }
}
