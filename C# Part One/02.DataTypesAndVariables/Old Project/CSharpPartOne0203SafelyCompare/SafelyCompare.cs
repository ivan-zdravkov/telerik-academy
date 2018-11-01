//Write a program that safely compares floating-point numbers with precision of 0.000001. 
//Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true
using System;

class SafelyCompare
{
    static void Main()
    {
        Console.Write("Enter the first number:");
        decimal number1 = decimal.Parse(Console.ReadLine());
        Console.Write("Enter the second number:");
        decimal number2 = decimal.Parse(Console.ReadLine());
        // The method Math.Abs() gives the abosolute value of the difference of the 2 variables 
        // and checks whether the difference in the values is less than the precission.
        // If so, the Numbers are equal. If not they are not.
        // I use decimal, since it works in every case!
        if (Math.Abs(number1 - number2) <= 0.0000001M) 
            Console.WriteLine("The numbers are equal!");
        else
            Console.WriteLine("The numbers are not equal!");
    }
}

