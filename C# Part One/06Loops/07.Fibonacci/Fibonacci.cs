//Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 
// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
// Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.

using System;

class Fibonacci
{
	static void Main()
	{
        int fNumber = 0;
        while (fNumber < 1)
        {
            Console.WriteLine("Enter which Fibonacci number you would like to get the sum to: ");
            fNumber = int.Parse(Console.ReadLine());
        }
        if (fNumber == 1)
        {
            Console.WriteLine("Number 1 of the Fibonacci sequence is 0");
        }
        else if (fNumber == 2)
        {
            Console.WriteLine("Number 2 of the Fibonacci sequence is 1");
        }
        else
        {
            Console.Write("The whole Fibonacci sequnce is:\n0\n1\n");
            int numberOne = 0; // Int overflows at the 48th member of the Fibonacci sequence, we can use uLong or BigNumber if needed here!
            int numberTwo = 1; // We will keep numberOne to always be the smaller number
            for (int i = 3; i <= fNumber; i++)
            {
                numberOne += numberTwo; // We add numberTwo to numberOne
                // At this point numberOne is bigger than numberTwo, we want numberOne to always be the smaller, so we exchange them
                numberOne += numberTwo; // These 3 rows exchange values with no extra variable, very neat ;)
                numberTwo = numberOne - numberTwo;
                numberOne -= numberTwo;
                Console.Write("{0}\n", numberTwo);
            }
        }
	}
}

