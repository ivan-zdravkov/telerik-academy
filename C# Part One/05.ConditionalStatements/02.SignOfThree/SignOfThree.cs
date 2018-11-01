// Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

using System;

class SignOfThree
{
	static void Main()
	{
        Console.Write("Number one: ");
        float numberOne = float.Parse(Console.ReadLine());
        Console.Write("Number two: ");
        float numberTwo = float.Parse(Console.ReadLine());
        Console.Write("Number three: ");
        float numberThree = float.Parse(Console.ReadLine());
        Console.WriteLine();

        if (numberOne == 0 || numberTwo == 0 || numberThree == 0) // One of the numbers is 0
        {
            Console.WriteLine("The product of {0}, {1} and {2} is 0!", numberOne, numberTwo, numberThree);
        }
        else if ((numberOne > 0 && numberTwo > 0 && numberThree > 0) || // 1, 2 and 3 are possitive
                 (numberOne < 0 && numberTwo < 0 && numberThree > 0) || // 1 and 2 are negative, 3 is possitive
                 (numberTwo < 0 && numberThree < 0 && numberOne > 0) || // 2 and 3 are negative, 1 is possitive
                 (numberOne < 0 && numberThree < 0 && numberTwo > 0))   // 1 and 3 are negative, 2 is possitive
        {
            Console.WriteLine("The product of {0}, {1} and {2} is POSSITIVE!", numberOne, numberTwo, numberThree);
        }
        else
        {
            Console.WriteLine("The product of {0}, {1} and {2} is NEGATIVE!", numberOne, numberTwo, numberThree);
        }
	}
}

