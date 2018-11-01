using System;

namespace Shapes
{
    class Program
    {
        static void Main()
        {
            Shape[] shapes = 
            {
                new Triangle(10, 10),
                new Rectangle(10, 10),
                new Circle(10),
                
                new Triangle(4, 8),
                new Rectangle(4, 8),
                new Circle(6)
            };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine("The surface of the {0} is {1:0.00}\n", shape.GetType().Name, shape.CalculateSurface());
            }
        }
    }
}
