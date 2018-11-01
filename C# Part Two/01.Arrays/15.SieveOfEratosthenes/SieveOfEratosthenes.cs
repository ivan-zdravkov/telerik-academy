// Write a program that finds all prime numbers in the range [1...10 000 000]. 
// Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;
using System.Collections;

class SieveOfEratosthenes
{
    static void Main()
    {
        int range = 0;
        while (range < 2)
        {
            Console.Write("[1... RANGE] Enter RANGE: ");
            range = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nATTENTION: A very large range, may take a long time to print on the console!");
        char choice = '0';
        while ((choice != 'y') && (choice != 'n'))
        {
            Console.Write("Would you like the prime numbers to be printed on the console [y/n]: ");
            choice = char.Parse(Console.ReadLine());
        }
        Eratosthenes(range, choice);
    }

    static void Eratosthenes (int topCandidate, char print)
    {
        int totalCount = 0;
        BitArray @bitArray = new BitArray(topCandidate + 1); // msdn.microsoft.com/en-us/library/system.collections.bitarray.aspx

        // Set all but 0 and 1 to prime status
        @bitArray.SetAll(true);
        @bitArray[0] = @bitArray[1] = false;

        // Mark all the non-primes
        int thisFactor = 2;
        int lastSquare = 0;
        int thisSquare = 0;

        while (thisFactor * thisFactor <= topCandidate)
        {
            // Mark the multiples of this factor
            int mark = thisFactor + thisFactor;
            while (mark <= topCandidate)
            {
                @bitArray[mark] = false;
                mark += thisFactor;

            }

            // Print the proven primes so far 
            thisSquare = thisFactor * thisFactor;
            for (; lastSquare < thisSquare; lastSquare++)
            {
                if (@bitArray[lastSquare]) totalCount++;

            }

            // Set thisFactor to next prime 
            thisFactor++;
            while (!@bitArray[thisFactor]) { thisFactor++; }

        }
        // Print the remaining primes 
        for (; lastSquare <= topCandidate; lastSquare++)
        {
            if (@bitArray[lastSquare]) { totalCount++; }
        }

        // Printing the output
        if (print == 'y')
        {
            for (int i = 0; i < @bitArray.Length; i++)
            {
                if (@bitArray[i] == true)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\nSUCCESS!");
        }
        else
        {
            Console.WriteLine("SUCCESS!");
        }
    }
}

