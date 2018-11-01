//Write a program that calculates N!/K! for given N and K (1<K<N).
 
using System;
using System.Numerics;

class FactorielMarkOne
{
	static void Main()
	{
        Console.WriteLine("The program calculates N!/K!, please enter (1<K<N)!");
        int k = 0;
        int n = 0;
        while (k < 1)
        {
            Console.Write("Enter (K > 1): ");
            k = int.Parse(Console.ReadLine());
        }
        while (n < k)
        {
            Console.Write("Enter (N > {0}): ", k);
            n = int.Parse(Console.ReadLine());
        }
        /*
         * if K = 4, K! = 1 * 2 * 3 * 4
         * if N = 6, N! = 1 * 2 * 3 * 4 * 5 * 6 
         * ---> (N!) / (K!) = (1 * 2 * 3 * 4 * 5 * 6) / (1 * 2 * 3 * 4) = (5 * 6)
         */
        BigInteger result = 1;
        for (int i = n; i > k; i--)
        {
            result *= i;
            /*if (i > k + 1) // Uncomment for better perspective [Will be >> slower]
            {
                Console.Write("{0} * ", i);
            }
            else
            {
                Console.Write("{0} = ", i);
            }*/
        }
        Console.Write(result);
        Console.WriteLine();
    }
}

