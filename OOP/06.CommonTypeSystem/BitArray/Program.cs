using System;

namespace BitArray
{
    class Program
    {
        static Random random = new Random();
        static void Main()
        {
            Console.WriteLine("Generating 64 random bits...");
            BitArray64 bitsOfNumber = new BitArray64(GenerateRandom64BitNumber());
            Print(bitsOfNumber);

            Console.WriteLine("\nChanging bits \n[63 - 53] -> 1; \n[40 - 30] -> 0;");
            for (int i = 63; i > 52; i-- )
            {
                bitsOfNumber[i] = 1;
            }
            for (int i = 40; i > 29; i-- )
            {
                bitsOfNumber[i] = 0;
            }
            Print(bitsOfNumber);

            Console.WriteLine("\nCreating a deep copy of the bits, using a class constructor...");
            BitArray64 newNumber = new BitArray64(bitsOfNumber);
            Print(newNumber);

            Console.Write("\nChecking if the 2 bit arrays are Equal, using Equal() -> ");
            Console.WriteLine(bitsOfNumber.Equals(newNumber));
            Console.Write("Checking if the the First == Second bit array -> ");
            Console.WriteLine(bitsOfNumber == newNumber);
            Console.Write("Checking if the First != Second bit array -> ");
            Console.WriteLine(bitsOfNumber != newNumber);

            Console.WriteLine("\nUsing foreach to display the bits (Thanks to the IEnumerable<int> Interface)...");
            foreach (int bit in newNumber)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
        }

        private static void Print(BitArray64 bits)
        {
            for (int i = 63; i >= 0; i--)
            {
                Console.Write(bits[i]);
            }
            Console.WriteLine();
            //Console.WriteLine(" -> " + bits.ToString());
        }

        private static ulong GenerateRandom64BitNumber()
        {
            ulong temp = 0;
            ulong number = (ulong)random.Next(0, int.MaxValue);
            
            number <<= 31;
            temp = (ulong)random.Next();
            number |= temp;
            
            number <<= 31;
            temp = (ulong)random.Next();
            number |= temp;
            
            return number;
        }
    }
}
