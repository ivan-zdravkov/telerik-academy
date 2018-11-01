// Write a program that reads a rectangular matrix of size N x M and finds in it the square 
// 3 x 3 that has maximal sum of its elements.

using System;

class RectangularMatrix
{
    static void Main()
    {
        /*int[,] matrix = 
        {
           { 01, 03, 05, 07, 09, 11},
           { 20, 22, 24, 26, 28, 30},
           { 80, 70, 60, 50, 40, 30},
           { 30, 30, 30, 30, 30, 30},
           { 15, 35, 55, 55, 35, 15},
        };*/

        int rows = 0;
        int cols = 0;
        
        while ((rows < 3) || (rows > 20))
        {
            Console.WriteLine("Enter the size of the rows [3, 20]");
            rows = int.Parse(Console.ReadLine());
        }
        while ((cols < 3) || (cols == rows) || (cols > 20))
        {
            Console.WriteLine("Enter the size of the cols [3, {0}]U[{1}, 20]", rows - 1, rows + 1);
            cols = int.Parse(Console.ReadLine());
        }

        int[,] matrix = new int[rows, cols];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("matrix[{0}][{1}] = ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        PrintMatrix(matrix);

        int size = 3; // We can change this size for different sized sectors ;)
        int[,] square = new int[size, size];
        square = GetSector(matrix, size);
        PrintMatrix(square);
    }

    private static int[,] GetSector(int[,] matrix, int size)
    {
        int maxSum = int.MinValue;
        int maxRow = 0;
        int maxCol = 0;
        for (int row = 0; row <= matrix.GetLength(0) - size; row++)
        {
            for (int col = 0;  col <= matrix.GetLength(1) - size; col++)
            {
                int sum = 0;
                for (int i = row ; i < row + size; i++)
                {
                    for (int j = col ; j < col + size; j++)
                    {
                        sum += matrix[i, j];
                    }
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxRow = row;
                    maxCol = col;
                }
            }
        }

        Console.WriteLine("The maximum sum is {0}", maxSum);
        int[,] square = new int[size, size];
        for (int row = 0; row < square.GetLength(0); row++)
        {
            for (int col = 0; col < square.GetLength(1); col++)
            {
                square[row, col] = matrix[maxRow + row, maxCol + col];
            }
        }
        return square;
    }

    private static void PrintMatrix(int[,] matrix)
    {
        Console.WriteLine();
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,6}", matrix[row, col]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

