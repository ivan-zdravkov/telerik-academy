// Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class AccruacySum
{
    static void Main()
    {
        double sum = 1;
        for(int i = 2; (1.0 / i) > 0.001; i++)
        {
            if (i % 2 == 0)
            {
                sum = sum + (1.00 / i);
            }
            else
            {
                sum = sum - (1.00 / i);
            }
        }
        Console.WriteLine("{0:0.000}", sum);
        Console.WriteLine("{0}",sum);
    }
}

