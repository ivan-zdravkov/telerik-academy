// Write a method GetMax() with two parameters that returns the bigger of two integers. 
// Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;

class GetMaxClass
{
    static void Main()
    {
        Console.Write("Enter the first  integer: ");
        int integerOne = int.Parse(Console.ReadLine());
        Console.Write("Enter the second integer: ");
        int integerTwo = int.Parse(Console.ReadLine());
        Console.Write("Enter the third  integer: ");
        int integerThree = int.Parse(Console.ReadLine());

        int biggest = GetMax(integerOne, integerTwo);
        biggest = GetMax(biggest, integerThree);
        Console.WriteLine("\nThe biggest integer is: {0}\n", biggest);
    }

    static int GetMax(int numberOne, int numberTwo)
    {
        if (numberOne > numberTwo)
        {
            return numberOne;
        }
        else
        {
            return numberTwo;
        }
    }
}

