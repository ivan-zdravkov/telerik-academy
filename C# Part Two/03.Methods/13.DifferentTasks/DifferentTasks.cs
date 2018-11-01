// Write a program that can solve these tasks:
// 1/Reverses the digits of a number
// 2/Calculates the average of a sequence of integers
// 3/Solves a linear equation a * x + b = 0
// Create appropriate methods.
// Provide a simple text-based menu for the user to choose which task to solve.
// Validate the input data:
// 1/The decimal number should be non-negative
// 2/The sequence should not be empty
// 3/a should not be equal to 0 --> Implemented in the Equation method!
using System;

class DifferentTasks
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Which task you'd like solving ?");
            Console.WriteLine("1. Reverse the digits of a number.");
            Console.WriteLine("2. Calculate the average of a sequence of integers.");
            Console.WriteLine("3. Solve a linear equation.");
            Console.WriteLine("0. EXIT");
            int choice = 0;
            do
            {
                Console.Write("\nMake your choice: ");
                choice = int.Parse(Console.ReadLine());
            } while (choice != 0 && choice != 1 && choice != 2 && choice != 3);
            switch (choice)
            {
                case 0:
                    return;
                case 1:
                    {
                        Console.Write("\nEnter a number to reverse: ");
                        int number = int.Parse(Console.ReadLine());
                        if (validateNumber(number))
                        {
                            number = Reverse(number);
                            Console.WriteLine("The reversed number is:    {0}\n", number);
                        }
                        else
                        {
                            Console.WriteLine("ERROR! The number is negative");
                        }
                        break;
                    }
                case 2:
                    {
                        int size = 0;
                        while (size < 1)
                        {
                            Console.Write("\nHow many numbers you are adding: ");
                            size = int.Parse(Console.ReadLine());
                        }
                        int[] array = new int[size];
                        for (int i = 0; i < array.Length; i++)
                        {
                            Console.Write("Enter array[{0}]: ", i);
                            array[i] = int.Parse(Console.ReadLine());
                        }
                        if (validateSequence(array))
                        {
                            decimal average = Average(array);
                            Console.WriteLine("\nThe everage of the integers in the array is {0, 2}\n", average);
                        }
                        else
                        {
                            Console.WriteLine("ERROR! Empty array!");
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Solving linear equation a * x + b = 0");
                        Console.Write("Enter a: ");
                        decimal a = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter b: ");
                        decimal b = decimal.Parse(Console.ReadLine());
                        decimal result = SolveEquasion(a, b);
                        if (result == 0)
                        {

                        }
                        else if (result == decimal.MaxValue)
                        {
                            Console.WriteLine("\nEvery x is a solution!\n");
                        }
                        else if (result == decimal.MinValue)
                        {
                            Console.WriteLine("\nThere is no solution!\n");
                        }
                        else
                        {
                            Console.WriteLine("\nThe solution is: x = {0, 2}!\n", result);
                        }
                        break;
                    }
                default:
                    break;
            }
            Console.WriteLine(new string('-', 80));
        };
    }

    static bool validateNumber(int number)
    {
        if (number >= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static bool validateSequence(int[] array)
    {
        bool full = false;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 0)
            {
                full = true;
            }
        }
        return full;
    }

    static int Reverse(int number)
    {
        bool possitive = true;
        if (number < 0)
        {
            possitive = false;
            number = Math.Abs(number);
        }
        int result = 0;
        int numberOfDigits = 0;
        int indexer = 1;

        while (number / indexer > 0)
        {
            indexer *= 10;
            numberOfDigits++; // Getting the number of Digits
        }

        indexer = 1;

        int[] array = new int[numberOfDigits];
        for (int i = 0; i < numberOfDigits; i++) // Filling in the array with the reversed digits of the number
        {
            indexer *= 10;
            array[i] = number % indexer;
            array[i] /= (indexer / 10);
        }

        for (int i = 0; i < numberOfDigits; i++)
        {
            result += array[i] * (indexer / 10); // Reconstructing the reversed result
            indexer /= 10;
        }

        if (possitive)
        {
            return result;
        }
        else
        {
            return -result;
        }
    }

    static decimal Average(int[] array)
    {
        decimal sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum / array.Length;
    }

    static decimal SolveEquasion(decimal a, decimal b)
    {
        if (b == 0)
        {
            if (a == 0)
            {
                return decimal.MaxValue;
            }
            else
            {
                return 0;
            }
        }
        else
        {
            if (a == 0)
            {
                return decimal.MinValue;
            }
            else
            {
                return (-b / a);
            }
        }
    }
}

