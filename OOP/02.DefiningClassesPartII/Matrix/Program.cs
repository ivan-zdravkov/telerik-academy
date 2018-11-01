/*
    8) Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 
    9) Implement an indexer this[row, col] to access the inner matrix cells.
    10) Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication. 
Throw an exception when the operation cannot be performed. Implement the true operator (check for non-zero elements).
*/

using System;

namespace Matrix
{
    class Program
    {
        static void Main()
        {
            int[,] tempMatrixOne = { { 0, 2, 3},
                                     { 1, 3, 2},
                                     { 1, 3, 5} };

            int[,] tempMatrixTwo = { { -1, 1, 1},
                                     { -6, 3, 4},
                                     { -5, 5, 3} };

            Matrix<int> matrixOne = new Matrix<int>(tempMatrixOne, 3, 3);
            Matrix<int> matrixTwo = new Matrix<int>(tempMatrixTwo, 3, 3);

            Matrix<int> result;

            result = Add(matrixOne, matrixTwo);
            result = Subtract(matrixOne, matrixTwo);
            result = Multiply(matrixOne, matrixTwo);

            result.Clear();
            Console.WriteLine("Clearing the result matrix to 0...");
            Console.WriteLine(result.ToString());
            CheckForZero(result);
        }

        private static Matrix<int> Multiply(Matrix<int> matrixOne, Matrix<int> matrixTwo)
        {
            Matrix<int> result = matrixOne * matrixTwo;
            Console.WriteLine(matrixOne.ToString());
            Console.WriteLine("\n*");
            Console.WriteLine(matrixTwo.ToString());
            Console.WriteLine("\n=");
            Console.WriteLine(result.ToString());
            CheckForZero(result);
            Console.WriteLine(new String('-', 40));
            return result;
        }

        private static Matrix<int> Subtract(Matrix<int> matrixOne, Matrix<int> matrixTwo)
        {
            Matrix<int> result = matrixOne - matrixTwo;
            Console.WriteLine(matrixOne.ToString());
            Console.WriteLine("\n-");
            Console.WriteLine(matrixTwo.ToString());
            Console.WriteLine("\n=");
            Console.WriteLine(result.ToString());
            CheckForZero(result);
            Console.WriteLine(new String('-', 40));
            return result;
        }

        private static Matrix<int> Add(Matrix<int> matrixOne, Matrix<int> matrixTwo)
        {
            Matrix<int> result = matrixOne + matrixTwo;
            Console.WriteLine(matrixOne.ToString());
            Console.WriteLine("\n+");
            Console.WriteLine(matrixTwo.ToString());
            Console.WriteLine("\n=");
            Console.WriteLine(result.ToString());
            CheckForZero(result);
            Console.WriteLine(new String('-', 40));
            return result;
        }

        private static void CheckForZero(Matrix<int> result)
        {
            if (result)
            {
                Console.WriteLine("\nThere are no zero elements in the result matrix!\n");
            }
            else
            {
                Console.WriteLine("There are zero elements in the result matrix!\n");
            }
        }
    }
}
