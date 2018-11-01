// * Write a program that finds the largest area of equal neighbor elements in a rectangular matrix and prints its size. 
// Example:
// Hint: you can use the algorithm "Depth-first search" or "Breadth-first search" (find them in Wikipedia).

using System;

class LargestAreaOfElements
{
    static int numberOfElements = 0;
    static int areaSize = 0;

    static void Main()
    {
        /*int[,] matrix = 
        {
            { 1, 3, 2, 2, 2, 4 },
            { 3, 3, 3, 2, 4, 4 },
            { 4, 3, 1, 2, 3, 3 },
            { 4, 3, 1, 3, 3, 1 },
            { 4, 3, 3, 3, 1, 1 },
        };*/

        int sizeRows = 0;
        int sizeCols = 0;

        while (sizeRows < 2)
        {
            Console.Write("Enter the size of the rows: ");
            sizeRows = int.Parse(Console.ReadLine());
        }
        while (sizeCols < 2)
        {
            Console.Write("Enter the size of the cols: ", sizeRows - 1, sizeRows + 1);
            sizeCols = int.Parse(Console.ReadLine());
        }

        int[,] matrix = new int[sizeRows, sizeCols];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("matrix[{0}][{1}] = ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        PrintMatrix(matrix);

        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                areaSize = 0;
                FindArea(matrix, rows, cols, 1);
                if (areaSize > numberOfElements)
                {
                    numberOfElements = areaSize;
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("The largest area of equal neighbouring elements has {0} elements!", numberOfElements);
    }

    // introWay - A variable that shows us which way we came from, so we don't enter it again! 
    //              1 - Left; 
    //              2 - Up; 
    //              3 - Right; 
    //              4 - Down;

    static void FindArea(int[,] matrix, int rows, int cols, int introWay) 
    {
        if ((cols != matrix.GetLength(1) - 1) && (matrix[rows, cols] == matrix[rows, cols + 1]) && (introWay != 3)) // Going Right
        {
            FindArea(matrix, rows, cols + 1, 1); // 1 - Comming from the left
        }
        if ((rows != 0) && (matrix[rows, cols] == matrix[rows - 1, cols]) && (introWay != 2)) // Going Up
        {
            FindArea(matrix, rows - 1, cols, 4); // 4 - Comming from the bottom
        }
        if ((cols != 0) && (matrix[rows, cols] == matrix[rows, cols - 1]) && (introWay != 1)) // Going Left
        {
            FindArea(matrix, rows, cols - 1, 3); // 3 - Comming from the right
        }
        if ((rows != matrix.GetLength(0) - 1) && (matrix[rows, cols] == matrix[rows + 1, cols]) && (introWay != 4)) // Going Down
        {
            FindArea(matrix, rows + 1, cols, 2); // 2 - Comming from the top
        }
        areaSize++;
    }

    static void PrintMatrix(int[,] matrix)
    {
        Console.WriteLine();
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,6}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

