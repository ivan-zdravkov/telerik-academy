// You are given a sequence of positive integer values written into a string, separated by spaces. 
// Write a function that reads these values from given string and calculates their sum. 
// Example: string = "43 68 9 23 318"  result = 461
using System;

class StringSeparationSum
{
    static void Main()
    {
        string numbers = "";
        bool stringValid = false;

        while (!stringValid)
        {
            Console.WriteLine("Enter a string of numbers and spaces only!");
            Console.Write("Enter the string: ");
            numbers = Console.ReadLine();

            stringValid = StringVerify(numbers);
            Console.WriteLine();
        }

        Console.WriteLine("The sum of all the numbers is: {0}", SplitAndAdd(numbers));

    }

    static int SplitAndAdd(string numbers)
    {
        int result = 0;
        string[] values = numbers.Split(' ');

        for (int i = 0; i < values.Length; i++)
        {
            result += int.Parse(values[i]);
        }

        return result;
    }

    static bool StringVerify (string numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (
                    numbers[i] == '0' || 
                    numbers[i] == '1' || 
                    numbers[i] == '2' || 
                    numbers[i] == '3' || 
                    numbers[i] == '4' || 
                    numbers[i] == '5' || 
                    numbers[i] == '6' || 
                    numbers[i] == '7' || 
                    numbers[i] == '8' || 
                    numbers[i] == '9' || 
                    numbers[i] == '-' || 
                    numbers[i] == ' ' )
            {
                continue;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}
