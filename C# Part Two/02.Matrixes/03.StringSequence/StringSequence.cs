// We are given a matrix of strings of size N x M. Sequences in the matrix we define as 
// sets of several neighbor elements located on the same line, column or diagonal. 
// Write a program that finds the longest sequence of equal strings in the matrix.

using System;

class StringSequence
{
    static void Main()
    {
        // This solution works with all sizes of strings. 
        // We are using single character for better visualisation
        //
        // This is the hard coded matrix initialization. 
        // Play around the matrix, to see different results, or uncomment the console matrix initialization algorithm.

        string[,] matrix = 
        {
            { "a", "b", "b", "a", "e", "f", "a" },
            { "d", "t", "t", "c", "s", "y", "s" },
            { "f", "a", "s", "s", "s", "t", "s" },
            { "a", "a", "s", "b", "b", "b", "b" },
            { "s", "s", "t", "a", "s", "a", "a" },
            { "s", "e", "f", "f", "f", "f", "f" },
        };

        /*int sizeRows = 0;
        int sizeCols = 0;
        while ((sizeRows < 1) || (sizeCols > 20))
        {
            Console.Write("Enter number of rows [1; 20]: ");
            sizeRows = int.Parse(Console.ReadLine());
        }
        while ((sizeCols < 1) || (sizeCols > 20))
        {
            Console.Write("Enter number of cols [1; 20]: ");
            sizeCols = int.Parse(Console.ReadLine());
        }
        string[,] matrix = new string[sizeRows, sizeCols];

        Console.WriteLine();
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("Enter matrix[{0}][{1}]: ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
            Console.WriteLine();
        }*/

        int maxLength = 0;     // The length of the maximum found sequence
        int currentLength = 0; // The length of the current sequence we are testing
        int startRow = 0;      // The row where the sequence starts
        int startCol = 0;      // The col where the sequence starts
        int wayOfMovement = 0; // The orientation of the sequence
                                  // 1 - horizonta; 
                                  // 2 - vertical; 
                                  // 3 - right \ diagonal; 
                                  // 4 - left / diagonal;

        for (int row = 0; row < matrix.GetLength(0); row++) // For each element we are checking for a:
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                // horizontal sequence
                if ((col != (matrix.GetLength(1) - 1)) && (matrix[row, col] == matrix[row, col + 1])) 
                {
                    currentLength = GetHorizontalSequence(matrix, row, col); // This gives us the length of the sequence
                    if (currentLength > maxLength) // If the current length is the longest
                    {
                        maxLength = currentLength; // We overwrite the previous length
                        startRow = row; // We save the current row, to be the start row of the sequence
                        startCol = col; // We save the current col, to be the start col of the sequence
                        wayOfMovement = 1; // horizontal (This sets the way the sequence goes)
                    }
                }

                // vertical sequence
                if ((row != (matrix.GetLength(0) - 1)) && (matrix[row, col] == matrix[row + 1, col]))
                {
                    currentLength = GetVerticalSequence(matrix, row, col);
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        startRow = row;
                        startCol = col;
                        wayOfMovement = 2; // vertical
                    }
                }

