// Write a program that reads two positive integer numbers and prints how many numbers p exist between them 
// such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;

class DivisionByFive
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int numberOne = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int numberTwo = int.Parse(Console.ReadLine());

        if (numberTwo < numberOne) // If numberTwo is smaller than numberOne, we exchange their values. This way, numberOne is always smaller than numberTwo!
        {
            numberOne += numberTwo;
            numberTwo = numberOne - numberTwo;
            numberOne -= numberTwo;
        }
        int numbersInBetween = 0;
        for (int i = numberOne; i <= numberTwo; i++)
        {
            if ((i % 5) == 0)
            {
                numbersInBetween++;
                // Console.Write(i + " ");
                // You can try uncommenting the Console.Write(i + " ") and try entering a big interval, like (800000, 0) 
                // It would show, all the numbers (X % 5 == 0) and see how much more time it would take for the program to complete!
            }
        }
        Console.WriteLine("\nThere are {0} numbers between {1} and {2} whose division by 5 is 0!", numbersInBetween, numberOne, numberTwo); 
    }
}

