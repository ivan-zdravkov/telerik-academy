// Write a program that reads an integer number and calculates and prints its square root. 
// If the number is invalid or negative, print "Invalid number". 
// In all cases finally print "Good bye". Use try-catch-finally.

using System;

class SquareRootExceptions
{
    static void Main()
    {
        Console.Write("Enter a number, to be rooted: ");
        string input = Console.ReadLine();

        try
        {
            double value = double.Parse(input);
            double root = Sqrt(value);
            Console.WriteLine("The root is: {0}", root);
        }
        catch (FormatException fe)
        {
            Console.WriteLine(fe.Message);
            Console.WriteLine("Invalid number!");
        }
        catch (ArgumentOutOfRangeException outOfRange)
        {
            Console.WriteLine(outOfRange.Message);
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }

    }

    static double Sqrt(double value)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException("The number is negative!");
        }
        else
        {
            return Math.Sqrt(value);
        }
    }
}