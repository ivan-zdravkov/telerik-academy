// Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.Write("Enter how many numbers you want to add: ");
        int n = int.Parse(Console.ReadLine());
        int number = 0;
        int sum = 0; // The program works with integer numbers, it can work with floating point ones, just as easily!
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number {0}: ", i+1);
            number = int.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("The sum of the numbers is {0}!", sum);
    }
}

