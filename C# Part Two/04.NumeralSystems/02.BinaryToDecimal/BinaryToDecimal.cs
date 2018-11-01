// Write a program to convert binary numbers to their decimal representation
using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter the binary number: ");
        string binaryNumber = Console.ReadLine();
        
        bool isNegative = SignCheck(binaryNumber);
        int number = 0;
        for (int i = binaryNumber.Length - 1; i > 0; i--)
        {
            if ((binaryNumber[i] != '0') && (binaryNumber[i] != '1'))
            {
                WrongInput();
            }
            else
            {
                number += (int.Parse(binaryNumber[i].ToString()) * BinaryPower((binaryNumber.Length - 1) - i));
            }
        }

        if (isNegative)
        {
            number = BinaryPower(binaryNumber.Length - 1) - number;
            number *= -1;
        }
        Console.WriteLine(number);
    }

    private static bool SignCheck(string binaryNumber)
    {
        bool isNegative = false;
        if (binaryNumber[0] == '1')
        {
            isNegative = true;
        }
        else if (binaryNumber[0] == '0')
        {
            isNegative = false;
        }
        else
        {
            WrongInput();
        }
        return isNegative;
    }

    static void WrongInput()
    {
        Console.WriteLine("WRONG INPUT!");
        Console.WriteLine("Terminating application...");
        System.Environment.Exit(0);
    }

    static int BinaryPower(int number)
    {
        int result = 1;
        for (int i = 0; i < number; i++)
        {
            result *= 2;
        }
        return result;
    }
}

