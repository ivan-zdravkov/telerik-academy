// Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N

using System;
using System.Numerics;

class SomeSum
{
    /* I have tried using BigInteger to save the Factoriel and Power of X, but when I calculate the sum I have to use
     * integer division, which does not work. Only decimal works at this point. Decimal though can't reall work with big numbers.
     */

    static void Main()
	{
        Console.WriteLine("The program calculates S = 1 + 1!/X + 2!/X^2 + … + N!/X^N");
        int x = 0;
        int n = 0;
        while (x < 1) // I assume the numbers are possitive, though not stated!
        {
            Console.WriteLine("Enter a possitive X:");
            x = int.Parse(Console.ReadLine());
        }
        while (n < 1) // I assume the numbers are possitive, though not stated!
        {
            Console.WriteLine("Enter a possitive N:");
            n = int.Parse(Console.ReadLine());
        }
        decimal fact = 1; // The current factoriel
        decimal powerX = 1; // The current power of X
        decimal sum = 1;
        Console.Write("1 + ");
        for (int i = 1; i <= n; i++)
        {
            powerX *= x;
            fact *= i;
            sum += (fact / powerX);
            Console.Write("{0}!/{1}^{0}", i, x);
            if (i < n)
            {
                Console.Write(" + ");
            }
            else
            {
                Console.Write(" = \n");
            }
        }
        Console.WriteLine("= " + sum);
	}
}

