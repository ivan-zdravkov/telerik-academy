// Write methods that calculate the surface of a triangle by given:
// Side and an altitude to it; Three sides; Two sides and an angle between them. 
// Use System.Math.

using System;
using System.Globalization;
using System.Threading;

class TriangleSurface
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Calculating area of a triangle...");
        Console.WriteLine("We will calculate, using:\n");
        
        while (true)
        {
            Console.WriteLine("1. Side and altitude.");
            Console.WriteLine("2. Three sides.");
            Console.WriteLine("3. Two sides and an angle.");
            Console.WriteLine("4. EXIT!\n");
            int choice = -1;
            while (!(choice >= 0 && choice <= 4))
            {
                Console.Write("Make your choice: ");
                choice = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            switch (choice)
            {
                case 1:
                    {
                        double side = 0;
                        while (side <= 0)
                        {
                            Console.Write("Enter the side: ");
                            side = double.Parse(Console.ReadLine());
                        }
                        double altitude = 0;
                        while (altitude <= 0)
                        {
                            Console.Write("Enter the altitude: ");
                            altitude = double.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("\nThe area of the triange is {0}", CalculateSurface(side, altitude));
                        break;
                    }
                case 2:
                    {
                        double sideA = 0;
                        while (sideA <= 0)
                        {
                            Console.Write("Enter the first side: ");
                            sideA = double.Parse(Console.ReadLine());
                        }
                        double sideB = 0;
                        while (sideB <= 0)
                        {
                            Console.Write("Enter the second side: ");
                            sideB = double.Parse(Console.ReadLine());
                        }
                        double sideC = 0;
                        while (sideC <= 0)
                        {
                            Console.Write("Enter the third side: ");
                            sideC = double.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("\nThe area of the triange is {0}", CalculateSurface(sideA, sideB, sideC));
                        break;
                    }
                case 3:
                    {
                        double sideA = 0;
                        while (sideA <= 0)
                        {
                            Console.Write("Enter the first side: ");
                            sideA = double.Parse(Console.ReadLine());
                        }
                        double sideB = 0;
                        while (sideB <= 0)
                        {
                            Console.Write("Enter the second side: ");
                            sideB = double.Parse(Console.ReadLine());
                        }
                        int angleGamma = 0;
                        while (angleGamma <= 0)
                        {
                            Console.Write("Enter the angle (degrees): ");
                            angleGamma = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("\nThe area of the triange is {0}", CalculateSurface(sideA, sideB, angleGamma));
                        break;
                    }
                case 4:
                    {
                        System.Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("ERROR!");
                        Console.WriteLine("Terminating application...");
                        System.Environment.Exit(0);
                        break;
                    }
            }
            Console.WriteLine(new String('-', 50));
        }
    }

    static double CalculateSurface(double side, double altitude)
    {
        return ((side * altitude) / 2.0);
    }

    static double CalculateSurface(double sideA, double sideB, double sideC)
    {
        double semiPerimeter = ((sideA + sideB + sideC) / 2.0);
        return Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
    }

    static double CalculateSurface(double sideA, double sideB, int angleGamma)
    {
        double result = (0.5 * sideA * sideB * Math.Sin(DegreeToRadian(angleGamma)));
        return result;
    }

    static double DegreeToRadian(double angle)
    {
        return ((Math.PI * angle) / 180.0);
    }
}
