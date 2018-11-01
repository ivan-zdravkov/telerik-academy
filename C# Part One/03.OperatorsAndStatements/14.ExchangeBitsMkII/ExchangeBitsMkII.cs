// Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.

using System;

class ExchangeBitsMkII
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("Enter how many bits you would like to switch: ");
        byte k = byte.Parse(Console.ReadLine());
        while (k > 32)
        {
            Console.Write("Enter a number, smaller than 32: ");
            k = byte.Parse(Console.ReadLine());
        }
        Console.Write("Enter the number of the first bit you would change: ");
        byte bitToChange1 = byte.Parse(Console.ReadLine());
        while (bitToChange1 > 32)
        {
            Console.Write("Enter a number, smaller than 32: ");
            bitToChange1 = byte.Parse(Console.ReadLine());
        }
        Console.Write("Enter the number of the second bit you would change: ");
        byte bitToChange2 = byte.Parse(Console.ReadLine());
        while (bitToChange2 > 32 - k)
        {
            Console.Write("Enter a number, smaller than {0}: ", 32 - k);
            bitToChange2 = byte.Parse(Console.ReadLine());
        }
        Console.WriteLine("{0}\n", Convert.ToString(n, 2).PadLeft(32, '0'));
        uint mask = 1;
        uint bit1;
        uint bit2;
        uint num;
        for (byte i = 0; i < k; i++)
        {
            mask = mask << bitToChange1 + i;
            bit1 = (mask & n) >> bitToChange1 + i;
            mask = mask >> bitToChange1 + i;
            mask = mask << bitToChange2 + i;
            bit2 = (mask & n) >> bitToChange2 + i;
            mask >>= bitToChange2 + i;
            if (bit1 != bit2)
            {
                if (bit1 == 1)
                {
                    num = n | (mask << bitToChange2 + i);
                    n = num ^ (mask << bitToChange1 + i);
                }
                else
                {
                    num = n ^ (mask << bitToChange2 + i);
                    n = num | (mask << bitToChange1 + i);
                }
            }
        }
        Console.WriteLine("The new number is {1}\n{0}\n", Convert.ToString(n, 2).PadLeft(32, '0'), n);
    }
}

