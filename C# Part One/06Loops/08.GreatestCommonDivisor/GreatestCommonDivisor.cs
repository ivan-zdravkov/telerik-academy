// Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).

using System;

class GreatestCommonDivisor
{
	static void Main()
	{
        int numberOne = 0; // The algorithm work for real numbers
        while (numberOne < 1)
        {
            Console.Write("Enter an integer number, larger than 1: ");
            numberOne = int.Parse(Console.ReadLine());
        }
        int  numberTwo = 0;
        while (numberTwo < 1)
        {
            Console.Write("Enter an integer number, larger than 1: ");
            numberTwo = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(GCD(numberOne, numberTwo)); // We call in the GCD method
	}

    static int GCD(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        else
        {
            return GCD(b, a % b); // The method recursively calls itself again before returning a value!
                                  // Some might say recursion is bad or slow, but in this case, no harm done ;)
        }
    }
}

