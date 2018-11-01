// Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
using System;

class LeapYearCheck
{
    static void Main()
    {
        Console.WriteLine("Enter a year to check if Leap!\nEnter '-1' to exit!\n");
        while (true)
        {
            int year = 0;
            while (!(year > 0 && year < 10000))
            {
                Console.Write("Enter a year: ");
                year = int.Parse(Console.ReadLine());
                if (year == -1)
                {
                    System.Environment.Exit(0);
                }
            }

            bool isLeap = DateTime.IsLeapYear(year);
            Console.WriteLine("The year {0} is {1}\n", year, isLeap ? "Leap" : "Not Leap");
        }
    }
}
