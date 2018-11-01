// Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

// This Solution  uses primitive types of variables and calculates the hypotenuse of the triangle the point(x, y) and the center(0, 0) form, 
// which is the distance between the 2 points. If this disntance is less than the radius, the point is inside the circle, this radius draws.

using System;

class PointInCircle
{
    static void Main()
    {
        float radius = 5;
        //Console.Write("Enter the radius: ");
        //radius = float.Parse(Console.ReadLine());

        Console.Write("Enter point coordianate x: ");
        float xCoordinate = float.Parse(Console.ReadLine());
        Console.Write("Enter point coordianate y: ");
        float yCoordinate = float.Parse(Console.ReadLine());

        float distance = (float)Math.Sqrt((xCoordinate * xCoordinate) + (yCoordinate * yCoordinate));
        if (distance < radius)
            Console.WriteLine("The point is within the Circle!");
        else
            Console.WriteLine("The point is outside the Circle!");
    }
}

// This Solution uses 2 public structs and lets you set the center of the circle and its radius, as well as the points's coordinates!

/*

// A Point structure. Imagine this as a Point data structure, that has 2 variables. Every object we create of the type Point will have 
// x coordinate and y coordinate, which can be acceced with the '.' operator (dot).
// If we create an object called pt, respectively -> p.x and p.y will get us its x and y coordinates!
public struct Point
{
    public float x;
    public float y;
}

// The Circle sturcture is just like the Point structire, only it uses a Point as a center and an integer as a radius.
public struct Circle
{
    public Point center;
    public float radius;
}

class PointInCircle
{
    static void Main()
    {
        Point pt = new Point();
        Console.Write("Enter point coordianate x: ");
        pt.x = float.Parse(Console.ReadLine());
        Console.Write("Enter point coordianate y: ");
        pt.y = float.Parse(Console.ReadLine());

        Circle cl = new Circle();
        Console.WriteLine("Enter the center of the Circle:");
        Console.Write("Enter center coordianate x: ");
        cl.center.x = float.Parse(Console.ReadLine());
        Console.Write("Enter center coordianate y: ");
        cl.center.y = float.Parse(Console.ReadLine());
        Console.Write("Enter center radius: ");
        cl.radius = float.Parse(Console.ReadLine());

        float xDistance = pt.x - cl.center.x;
        float yDistance = pt.y - cl.center.y;
        float distance = (float)Math.Sqrt((xDistance * xDistance) + (yDistance * yDistance));

        if(distance < cl.radius)
            Console.WriteLine("The point is within the Circle!");
        else
            Console.WriteLine("The point is outside the Circle!");
    }
}


*/