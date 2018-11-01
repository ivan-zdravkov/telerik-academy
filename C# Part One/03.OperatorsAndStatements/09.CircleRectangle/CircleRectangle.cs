// Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) 
// and out of the rectangle R(top=1, left=-1, width=6, height=2).

// SORRY for the long and hard solution, but I believe theese kinds of tasks need simmilar solutions. 
// I gave my best to document every step of the process so it can be understood by everyone!

using System;

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
    public float radius;
    public Point center;
}

// The Rectangle structure consists of 2 xCoordinate vectors and 2 yCoordinate vectors
// (They are more like line segments, but I will call them vectors)
public struct Rectangle
{
    public float xVectorTop;
    public float xVectorBottom;
    public float yVectorRight;
    public float yVectorLeft;
}

class CircleRectangle
{
    static void Main()
    {
        Point pt; // That's the point, the struct Point is defined above!
        Console.Write("Enter coordinate x of the Point: ");
        pt.x = float.Parse(Console.ReadLine());
        Console.Write("Enter coordinate y of the Point: ");
        pt.y = float.Parse(Console.ReadLine());

        // I am not initializing and setting the parameters of the Circle and Rectangle, but that can be easily done!

        Circle cl; // That's the circle, the struct Circle is defined above!
        cl.center.x = 1; 
        cl.center.y = 1;
        cl.radius = 3;

        Rectangle rec; // That's the rectangle, the struct Rectangle is defined above!
        rec.xVectorTop = 1; // The xVectorTop is the top line of the Rectangle, that is parallel to X
        rec.xVectorBottom = rec.xVectorTop - 2; // The xVectorBottom is the bottom line of the Rectangle, that is parallel to X and is (xVectorTop - height)
        rec.yVectorLeft = -1; // The yVectorLeft is the left line of the Rectangle, that is parallel to Y
        rec.yVectorRight = rec.yVectorLeft + 6; // The yVectorRight is the right line of the Rectangle, that is parallel to Y and is (yVectorRight + width)

        //Now we can easily check wheather the point is INSIDE the Circle and OUTSIDE the Rectangle

        float xDistance = pt.x - cl.center.x;
        float yDistance = pt.y - cl.center.y;
        float distance = (float)Math.Sqrt((xDistance * xDistance) + (yDistance * yDistance)); // The distance between the Point and the Center

        // The Point will be inside the circle, if the distance between the Point and the center of the Circle is less than the Circle radius!
        bool  circleInside = distance < cl.radius;

        // rectangeInside will be TRUE if the point is INSIDE the rectangle!
        bool rectangleInside = ((pt.x <= rec.xVectorTop) && (pt.x >= rec.xVectorBottom)) && ((pt.y <= rec.yVectorRight) && (pt.y >= rec.yVectorLeft));
        // rectangleOutside is the opossite of rectangleInside, so if the point is NOT inside the rectangle, rectangleOutsiede will be TRUE!
        bool rectangleOutside = !rectangleInside;

        Console.WriteLine("\nThe Point is {0} the circle", circleInside ? "inside": "outside");
        Console.WriteLine("The Point is {0} the rectangle\n", rectangleOutside ? "outside" : "inside");

        bool criteria = circleInside & rectangleOutside; // If both the conditions are met - criteria is TRUE, if not it is FALSE
        Console.WriteLine("The conditions in the task are {0}", criteria ? "met!" : "not met!");
    }
}

