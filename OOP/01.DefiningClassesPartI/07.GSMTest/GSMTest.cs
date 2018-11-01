using System;

namespace MobilePhone
{
    class GSMTest
    {
        static Random random = new Random();

        private int sizeOfArray;
        private GSM[] array;

        public GSMTest(int sizeOfArray)
        {
            if (sizeOfArray < 1)
            {
                throw new ArgumentException("The size of Array, should be > than 1");
            }
            this.sizeOfArray = sizeOfArray;
        }

        public void CreateGSMArray(int sizeOfArray)
        {
            this.sizeOfArray = sizeOfArray;
            array = new GSM[sizeOfArray];
            this.InnerArrayGenerator();
        }

        public void CreateGSMArray()
        {
            array = new GSM[sizeOfArray];
            this.InnerArrayGenerator();
        }

        private GSM[] InnerArrayGenerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new GSM("Model " + random.Next(0, 1000).ToString(), "Manufacturer " + random.Next(0,1000000).ToString());
                array[i].Battery = new Battery("JustBattery" + random.Next(0,100));
                array[i].Display = new Display("800x600", "65000" );
            }
            return array;
        }

        public void DisplayInfo()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].ToString();
                Console.WriteLine(new String('-', 40));
            }
        }

        public void DisplayIPhone4S()
        {
            GSM.IPhone4S.ToString();
        }
    }
}
