// Write a program that prints all the numbers from 1 to N.

using System;

class NumbersOneToN
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
            Console.WriteLine(i);
        }
	}
}

