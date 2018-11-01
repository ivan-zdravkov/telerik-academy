using System;
using System.Numerics;

class TrailingZeroes
{
	static void Main()
	{
        int number = 0;
        while (number < 1)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
        }
        BigInteger factorial = Fact(number);
        Console.WriteLine(factorial);

        BigInteger result = 0;
        int Five = 5;
        BigInteger PowerOfFive = 5;
        while (PowerOfFive < factorial)
        {
            if ((factorial % PowerOfFive) == 0)
            {
                PowerOfFive *= Five;
                result++;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine("\n{0} zeros", result);
	}

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


