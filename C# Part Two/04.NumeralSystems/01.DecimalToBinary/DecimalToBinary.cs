// Write a program to convert decimal numbers to their binary representation
using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine());

        int[] binaryNumber = new int[32];
        for (int i = 0; i < 32; i++)
        {
            binaryNumber[i] = 0;
        }

        List<int> binaryList = new List<int>();
        ConvertToBinary(number, binaryNumber, binaryList);
        
        for (int i = 0; i < binaryList.Count; i++)
        {
            binaryNumber[i] = binaryList[i];
        }
        for (int i = binaryNumber.Length - 1; i >= 0; i--)
        {
            Console.Write(binaryNumber[i]);
        }
        Console.WriteLine();
    }

    private static void ConvertToBinary(int number, int[] binaryNumber, List<int> binaryList)
    {
        if (number > 0)
        {
            while (number != 0)
            {
                binaryList.Add(number % 2);
                number /= 2;
            }
        }
        else
        {
            binaryNumber[31] = 1;
            number = int.MinValue - number;
            number *= -1;
            while (number != 0)
            {
                binaryList.Add(number % 2);
                number /= 2;
            }
        }
    }
}

