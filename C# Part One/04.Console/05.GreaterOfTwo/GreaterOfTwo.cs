// Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

class GreaterOfTwo
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        float numberOne = float.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        float numberTwo = float.Parse(Console.ReadLine());

        float greaterNumber;
        greaterNumber = Math.Max(numberOne, numberTwo);
        //greaterNumber = numberOne > numberTwo ? numberOne : numberTwo;

        Console.WriteLine("\n{0} is the greater of {1} and {2}!\n", greaterNumber, numberOne, numberTwo);
    }
}

