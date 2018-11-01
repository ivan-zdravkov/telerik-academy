// Write a program that fills and prints a matrix of size (n, n) as shown below: 
// (examples for n = 4)

using System;

class PrintMatrix
{
    static void Main()
    {
        int size = 0;
        while ((size < 1) || (size > 20))
        {
            Console.Write("Enter a number [1; 20]: ");
            size = int.Parse(Console.ReadLine());
        }

        int[,] currentMatrix = new int[size, size];

        currentMatrix = RowsFirstMatrix(size); // a
        Print(currentMatrix, size);

        currentMatrix = SFormMatrix(size); // b
        Print(currentMatrix, size);

        currentMatrix = DiagonalMatrix(size); // c
        Print(currentMatrix, size);

        currentMatrix = SpiralMatrix(size); // d
        Print(currentMatrix, size);
    }

    static int[,] RowsFirstMatrix(int size)
    {
        int [,] matrix = new int[size, size];
        int number = 1;
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                matrix[col, row] = number;
                number++;
            }
        }
        return matrix;
    }  

    static int[,] SFormMatrix(int size)
    {
        int [,] matrix = new int[size, size];
        int number = 1;
        for (int row = 0; row < size; row++)
        {
            if (row % 2 == 0) // If the column is even, we go down
            {
                for (int col = 0; col < size; col++)
                {
                    matrix[col, row] = number;
                    number++;
                }
            }
            else // If the column is odd, we go up
            {
                for (int j = size - 1; j >= 0; j--)
                {
                    matrix[j, row] = number;
                    number++;
                }
            }
        }
        return matrix;
    }   

    static int[,] DiagonalMatrix(int size)
    {
        int [,] matrix = new int[size, size];
        int number = 1;
        for (int row = size - 1; row >= 0; row--)
        {
            for (int col = 0; col < size - row; col++)
            {
                matrix[row + col, col] = number;
                number++;
            }
        }
        for (int row = 1; row < size; row++)
        {
            for (int col = 0; col < size - row; col++)
            {
                matrix[col, row + col] = number;
                number++;
            }
        }
        return matrix;
    }    

    static int[,] SpiralMatrix(int size)
    {
        int[,] matrix = new int[size, size];
        int number = 1; // The number we are filling the matrix with
        int row = 0; // Current Row
        int col = 0; // Current Column
        int rightEnd = size - 1; // The right "wall" of the matrix
        int botEnd = size - 1; // The bottom "wall"of the matrix
        int leftEnd = 0; // The left "wall" of the matrix
        int topEnd = 0; // The top "wall" of the matrix

        // These walls are the positions that we can no longer write into. 
        // They "shrik" as each row is being filled with values

        while (true)
        {
            while (row <= botEnd)
            {
                matrix[row, col] = number;
                number++;
                row++; // We are moving down (Col stays the same, Row increases)
            }
            if (number == size * size + 1) 
            {
                break; // If we have filled in all the elements, we STOP
            }
            row--; // We decrease row--, since now it is outside the matrix
            col++; // We move to the next col
            leftEnd++; // And also shrinking the available matrix, one col from the left

            while (col <= rightEnd)
            {
                matrix[row, col] = number;
                number++;
                col++; // Moving right here
            }
            if (number == size * size + 1) 
            {
                break;
            }
            col--; 
            row--; 
            botEnd--; 

            while (row >= topEnd)
            {
                matrix[row, col] = number;
                number++;
                row--; // Moving up here
            }
            if (number == size * size + 1)
            {
                break;
            }
            row++; // Increase row, to stay inside matrix
            col--; // New col
            rightEnd--;

            while (col >= leftEnd)
            {
                matrix[row, col] = number;
                number++;
                col--; // Moving left here
            }
            if (number == size * size + 1)
            {
                break;
            }
            col++; // Increase col, to stay inside matrix
            row++; // New row
            topEnd++;
        }
        return matrix;
    }

    static void Print(int[,] matrix, int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write("{0,3} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

