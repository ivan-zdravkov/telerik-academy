// Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Please enter the two sides a and b of the Trapezoid and it's height h ...");
        Console.Write("a = ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("b = ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("h = ");
        float h = float.Parse(Console.ReadLine());

        Console.WriteLine("The area of the Trapezoid is {0}", (((a + b) / 2) * h));
    }
}

