// Write a program to convert decimal numbers to their hexadecimal representation
using System;
using System.Collections.Generic;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        long number = long.Parse(Console.ReadLine());
        bool isNegative = (number < 0);

        if (isNegative)
        {
            number *= -1; // Making it possitive for the time being
        }

        List<string> hexNumber = new List<string>();
        while (number != 0)
        {
            hexNumber.Add(ConvertToHex(number % 16));
            number /= 16;
        }
        if (isNegative)
        {
            hexNumber.Add("-");
        }

        PrintHexNumber(hexNumber);
    }

    private static void PrintHexNumber(List<string> hexNumber)
    {
        for (int i = hexNumber.Count - 1; i >= 0; i--)
        {
            Console.Write(hexNumber[i]);
        }
        Console.WriteLine();
    }

    static string ConvertToHex(long number)
    {
        switch (number)
        {
            case 0:
                return "0";
            case 1:
                return "1";
            case 2:
                return "2";
            case 3:
                return "3";
            case 4:
                return "4";
            case 5:
                return "5";
            case 6:
                return "6";
            case 7:
                return "7";
            case 8:
                return "8";
            case 9:
                return "9";
            case 10:
                return "A";
            case 11:
                return "B";
            case 12:
                return "C";
            case 13:
                return "D";
            case 14:
                return "E";
            case 15:
                return "F";
            default:
                Console.WriteLine("Wrong Input!");
                return "ERROR";
        }     
    }
}