                // right diagonal sequence
                if ((col != (matrix.GetLength(1) - 1)) && (row != (matrix.GetLength(0) - 1)) && (matrix[row, col] == matrix[row + 1, col + 1]))
                {
                    currentLength = GetRightDiagonal(matrix, row, col);
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        startRow = row;
                        startCol = col;
                        wayOfMovement = 3; // right \ diagonal
                    }
                }

                // left diagonal sequence
                if ((row != (matrix.GetLength(0) - 1)) && (col != 0) && (matrix[row, col] == matrix[row + 1, col - 1]))
                {
                    currentLength = GetLeftDiagonal(matrix, row, col);
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        startRow = row;
                        startCol = col;
                        wayOfMovement = 4; // left / diagonal
                    }
                }
            }
        }

        PrintSequence(matrix, startRow, startCol, maxLength, wayOfMovement);
    }

    private static int GetHorizontalSequence(string[,] matrix, int row, int col)
    {
        int length = 1;
        while ((col < matrix.GetLength(1) - 1) && (matrix[row, col] == matrix[row, col + 1]))
        {
            length++;
            col++;
        }
        return length;
    }

    private static int GetVerticalSequence(string[,] matrix, int row, int col)
    {
        int length = 1;
        while ((row < matrix.GetLength(0) - 1) && (matrix[row, col] == matrix[row + 1, col]))
        {
            length++;
            row++;
        }
        return length;
    }
    private static int GetRightDiagonal(string[,] matrix, int row, int col)
    {
        int length = 1;
        while (((col < matrix.GetLength(1) - 1) && (row < matrix.GetLength(0) - 1)) && (matrix[row, col] == matrix[row + 1, col + 1]))
        {
            length++;
            row++;
            col++;
        }
        return length;
    }

    private static int GetLeftDiagonal(string[,] matrix, int row, int col)
    {
        int length = 1;
        while (((col != 0) && (row != (matrix.GetLength(0) - 1))) && (matrix[row, col] == matrix[row + 1, col - 1]))
        {
            length++;
            row++;
            col--;
        }
        return length;
    }

    private static void PrintSequence(string[,] matrix, int startRow, int startCol, int maxLength, int wayOfMovement)
    {
        if (wayOfMovement == 0)
        {
            Console.WriteLine("There are no string sequences in the matrix!");
            return;
        }

        Console.WriteLine("The longest string word sequence in the matrix is \"{0}\"", matrix[startRow, startCol]);
        Console.WriteLine("For better visualisation, we only visualise the first letter of the word!\n");

        if (wayOfMovement == 1) // Horizontal
        {
            PrintHorizontal(matrix, startRow, ref startCol, ref maxLength);
        }
        else if (wayOfMovement == 2) // Vertical
        {
            PrintVertical(matrix, ref startRow, startCol, ref maxLength);
        }
        else if (wayOfMovement == 3) // \ Diagonal
        {
            PrintRightDiagonal(matrix, ref startRow, ref startCol, ref maxLength);
        }
        else if (wayOfMovement == 4) // / Diagonal
        {
            PrintLeftDiagonal(matrix, ref startRow, ref startCol, ref maxLength);
        }
        else
        {
            Console.WriteLine("ERROR!");
        }
        Console.WriteLine();
    }

    private static void PrintHorizontal(string[,] matrix, int startRow, ref int startCol, ref int maxLength)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if ((row == startRow) && (col == startCol))
                {
                    if (maxLength > 0)
                    {
                        startCol++;
                        maxLength--;
                        Console.Write(" {0}", matrix[row, col].Substring(0, 1));
                    }
                    else
                    {
                        Console.Write(" -");
                    }
                }
                else
                {
                    Console.Write(" -");
                }
            }
            Console.WriteLine();
        }
    }

    private static void PrintVertical(string[,] matrix, ref int startRow, int startCol, ref int maxLength)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if ((row == startRow) && (col == startCol))
                {
                    if (maxLength > 0)
                    {
                        startRow++;
                        maxLength--;
                        Console.Write(" {0}", matrix[row, col].Substring(0, 1));
                    }
                    else
                    {
                        Console.Write(" -");
                    }
                }
                else
                {
                    Console.Write(" -");
                }
            }
            Console.WriteLine();
        }
    }

    private static void PrintRightDiagonal(string[,] matrix, ref int startRow, ref int startCol, ref int maxLength)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if ((row == startRow) && (col == startCol))
                {
                    if (maxLength > 0)
                    {
                        startRow++;
                        startCol++;
                        maxLength--;
                        Console.Write(" {0}", matrix[row, col].Substring(0, 1));
                    }
                    else
                    {
                        Console.Write(" -");
                    }
                }
                else
                {
                    Console.Write(" -");
                }
            }
            Console.WriteLine();
        }
    }

    private static void PrintLeftDiagonal(string[,] matrix, ref int startRow, ref int startCol, ref int maxLength)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if ((row == startRow) && (col == startCol))
                {
                    if (maxLength > 0)
                    {
                        startRow++;
                        startCol--;
                        maxLength--;
                        Console.Write(" {0}", matrix[row, col].Substring(0, 1));
                    }
                    else
                    {
                        Console.Write(" -");
                    }
                }
                else
                {
                    Console.Write(" -");
                }
            }
            Console.WriteLine();
        }
    }
}

