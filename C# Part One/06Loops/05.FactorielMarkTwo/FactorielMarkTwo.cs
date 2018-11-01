// Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;
using System.Numerics;

class FactorielMarkTwo
{
	static void Main()
	{
        Console.WriteLine("The program calculates N!*K! / (K-N)!, please enter (1<N<K)");
        int n = 0;
        int k = 0;
        while (n < 1)
        {
            Console.Write("Enter (N > 1): ");
            n = int.Parse(Console.ReadLine());
        }
        while (k < n)
        {
            Console.Write("Enter (K > {0}): ", n);
            k = int.Parse(Console.ReadLine());
        }

        BigInteger result = 1;

        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }

        for (int i = (k - n + 1); i <= k; i++)
        {
            result *= i;
        }

        Console.Write("\nThe result is: {0}", result);
        Console.WriteLine("\n\nDo you want to compare the result you just got from the short formula\n" + 
                            "with the result from the long formula ?");
        Console.WriteLine("\nPress ENTER to COMPARE or ANY other key to EXIT");
        ConsoleKeyInfo keyEnter = Console.ReadKey();
        if (keyEnter.Key == ConsoleKey.Enter)
        {
            bool resultIsTrue = false;
            resultIsTrue = Check(result, k, n); // If we want to check with the long formula, we call the method Check(), which is under the Main() method
            if (resultIsTrue)
            {
                Console.WriteLine("\nShort Formula result: {0}", result);
                Console.WriteLine("\nThe result is True!");
            }
            else
            {
                Console.WriteLine("\nShort Formula result: {0}", result);
                Console.WriteLine("\nThe result is False!");
            }
        }
        else
        {
            Console.WriteLine();
        }
	}

    // This method is the slower way to calculate the Factoriel, we use it to check if the result is correct.
    static bool Check(BigInteger iResult, int k, int n)
    {
        BigInteger kFact = 1;
        BigInteger nFact = 1;
        BigInteger kMinusNFact = 1;
        for (int i = k; i > 0; i--)
        {
            kFact *= i;
        }
        for (int i = n; i > 0; i--)
        {
            nFact *= i;
        }
        for (int i = (k - n); i > 0; i--)
        {
            kMinusNFact *= i;
        }
        BigInteger checkResult = (kFact * nFact) / kMinusNFact;
        Console.WriteLine("\nLong formula result:  {0}", checkResult);
        if (checkResult == iResult) // iResult is the result we get from the Main() method that we use to compare with
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

