// Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.


using System;

class PrimeNumber
{
    static void Main()
    {
        Console.Write("Enter a byte integer: ");
        byte number = byte.Parse(Console.ReadLine());
        while (number > 100)
        {
            Console.Write("Please enter a valid number [1; 100]: ");
            number = byte.Parse(Console.ReadLine());
        }
        // According to Wikipedia, one of the 2 numbers, that form (number = a * b), is always <= Sqrt(number)!
        float topNumber = (float)Math.Sqrt(number); 
        bool isPrime = true;
        // Also according to Wikipedia, 0 and 1 are NOT prime numbers!
        if (number == 1 || number == 0)
            isPrime = false;
        for (int i = 2; i <= topNumber; i++)
        {
            if (number % i == 0)
                isPrime = false;
        }
        Console.WriteLine("{0} is {1}", number, isPrime ? "Prime!": "not Prime!");
    }
}

