// Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

using System;
using System.Text;

class QuadraticEquasion
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        // The naming of the variables is a, b, c because these are the names of the parameters. It's not bad variable naming!
        // \u00B2 is the 2 power symbol. It may NOT be displayed correctly if your console uses a font different than Lucida Console!
        Console.WriteLine("Please enter the parameters of the quadratic equasion ax\u00B2 + bx + c = 0: ");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine();

        //We make all the necessery checks wheater, one or more of the parameters is 0!

        if(a == 0)
        {
            if(c == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("a = 0, b = 0, c = 0.\nEvery X is a salution!");
                    return; // This exits the probram!
                }
                else
                {
                    Console.WriteLine("a = 0, c = 0.\nThere is one solution:\nX = 0");
                    return;
                }
            }
            else if(b == 0)
            {
                Console.WriteLine("There is no solution!");
                return;
            }
            Console.WriteLine("a = 0.\nThere is one solution:\nX = {0}", (-c / b));
        }
        else if (b == 0)
        {
            if (c == 0)
            {
                Console.WriteLine("b = 0, c = 0\nThere are two solutions:\nX1 = X2 = 0");
                return;
            }
            else
            {
                if ((-c / a) > 0)
                {
                    Console.WriteLine("b = 0\nThere are two solutions:\nX1 = X2 = {0}", Math.Sqrt(-c / a));
                    return;
                }
                else
                {
                    Console.WriteLine("b = 0\nThere are no real solutions to the equasion!");
                    return;
                }
            }
        }
        else if (c == 0)
        {
            Console.WriteLine("c = 0\nThere are two solutions:\nX1 = 0, X2 = {0}", (-b / a));
        }
        else
        {
            double d = b * b - 4 * a * c; // Descriminant
            if (d < 0)
	        {
		        Console.WriteLine("The descirminant < 0.\nThere are no real solutions!");
	        }
            else if(d == 0)
            {
                Console.WriteLine("The descriminant = 0.\nThere are two solutions:\nX1 = X2 = {0}", (-b / 2*a));
            }
            else
            {
                double x1, x2;
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("There are two solutions: X1 = {0:0.00}, X2 = {1:0.00}", x1, x2);
            }
        }
    }
}

