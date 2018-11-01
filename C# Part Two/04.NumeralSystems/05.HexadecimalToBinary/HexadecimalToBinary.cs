// Write a program to convert hexadecimal numbers to binary numbers (directly).
using System;
using System.Collections.Generic;

class HexadecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter the hexadecimal number: ");
        string hexNumber = Console.ReadLine();

        List<string> binaryNumber = new List<string>();
            
        bool isNegative;
        if (hexNumber[0] == '-')
        {
            isNegative = true;
            binaryNumber.Add("1");
        }
        else 
        {
            isNegative = false;
            binaryNumber.Add("0");
        }

        for (int i = 0; i < hexNumber.Length
            ; i++)
        {
            if(isNegative)
            {
                if (i == 0)
                {
                    continue;
                }
                else
                {
                    binaryNumber.Add(HexToBinNegative(hexNumber[i].ToString()));
                }
            }
            else
            {
                binaryNumber.Add(HexToBinPossitive(hexNumber[i].ToString()));
            }
        }

        for (int i = 0; i < binaryNumber.Count; i++)
        {
            Console.Write(binaryNumber[i] + " ");
        }
        Console.WriteLine();
    }

    static string HexToBinPossitive(string hexNumber)
    {
        if (hexNumber[0] >= 97) // Making letters Capital
        {
            hexNumber = ((char)(hexNumber[0] - 32)).ToString();
        }

        switch (hexNumber)
        {
            case "0":
                return "0000";
            case "1":
                return "0001";
            case "2":
                return "0010";
            case "3":
                return "0011";
            case "4":
                return "0100";
            case "5":
                return "0101";
            case "6":
                return "0110";
            case "7":
                return "0111";
            case "8":
                return "1000";
            case "9":
                return "1001";
            case "A":
                return "1010";
            case "B":
                return "1011";
            case "C":
                return "1100";
            case "D":
                return "1101";
            case "E":
                return "1110";
            case "F":
                return "1111";
            default:
                Console.WriteLine("Wrong Input!");
                System.Environment.Exit(0);
                return "ERROR";
        }
    }

    static string HexToBinNegative (string hexNumber)
    {
        if (hexNumber[0] >= 97) // Making letters Capital
        {
            hexNumber = ((char)(hexNumber[0] - 32)).ToString();
        }

        switch (hexNumber)
        {
            case "0":
                return "1111";
            case "1":
                return "1110";
            case "2":
                return "1101";
            case "3":
                return "1100";
            case "4":
                return "1011";
            case "5":
                return "1010";
            case "6":
                return "1001";
            case "7":
                return "1000";
            case "8":
                return "0111";
            case "9":
                return "0110";
            case "A":
                return "0101";
            case "B":
                return "0100";
            case "C":
                return "0011";
            case "D":
                return "0010";
            case "E":
                return "0001";
            case "F":
                return "0000";
            default:
                Console.WriteLine("Wrong Input!");
                System.Environment.Exit(0);
                return "ERROR";
        }
    }
} 
