// In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
// C = (2n)! / ((n + 1)! * n!)
//  Write a program to calculate the Nth Catalan number by given N.

using System;
using System.Numerics;

class CatalanNumberMarkTwo
{
	static void Main()
	{
        int number = 0;
        while (number < 1)
        {
            Console.Write("Enter the possitive number of Catalan you want to calculate: ");
            number = int.Parse(Console.ReadLine());
        }
        
        BigInteger catalanNumber = Fact(2 * number) / (Fact(number + 1) * Fact(number));
        Console.WriteLine(catalanNumber);
        
	}

    // The Fact() method calculates the factoriel an integer
    // Big integer is required to calculate the big factoriels
    static BigInteger Fact(int n) 
    {
        BigInteger factorial = 1;
        for (int i = n; i > 1; i--)
        {
            factorial *= i;
        }
        return factorial;
    }
}

