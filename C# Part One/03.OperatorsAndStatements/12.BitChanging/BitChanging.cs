// We are given integer number n, value v (v=0 or 1) and a position p. 
// Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
// Example: 
// n = 5 (00000101), p=3, v=1  13 (00001101)
// n = 5 (00000101), p=2, v=0  1 (00000001)

using System;

class BitChanging
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}\n", Convert.ToString(n, 2).PadLeft(32, '0'));
        while (true)
        {
            Console.Write("(Type 100 to EXIT)\nEnter the position of the bit you want to change: ");
            int p = int.Parse(Console.ReadLine());
            if (p == 100)
                break;
            while ((p < 0) || (p > 32))
            {
                Console.Write("Enter a postition that is within the size of {0} : ", p.GetType());
                p = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter the new value of the bit you want to change: ");
            byte v = byte.Parse(Console.ReadLine());
            while (!((v == 0) || (v == 1)))
            {
                Console.Write("Enter only 1 or 0 : ", p.GetType());
                v = byte.Parse(Console.ReadLine());
            }
            int mask = 1;
            mask <<= p;
            if (v == 1)
                n |= mask; // This sets the bit to 1
            else
                if ((n & mask) != 0)
                    n &= ~mask; // If the bit was 1, we clear it to 0, using AND with the NOT of mask.
            // If the bit was already 0, we do nothing
            Console.WriteLine("\nThe new number is {0}", n);
            Console.WriteLine("{0}\n", Convert.ToString(n, 2).PadLeft(32, '0'));        
        }
    }
}

