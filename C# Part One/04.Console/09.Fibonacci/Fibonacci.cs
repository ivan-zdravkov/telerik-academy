// Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;

class Fibonacci
{
    static void Main()
    {
        decimal numberOne = 0; // We use decimal, since even Ulong is not big enough for these big numbers!
        decimal numberTwo = 1;
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(numberOne);
            numberTwo += numberOne;
            numberOne = numberTwo - numberOne;
        }
    }
}

