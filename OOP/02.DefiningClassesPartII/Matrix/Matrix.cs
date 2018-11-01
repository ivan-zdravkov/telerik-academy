using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    public class Matrix<T>
        where T : IComparable<T>, new()
    {
        private T[,] matrix;
        private int sizeRows;
        private int sizeCols;

        public T[,] GetMatrix
        {
            get { return matrix; }
        }

        public T[,] SetMatrix
        {
            set { matrix = value; }
        }

        public int Rows
        {
            get { return sizeRows; }
        }

        public int Cols
        {
            get { return sizeCols; }
        }

        public Matrix(T[,] matrix, int sizeRows, int sizeCols)
        {
            this.matrix = matrix;
            this.sizeRows = sizeRows;
            this.sizeCols = sizeCols;
        }

        public T this[int row, int col]
        {
            get
            {
                if ((row >= 0 && row < this.sizeRows) && (col >= 0 && col < this.sizeCols))
                {
                    return this.matrix[row, col];
                }
                else
                {
                    throw new ArgumentException("The index was outside the bounds of array!");
                }
            }
            set
            {
                if ((row >= 0 && row < this.sizeRows) && (col >= 0 && col < this.sizeCols))
                {
                    this.matrix[row, col] = value;
                }
                else
                {
                    throw new ArgumentException("The index was outside the bounds of array!");
                }
            }
        }

        public static Matrix<T> operator +(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            if (matrixOne.Rows == matrixTwo.Rows && matrixOne.Rows == matrixTwo.Rows)
            {
                T[,] resultMatrix = new T[matrixOne.Rows, matrixOne.Cols];
                for (int row = 0; row < matrixOne.Rows; row++)
                {
                    for (int col = 0; col < matrixOne.Cols; col++)
                    {
                        resultMatrix[row, col] = (dynamic)matrixOne[row, col] + (dynamic)matrixTwo[row, col];
                    }
                }
                return new Matrix<T>(resultMatrix, matrixOne.Rows, matrixOne.Cols);
            }
            else
            {
                throw new ArgumentException("The two matrixes were of different size!");
            }
        }

        public static Matrix<T> operator -(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        { 
            if (matrixOne.Rows == matrixTwo.Rows && matrixOne.Rows == matrixTwo.Rows)
            {
                T[,] resultMatrix = new T[matrixOne.Rows, matrixOne.Cols]; 
                for (int row = 0; row < matrixOne.Rows; row++)
                {
                    for (int col = 0; col < matrixOne.Cols; col++)
                    {
                        resultMatrix[row, col] = (dynamic)matrixOne[row, col] - (dynamic)matrixTwo[row, col];
                    }
                }
                return new Matrix<T>(resultMatrix, matrixOne.Rows, matrixOne.Cols);
            }
            else
            {
                throw new ArgumentException("The two matrixes were of different size!");
            }
        }

        public static Matrix<T> operator *(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            if (matrixOne.Cols == matrixTwo.Rows)
            {
                int rows = matrixOne.Rows;
                int cols = matrixTwo.Cols;
                T[,] resultMatrix = new T[rows, cols];
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        dynamic sum = 0;
                        for (int i = 0; i < cols; i++)
                        {
                            sum = sum + (dynamic)matrixOne[row, i] * (dynamic)matrixTwo[i, col];
                        }
                        resultMatrix[row, col] = sum;
                    }
                }
                return new Matrix<T>(resultMatrix, matrixOne.Rows, matrixOne.Cols);
            }
            else
            {
                throw new ArgumentException("The two matrixes were of different size!");
            }
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    int zero = 0;
                    if (matrix[row, col].CompareTo((T)Convert.ChangeType(zero, typeof(T))) == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col].CompareTo(new T()) == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            for (int row = 0; row < this.Rows; row++)
            {
                text.AppendLine();
                for (int col = 0; col < this.Cols; col++)
                {
                    text.Append(this.matrix[row, col] + ", ");
                }  
            }
            return text.ToString();
        }

        public void Clear()
        {
            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Cols; col++)
                {
                    this.matrix[row, col] = (T)Convert.ChangeType(0, typeof(T));
                }
            }
        }
    }
}
