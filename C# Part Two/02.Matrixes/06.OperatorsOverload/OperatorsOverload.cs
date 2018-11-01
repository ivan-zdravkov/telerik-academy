// * Write a class Matrix, to holds a matrix of integers. 
// Overload the operators for adding, subtracting and multiplying of matrices, 
// indexer for accessing the matrix content and ToString().

using System;

class Matrix
{
    private int[,] matrix;
    public int rows, cols;

    public Matrix(int iRows, int iCols)
    {
        matrix = new int[iRows, iCols];
        rows = iRows;
        cols = iCols;
    }

    public int this[int x, int y]
    {
        get 
        { 
            return matrix[x, y]; 
        }
        set 
        { 
            matrix[x, y] = value; 
        }
    }

    public static Matrix operator +(Matrix additive, Matrix adder)
    {
        int rowSize = Math.Max(additive.rows, adder.rows);
        int colSize = Math.Max(additive.cols, adder.cols);
        Matrix resultMatrix = new Matrix(rowSize, colSize);

        for (int row = 0; row < additive.rows; row++)
        {
            for (int col = 0; col < additive.cols; col++)
            {
                resultMatrix[row, col] += additive[row, col];
            }
        }

        for (int row = 0; row < adder.rows; row++)
        {
            for (int col = 0; col < adder.cols; col++)
            {
                resultMatrix[row, col] += adder[row, col];
            }
        }

        return resultMatrix;
    }

    public static Matrix operator -(Matrix minuend, Matrix subtrahend)
    {
        int rowSize = Math.Max(minuend.rows, subtrahend.rows);
        int colSize = Math.Max(minuend.cols, subtrahend.cols);
        Matrix resultMatrix = new Matrix(rowSize, colSize);


        for (int row = 0; row < minuend.rows; row++)
        {
            for (int col = 0; col < minuend.cols; col++)
            {
                resultMatrix[row, col] += minuend[row, col];
            }
        }

        for (int row = 0; row < subtrahend.rows; row++)
        {
            for (int col = 0; col < subtrahend.cols; col++)
            {
                resultMatrix[row, col] -= subtrahend[row, col];
            }
        }

        return resultMatrix;
    }

    public static Matrix operator *(Matrix multipliable, Matrix multiplexer)
    {
        try
        {
            if (multipliable.rows >= multiplexer.rows)
            {
                Matrix resultMatrix = new Matrix(multipliable.rows, multiplexer.cols);
                for (int mulRow = 0; mulRow < multipliable.rows; mulRow++)
                {
                    for (int mulCol = 0; mulCol < multiplexer.cols; mulCol++)
                    {
                        int sum = 0;
                        for (int mplxRow = 0; mplxRow < multiplexer.rows; mplxRow++)
                        {
                            sum += multipliable[mulRow, mplxRow] * multiplexer[mplxRow, mulCol];
                        }
                        resultMatrix[mulRow, mulCol] = sum;
                    }
                }
                return resultMatrix;
            }
            else
            {

                Matrix resultMatrix = new Matrix(multipliable.rows, multiplexer.cols);
                for (int mulRow = 0; mulRow < multipliable.rows; mulRow++)
                {
                    for (int mulCol = 0; mulCol < multiplexer.cols; mulCol++)
                    {
                        int sum = 0;
                        for (int mplxRow = 0; mplxRow < multiplexer.rows; mplxRow++)
                        {
                            sum += multipliable[mulRow, mplxRow] * multiplexer[mplxRow, mulCol];
                        }
                        resultMatrix[mulRow, mulCol] = sum;
                    }
                }
                return resultMatrix;
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("(number of columns on matrix A) != (number of rows of matrix B)");
            return null;
        }
    }

    public override string ToString()
    {
        int max = this.matrix[0, 0];
        foreach (int cell in this.matrix) max = Math.Max(max, cell);
        int cellSize = Convert.ToString(max).Length;

        string s = String.Empty;

        for (int i = 0; i < this.rows; i++)
            for (int j = 0; j < this.cols; j++)
                s += (Convert.ToString(this.matrix[i, j]).PadRight(cellSize * 2, ' ') + (j != this.cols - 1 ? " " : "\n"));

        return s;
    }
}

class Program
{
    static void Main()
    {
        Matrix matrixOne = generateMatrix();
        Matrix matrixTwo = generateMatrix();

        Console.WriteLine("Matrix A");
        Console.WriteLine(matrixOne);

        Console.WriteLine("Matrix B");
        Console.WriteLine(matrixTwo);

        Console.WriteLine("Matrix A + Matrix B");
        Console.WriteLine(matrixOne + matrixTwo);

        Console.WriteLine("Matrix A - Matrix B");
        Console.WriteLine(matrixOne - matrixTwo);

        Console.WriteLine("Matrix A * Matrix B");
        Console.WriteLine(matrixOne * matrixTwo);

    }

    private static Matrix generateMatrix()
    {
        int sizeRows = 0;
        int sizeCols = 0;
        while (sizeRows < 2)
        {
            Console.Write("Enter the size of the rows of the matrix: ");
            sizeRows = int.Parse(Console.ReadLine());
        }
        while (sizeCols < 2)
        {
            Console.Write("Enter the size of the cols of the matrix: ", sizeRows - 1, sizeRows + 1);
            sizeCols = int.Parse(Console.ReadLine());
        }
        Matrix tempMatrix = new Matrix(sizeRows, sizeCols);
        for (int rows = 0; rows < sizeRows; rows++)
        {
            for (int cols = 0; cols < sizeCols; cols++)
            {
                Console.Write("[{0}][{1}] = ", rows, cols);
                tempMatrix[rows, cols] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }
        return tempMatrix;
    }
}