// Write a program to convert binary numbers to hexadecimal numbers (directly)
using System;
using System.Collections.Generic;

class BinaryToHexadecimal
{
    static void Main()
    {
        string binNumber = "0";

        Console.WriteLine("NB! The binary number must be multiple on 4");
        while ((binNumber.Length % 4) != 0)
        {
            Console.Write("Enter a binary number.: ");
            binNumber = Console.ReadLine();
        }

        List<string> hexNumber = new List<string>();

        for (int i = 0; i < binNumber.Length; i += 4)
        {
            string temp = binNumber[i].ToString() + binNumber[i + 1].ToString() + binNumber[i + 2].ToString() + binNumber[i + 3].ToString();
            hexNumber.Add(BinToHex(temp));
        }

        for (int i = 0; i < hexNumber.Count; i++)
        {
            Console.Write(hexNumber[i]);
        }
        Console.WriteLine("\nIf the first hexadecimal digit is >= 8, the number is negative! (First bit = 1)");
    }

    static string BinToHex(string binNumber)
    {
        switch (binNumber)
        {
            case "0000":
                return "0";
            case "0001":
                return "1";
            case "0010":
                return "2";
            case "0011":
                return "3";
            case "0100":
                return "4";
            case "0101":
                return "5";
            case "0110":
                return "6";
            case "0111":
                return "7";
            case "1000":
                return "8";
            case "1001":
                return "9";
            case "1010":
                return "A";
            case "1011":
                return "B";
            case "1100":
                return "C";
            case "1101":
                return "D";
            case "1110":
                return "E";
            case "1111":
                return "F";
            default:
                Console.WriteLine("Wrong Input!");
                System.Environment.Exit(0);
                return "ERROR";
        }
    }
}
