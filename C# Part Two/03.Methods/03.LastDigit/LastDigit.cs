// Write a method that returns the last digit of given integer as an English word. 
// Examples: 512  "two", 1024  "four", 12309  "nine".
using System;

class LastDigit
{
    static void Main(string[] args)
    {
        Console.Write("Enter an integer: ");
        int integer = int.Parse(Console.ReadLine());
        string lastDigit = GetLastDigit(integer);
        if (lastDigit != null)
        {
            Console.WriteLine("The last digit is {0}", lastDigit);
        }
        else
        {
            Console.WriteLine("ERROR");
        }
    }

    static string GetLastDigit(int number)
    {
        string lastDigit = null;
        if (number < 0)
        {
            number *= -1;
        }
        int lastDigitInteger = number % 10;
        switch (lastDigitInteger)
        {
            case 0:
                lastDigit = "zero";
                break;
            case 1:
                lastDigit = "one";
                break;
            case 2:
                lastDigit = "two";
                break;
            case 3:
                lastDigit = "three";
                break;
            case 4:
                lastDigit = "four";
                break;
            case 5:
                lastDigit = "five";
                break;
            case 6:
                lastDigit = "six";
                break;
            case 7:
                lastDigit = "seven";
                break;
            case 8:
                lastDigit = "eight";
                break;
            case 9:
                lastDigit = "nine";
                break;
            default:
                lastDigit = null;
                break;
        }
        return lastDigit;
    }
}
