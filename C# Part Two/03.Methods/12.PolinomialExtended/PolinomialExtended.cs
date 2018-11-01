// Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
// x2 + 5 = 1x2 + 0x + 5 
// Extend the program to support also subtraction and multiplication of polynomials.
using System;

class PolinomialExtended
{
    static void Main()
    {
        string[] polinomOne = new string[100];
        string[] polinomTwo = new string[100];
        string[] resultPolinom = new string[100];

        string stringPolinomOne = "2x2 + 4x1 + 1x0";
        string stringPolinomTwo = "1x2 + 2x1 - 4x0";

        /*Console.WriteLine("This program adds, multiplies and substracts 2 polinoms. Enter small parameters!");
        Console.Write("Input the polinoms in the following way: ");
        Console.WriteLine("2x^2 - 8x + 5 --> 2x2 - 8x1 + 5x0");
        Console.Write("Enter Polinom One: ");
        string stringPolinomOne = Console.ReadLine();
        Console.Write("Enter Polinom Two: ");
        string stringPolinomTwo = Console.ReadLine();*/

        polinomOne = CreatePolinomArray(stringPolinomOne);
        polinomTwo = CreatePolinomArray(stringPolinomTwo);

        AddPolinoms(polinomOne, polinomTwo, resultPolinom);
        PrintPolinom(resultPolinom);
        
        MultiplyPolinoms(polinomOne, polinomTwo, resultPolinom);
        PrintPolinom(resultPolinom);
    }

    static void MultiplyPolinoms(string[] polinomOne, string[] polinomTwo, string[] resultPolinom)
    {
        int[] temp = new int[100];
        for (int i = 0; i < polinomOne.Length; i++)
        {
            if (polinomOne[i] != null)
            {
                for (int j = 0; j < polinomTwo.Length; j++)
                {
                    if (polinomTwo[j] != null)
                    {
                        temp[i + j] += (int.Parse(polinomOne[i]) * int.Parse(polinomTwo[j]));
                    }
                }
            }
        }
        for (int i = 0; i < temp.Length; i++)
        {
            if (temp[i] == 0)
            {
                resultPolinom[i] = "";
            }
            else
            {
                resultPolinom[i] = temp[i].ToString();
            }
        }
    }

    private static void AddPolinoms(string[] polinomOne, string[] polinomTwo, string[] resultPolinom)
    {
        int number = int.Parse(polinomTwo[0]);

        for (int i = resultPolinom.Length - 1; i >= 0; i--)
        {
            if (polinomOne[i] == null && polinomTwo[i] == null)
            {
                resultPolinom[i] = "";
            }
            else if (polinomOne[i] == null)
            {
                resultPolinom[i] = polinomTwo[i];
            }
            else if (polinomTwo[i] == null)
            {
                resultPolinom[i] = polinomOne[i];
            }
            else
            {
                int temp = 0;
                temp = int.Parse(polinomOne[i]) + int.Parse(polinomTwo[i]);
                resultPolinom[i] = temp.ToString();
            }
        }
    }

    static string[] CreatePolinomArray(string polinom)
    {
        string[] tempPolinom = new string[100];
        int firstNumber = 1;
        try
        {
            for (int i = 0; i < polinom.Length; i++)
            {
                if (polinom[i] == 'x')
                {
                    if (firstNumber == 1)
                    {
                        tempPolinom[int.Parse(polinom[i + 1].ToString())] = polinom[i - 1].ToString();
                        firstNumber = 0;
                    }
                    else
                    {
                        if (polinom[i - 3] == '+')
                        {
                            tempPolinom[int.Parse(polinom[i + 1].ToString())] = polinom[i - 1].ToString();
                        }
                        else if (polinom[i - 3] == '-')
                        {
                            tempPolinom[int.Parse(polinom[i + 1].ToString())] = "-" + polinom[i - 1].ToString();
                        }
                    }
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("WRONG INPUT");
            Environment.Exit(0);
        }
        return tempPolinom;
    }

    static int[] AddPolinoms(int[] numberOne, int[] numberTwo)
    {
        int[] result = new int[100];
        int transfer = 0;
        int temp = 0;

        for (int i = 0; i < 100; i++)
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

    private static void PrintPolinom(string[] resultPolinom)
    {
        for (int i = resultPolinom.Length - 1; i >= 0; i--)
        {
            if (resultPolinom[i] != "")
            {
                Console.Write("{0}x{1} ", resultPolinom[i], i);
                if ((i > 0) && (resultPolinom[i - 1][0] != '-'))
                {
                    Console.Write("+ ");
                }
            }
        }
        Console.WriteLine();
    }
}

