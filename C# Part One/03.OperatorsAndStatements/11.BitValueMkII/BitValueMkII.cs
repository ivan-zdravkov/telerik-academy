// Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.

using System;

class BitValueMkII
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Enter position of the bit you want to check: ");
        int b = int.Parse(Console.ReadLine());
        while ((b < 0) || (b > 32))
        {
            Console.Write("\nEnter a postition that is within the size of {0} : ", b.GetType());
            b = int.Parse(Console.ReadLine());
        }
        int mask = 1;
        mask <<= b;
        bool isBitSet = (((i & mask) >> b) == 1);
        Console.WriteLine("Bit {0} of the number {1} is {2}", b, i, isBitSet ? "set (1)!" : "not set (0)!");
        Console.WriteLine("{0}", Convert.ToString(i , 2).PadLeft(32, '0'));
    }
}

