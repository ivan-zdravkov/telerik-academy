// Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. 
// Example: v=5; p=1  false.

using System;

class BitValue
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter position of the bit you want to check: ");
        int p = int.Parse(Console.ReadLine());
        while ((p < 0) || (p > 32))
        {
            Console.Write("\nEnter a postition that is within the size of {0} : ", p.GetType());
            p = int.Parse(Console.ReadLine());
        }
        int mask = 1;
        mask <<= p;
        bool isBitSet = (((number & mask) >> p) == 1);
        Console.WriteLine("Bit {0} of the number {1} is 1: {2}", p, number, isBitSet);
        Console.WriteLine("{0}", Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}

