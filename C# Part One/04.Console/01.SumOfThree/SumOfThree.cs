// Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class SumOfThree
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int numberOne = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int numberTwo = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int numberThree = int.Parse(Console.ReadLine());

        Console.WriteLine("The sum of {0}, {1} and {2} is {3}", numberOne, numberTwo, numberThree,
            numberOne + numberTwo + numberThree);
    }
}

