// Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:

using System;

class Matrix
{
	static void Main()
	{
        int n = 0;
        while (n < 1 || n > 20)
        {
            Console.Write("Enter a number [1; 20]: ");
            n = int.Parse(Console.ReadLine());
        }
        int[,] matrix = new int[n, n];
        int startNumber;
        for (int i = 0; i < n; i++)
        {
            startNumber = i + 1;
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = startNumber;
                startNumber++;
                Console.Write("{0,3}", matrix[i, j]);
            }
            Console.WriteLine();
        }
	}
}

