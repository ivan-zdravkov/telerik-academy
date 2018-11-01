// Write a program to calculate n! for each n in the range [1..100]. 
// Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 
using System;
using System.Numerics;

class Factoriel
{
    static void Main()
    {
        int[] numberArray = new int[10000];
        numberArray[0] = 1;

        for (int i = 2; i <= 100; i++)
        {
            Console.Write("[{0}!] = ", i);
            numberArray = multiplyArray(numberArray, i);
            PrintArray(numberArray);
        }

    }

    static int[] multiplyArray(int[] array, int number)
    {
        int[] result = new int[10000];

        BigInteger digitPower = 1;
        int numberIndex = 0;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if ((array[i] == 0) && (digitPower == 1))
            {
                continue;
            }
            else
            {
                int[] tempArray = new int[10000];
                BigInteger subSum = ((array[numberIndex] * digitPower) * number);
                numberIndex++;
                string tempString = Reverse(subSum.ToString());
                for (int j = 0; j < tempString.Length; j++)
                {
                    tempArray[j] = int.Parse(tempString[j].ToString());
                }
                digitPower *= 10;
                result = AddNumbers(result, tempArray);
            }
        }

        return result;
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

    static int[] AddNumbers(int[] numberOne, int[] numberTwo)
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
                break;
            }
        }
        return result;
    }

    private static void PrintArray(int[] result)
    {
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
                Console.Write(result[i]);
            }
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
