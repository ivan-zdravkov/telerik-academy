// Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
// If an invalid number or non-number text is entered, the method should throw an exception. 
// Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;
using System.Collections.Generic;

class ReadingNumbers
{
    static void Main(string[] args)
    {
        int numberOfValues = 10;
        int minRange = 1;
        int maxRange = 100;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter {0} values!", numberOfValues);
        while (numbers.Count < numberOfValues)
        {
            try
            {
                for (int i = numbers.Count; i < numberOfValues; i++)
                {
                    numbers.Add(ReadNumber(minRange, maxRange));
                    minRange = numbers[i];
                }
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {
                Console.WriteLine(outOfRange.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            finally
            {
                Console.WriteLine();
            }
        }

        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    static int ReadNumber(int start, int end)
    {
        int numberRead;
        Console.Write("Enter a number in the range ({0}, {1}): ", start, end);
        try
        {
            numberRead = int.Parse(Console.ReadLine());
            if (!(numberRead > start && numberRead < end))
            {
                throw new ArgumentOutOfRangeException();
            }
            return numberRead;
        }
        catch (FormatException)
        {
            throw new FormatException("The string that was read was not a number!");
        }
    }
}
