// Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

using System;

class NotDividedThreeAndSeven
{
    static void Main()
    {
        int number = 0;
        while (number < 1)
        {
            Console.Write("Enter an integer number, larger than 1: ");
            number = int.Parse(Console.ReadLine());
        }
        for (int i = 1; i <= number; i++)
        {
            if (!((i % 3 == 0) && (i % 7 == 0)))
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}