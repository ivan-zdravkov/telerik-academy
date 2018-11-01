// We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. 
// Example: 3, -2, 1, 1, 8  1+1-2=0.

using System;
using System.Globalization;
using System.Threading;

class SubsetSum
{
    static int BitValue(int number, int digit) // The method that checks if a bit is 1 and returns it's value
    {
        return (number & (1 << digit)) >> digit;
    }

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int count = 5;
        Console.WriteLine("Please enter {0} numbers!", count);
        bool valid = true;

        decimal[] values = new decimal[count]; // An array that has count elements
        for (int i = 0; i < count; i++)
        {
            Console.Write("Number {0}: ", i + 1);
            valid &= Decimal.TryParse(Console.ReadLine(), out values[i]);
        }

        if (valid)
        {
            decimal sum;

            decimal countPower = 1; // This will be the variable that contains the 2^count value!
            for (int i = 0; i < count; i++)
            {
                countPower *= 2;
            }

            for (int i = 1; i < countPower; i++)
            {
                sum = 0m;
                for (int j = 0; j < count; j++)
                {
                    sum += values[j] * BitValue(i, j);
                }
                if (sum == 0)
                {
                    for (int j = 0; j < count; j++)
                    {
                        if (BitValue(i, j) == 1)
                        {
                            Console.Write("{1}{0}{2} + ", values[j], values[j] < 0 ? "(" : "", values[j] < 0 ? ")" : "");
                        }
                    }
                    Console.WriteLine("\b\b= 0");
                }
            }
        }
        else
        {
            Console.WriteLine("ERROR, wrong input!\nPROGRAM TERMINATING...");
        }
    }
}
