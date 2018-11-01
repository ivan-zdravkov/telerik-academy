// Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. 
// The first line in the input file contains the size of matrix N. Each of the next N lines contain N numbers separated by space. 
// The output should be a single number in a separate text file. Example:
// 4
// 2 3 3 4
// 0 2 3 4			-> 17
// 3 7 1 2
// 4 3 3 2
using System;
using System.IO;

class ReadingAMatrixFromFile
{
    static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader("../../Matrix.txt");
            using (reader)
            {
                int matrixSize = int.Parse(reader.ReadLine());
                int[,] matrix = MatrixFill(reader, matrixSize);

                int sizeOfSector = 2;
                int largestSectorSum = GetSectorSum(matrix, sizeOfSector);

                StreamWriter writer = new StreamWriter("../../LargestSum.txt");
                using (writer)
                {
                    writer.WriteLine(largestSectorSum);
                    Console.WriteLine("DONE!\n{0} written on file LargestSum.txt", largestSectorSum);
                }
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
  
    static int[,] MatrixFill (StreamReader reader, int matrixSize)
    {
        int[,] matrix = new int[matrixSize, matrixSize];

        for (int row = 0; row < matrixSize && !reader.EndOfStream; row++)
        {
            string line = reader.ReadLine();
            string[] seperatedLine = line.Split(' ');
            for (int col = 0; col < matrixSize; col++)
            {
                matrix[row, col] = int.Parse(seperatedLine[col]);
            }
        }

        return matrix;
    }

    static int GetSectorSum(int[,] matrix, int size)
    {
        int maxSum = int.MinValue;

        for (int row = 0; row <= matrix.GetLength(0) - size; row++)
        {
            for (int col = 0; col <= matrix.GetLength(1) - size; col++)
            {
                int sum = 0;
                for (int i = row; i < row + size; i++)
                {
                    for (int j = col; j < col + size; j++)
                    {
                        sum += matrix[i, j];
                    }
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
        }

        return maxSum;
    }
}