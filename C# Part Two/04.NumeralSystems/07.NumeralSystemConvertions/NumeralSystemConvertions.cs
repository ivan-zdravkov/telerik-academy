// Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).
using System;

class NumeralSystemConvertions
{
    static void Main() // X -> Y
    {
        int numeralFrom = 0;
        while (!(numeralFrom >= 2 && numeralFrom <= 16))
        {
            Console.Write("Which numeral system are we converting FROM [2, 16]: ");
            numeralFrom = int.Parse(Console.ReadLine());
        }

        int numeralTo = 0;
        while (!(numeralTo >= 2 && numeralTo <= 16))
        {
            Console.Write("Which numeral system are we converting TO [2, 16]: ");
            numeralTo = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the number: ");
        string number = (Console.ReadLine()).ToUpper();
        bool isNegative = false;
        if (number[0] == '-')
        {
            isNegative = true;
        }

        string result;
        if (isNegative)
        {
            if (numeralFrom == 10)
            {
                result = "-" + FromDecimal(long.Parse(number), numeralTo);
            }
            result = "-" + FromDecimal(ToDecimal(number, numeralFrom), numeralTo);
        }
        else
        {
            if (numeralFrom == 10)
            {
                result = FromDecimal(long.Parse(number), numeralTo);
            }
            result = FromDecimal(ToDecimal(number, numeralFrom), numeralTo);
        }

        Console.WriteLine(result);
    }

    static long ToDecimal(string number, int numeralSystem)
    {
        long result = 0;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            int value;
            if (number[i] == 'A')
            {
                value = 10;
            }
            else if (number[i] == 'B')
            {
                value = 11;
            }
            else if (number[i] == 'C')
            {
                value = 12;
            }
            else if (number[i] == 'D')
            {
                value = 13;
            }
            else if (number[i] == 'E')
            {
                value = 14;
            }
            else if (number[i] == 'F')
            {
                value = 15;
            }
            else
            {
                value = int.Parse(number[i].ToString());
            }
            if (value >= numeralSystem)
            {
                Console.WriteLine("\nWRONG INPUT!");
                Console.WriteLine("There is a digit, that is not of the {0} numeral system!", numeralSystem);
                System.Environment.Exit(0);
            }
            result += value * NumeralPower((number.Length - 1) - i, numeralSystem);
        }
        return result;
    }

    static string FromDecimal(long number, int numeralSystem)
    {

        string result = "";
        while (number != 0)
        {
            result += ConvertToNumeral(number % numeralSystem);
            number /= numeralSystem;
        }
        return Reverse(result);
    }

    static int NumeralPower(int number, int numeralSystem)
    {
        int result = 1;
        for (int i = 0; i < number; i++)
        {
            result *= numeralSystem;
        }
        return result;
    }

    static string ConvertToNumeral(long number)
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

    static string Reverse(string stringToReverse)
    {
        char[] charArray = stringToReverse.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

