using System;
using System.Collections.Generic;

class AddingIntegersAsArrays
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        string tempOne = Console.ReadLine();
        Console.Write("Enter the second number: ");
        string tempTwo = Console.ReadLine();

        tempOne = Reverse(tempOne);
        tempTwo = Reverse(tempTwo);

        int[] numberOne = new int[10000];
        int[] numberTwo = new int[10000];

        for (int i = 0; i < tempOne.Length; i++)
        {
            numberOne[i] = int.Parse(tempOne[i].ToString());
        }

        for (int i = 0; i < tempTwo.Length; i++)
        {
            numberTwo[i] = int.Parse(tempTwo[i].ToString());
        }

        int resultLength = 0;
        int[] result = AddNumbers(numberOne, numberTwo, out resultLength);

        Print(tempOne, tempTwo, numberOne, numberTwo, resultLength, result);
       
    }

    static string Reverse(string text)
    {
        char[] charArray = text.ToCharArray();
        string reverse = String.Empty;
        for (int i = charArray.Length - 1; i > -1; i--)
        {
            reverse += charArray[i];
        }
        return reverse;
    }

    static void Print(string tempOne, string tempTwo, int[] numberOne, int[] numberTwo, int resultLength, int[] result)
    {
        if (tempOne.Length < result.Length)
        {
            Console.Write(new String(' ', resultLength - tempOne.Length + 1));
        }
        PrintResult(numberOne);
        Console.WriteLine("+");
        if (tempTwo.Length < result.Length)
        {
            Console.Write(new String(' ', resultLength - tempTwo.Length + 1));
        }
        PrintResult(numberTwo);
        Console.WriteLine("=");
        Console.Write(" ");
        PrintResult(result);
    }

    private static void PrintResult(int[] arrayToPrint)
    {
        int flagNumberEntry = 0;
        for (int i = arrayToPrint.Length - 1; i >= 0; i--)
        {
            if ((arrayToPrint[i] == 0) && (flagNumberEntry == 0))
            {
                continue;
            }
            else
            {
                flagNumberEntry = 1;
                Console.Write(arrayToPrint[i]);
            }
        }
        Console.WriteLine();
    }

    static int[] AddNumbers(int[] numberOne, int[] numberTwo, out int resultLength)
    {
        int[] result = new int[10000];
        int transfer = 0;
        int temp = 0;

        for (int i = 0; i < 10000; i++)
        {
            temp = numberOne[i] + numberTwo[i] + transfer;
            if (temp == 0)
            {
                continue;
            }
            if (temp > 9)
            {
                result[i] = temp % 10;
                transfer = temp / 10;
            }
            else
            {
                result[i] = temp % 10;
                transfer = 0;
            }
        }
        resultLength = 0;
        int flagNumberEntry = 0;
        for (int i = result.Length - 1; i >= 0; i--)
        {
            if ((result[i] == 0) && (flagNumberEntry == 0))
            {
                continue;
            }
            else
            {
                flagNumberEntry = 1;
                resultLength = i + 1;
                break;
            }
        }
        return result;
    }
}

