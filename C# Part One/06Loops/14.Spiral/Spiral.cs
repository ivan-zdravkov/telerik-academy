// Write a program that reads a positive integer number N (N < 20) from console and outputs in the console the numbers 
// 1 ... N numbers arranged as a spiral. 
// Example for N = 4

using System;

class Spiral
{
	static void Main()
	{
        int size = 0;
        while ((size < 1) || (size > 20))
        {
            Console.Write("Enter a number [1; 20]: ");
            size = int.Parse(Console.ReadLine());
        }

        int[,] matrix = new int[size, size];
        int number = 1; // The number we are filling the matrix with
        int row = 0; // Current Row
        int col = 0; // Current Column
        int rightEnd = size - 1; // The right "wall" of the matrix
        int botEnd = size - 1; // The bottom "wall"of the matrix
        int leftEnd = 0; // The left "wall"of the matrix
        int topEnd = 0; // The top "wall"of the matrix

        // These walls are the positions that we can no longer write into. 
        // They "shrik" as each row is being filled with values

        while (true)
        {
            while (col <= rightEnd) // While the current column is not at the right "wall"
            {
                matrix[row, col] = number;
                number++;
                col++; // We are moving right (Row stays the same, column increases)
            }
            if (number == size * size + 1) // If we have filled in all the elements, we STOP
            {
                break;
            }
            col--; // Decreasing the column number, else we will else be outside the matrix
            row++; // We are going on a new row
            topEnd++; // And also shrinking the available matrix, one row from the top

            while (row <= botEnd)
            {
                matrix[row, col] = number;
                number++;
                row++; // We are moving down here
            }
            if (number == size * size + 1)
            {
                break;
            }
            row--; // Decrase row, to stay inside matrix
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
            row--; // New row
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
            col++; // New col
            leftEnd++;
        }
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write("{0,3} ", matrix[i,j]);
            }
            Console.WriteLine();
        }
	}
}

