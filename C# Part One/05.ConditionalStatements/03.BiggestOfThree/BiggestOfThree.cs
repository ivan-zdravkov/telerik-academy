//Write a program that finds the biggest of three integers using nested if statements

using System;

class BiggestOfThree
{
	static void Main()
	{
        Console.Write("Number one: ");
        int numberOne = int.Parse(Console.ReadLine());
        Console.Write("Number two: ");
        int numberTwo = int.Parse(Console.ReadLine());
        Console.Write("Number three: ");
        int numberThree = int.Parse(Console.ReadLine());
        int biggest = numberOne;
        Console.WriteLine();

        if (numberTwo > biggest)
        {
            if (numberThree > numberTwo)
            {
                biggest = numberThree;
            }
            else
            {
                biggest = numberTwo;
            }
        }
        else if (numberThree > biggest)
        {
            biggest = numberThree;
        }

        Console.WriteLine("The biggest number is {0}", biggest);
	}
}

