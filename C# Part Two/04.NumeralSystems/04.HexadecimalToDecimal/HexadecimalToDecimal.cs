// Write a program to convert hexadecimal numbers to their decimal representation
using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter the hexadecimal number: ");
        string hexNumber = Console.ReadLine();

        bool isNegative = false;
        if (hexNumber[0] == '-')
        {
             isNegative = true;
        }

        long number = 0;
        for (int i = 0; i < hexNumber.Length; i++)
        {
            if((i == 0) && isNegative)
            {
                continue;
            }
            else
            {
                long hexPower = 0;
                if (isNegative)
                {
                    hexPower = HexadecimalPower(i - 1); // If the first sign is "-", the number starts on the next symbol.
                }
                else
                {
                    hexPower = HexadecimalPower(i);
                }
                number += ConvertToDec(hexNumber[i].ToString()) * hexPower;
            }
        }

        if (isNegative)
        {
            number *= -1;
        }
        Console.WriteLine(number);

    }

    static long ConvertToDec(string hexNumber)
    {
        if (hexNumber[0] >= 97) // Making letters Capital
        {
            hexNumber = ((char)(hexNumber[0] - 32)).ToString();
        }

        switch (hexNumber)
        {
            case "0":
                return 0;
            case "1":
                return 1;
            case "2":
                return 2;
            case "3":
                return 3;
            case "4":
                return 4;
            case "5":
                return 5;
            case "6":
                return 6;
            case "7":
                return 7;
            case "8":
                return 8;
            case "9":
                return 9;
            case "A":
                return 10;
            case "B":
                return 11;
            case "C":
                return 12;
            case "D":
                return 13;
            case "E":
                return 14;
            case "F":
                return 15;
            default:
                Console.WriteLine("Wrong Input!");
                System.Environment.Exit(0);
                return -1;
        }
    }

    static long HexadecimalPower(int number)
    {
        long result = 1;
        for (int i = 0; i < number; i++)
        {
            result *= 16;
        }
        return result;
    }
}

