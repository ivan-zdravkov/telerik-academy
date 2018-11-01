// Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class Circle
{
    static void Main()
    {
        Console.Write("Enter the radius of the circle: ");
        float radius = float.Parse(Console.ReadLine());
        Console.WriteLine("The perimeter of the circle is {0}", 2 * Math.PI * radius);
        Console.WriteLine("The area of the circle is {0}", Math.PI * radius * radius);
    }
}

