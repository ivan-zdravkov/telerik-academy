// Write a program that finds the greatest of given 5 variables.

using System;

class GreatestOfFive
{
	static void Main()
	{
        Console.Write("Enter variable number one: ");
        float numberOne = float.Parse(Console.ReadLine());
        Console.Write("Enter variable number two: ");
        float numberTwo = float.Parse(Console.ReadLine());
        Console.Write("Enter variable number three: ");
        float numberThree = float.Parse(Console.ReadLine());
        Console.Write("Enter variable number four: ");
        float numberFour = float.Parse(Console.ReadLine());
        Console.Write("Enter variable number five: ");
        float numberFive = float.Parse(Console.ReadLine());
        Console.WriteLine();

        float biggest = numberOne;
        if (numberTwo > biggest)
        {
            biggest = numberTwo;
        }
        if (numberThree > biggest)
        {
            biggest = numberThree;
        }
        if (numberFour > biggest)
        {
            biggest = numberFour;
        }
        if (numberFive > biggest)
        {
            biggest = numberFive;
        }

        Console.WriteLine("The biggest number is: {0}", biggest);
	}
}

