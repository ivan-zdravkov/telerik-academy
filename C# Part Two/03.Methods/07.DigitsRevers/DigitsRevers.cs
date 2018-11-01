using System;

class DigitsRevers
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The reversed number of {0} is {1}", number, Reverse(number));
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
}

