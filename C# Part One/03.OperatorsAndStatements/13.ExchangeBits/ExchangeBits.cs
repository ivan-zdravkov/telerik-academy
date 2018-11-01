// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class ExchangeBits
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        uint n = uint.Parse(Console.ReadLine());
        Console.WriteLine("{0}\n", Convert.ToString(n, 2).PadLeft(32, '0'));
        uint mask = 1;
        uint bit1;
        uint bit2;
        uint num;
        for (byte i = 0; i < 3; i++)
        {
            mask = mask << 3 + i;
            bit1 = (mask & n) >> 3 + i;
            mask = mask >> 3 + i;
            mask = mask << 24 + i;
            bit2 = (mask & n) >> 24 + i;
            mask >>= 24 + i;
            if (bit1 != bit2)
            {
                if (bit1 == 1)
                {
                    num = n | (mask << 24 + i);
                    n = num ^ (mask << 3 + i);
                }
                else
                {
                    num = n ^ (mask << 24 + i);
                    n = num | (mask << 3 + i);
                }
            }
        }
        Console.WriteLine("The new number is {1}\n{0}\n", Convert.ToString(n, 2).PadLeft(32, '0'), n);
    }
}

