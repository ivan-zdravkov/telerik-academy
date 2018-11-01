// Write an expression that calculates rectangle’s area by given width and height.

using System;

class RectangleArea
{
    static void Main()
    {
        Console.Write("Enter the width of the Rectangle: ");
        float width = float.Parse(Console.ReadLine());
        Console.Write("Enter the height of the Rectangle: ");
        float height = float.Parse(Console.ReadLine());
        Console.WriteLine("The AREA of the Rectangle is {0}", height * width);
    }
}

