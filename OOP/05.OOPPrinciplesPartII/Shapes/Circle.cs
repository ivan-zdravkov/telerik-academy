using System;

namespace Shapes
{
    class Circle : Shape
    {
        public Circle(double radius) : base(radius * 2, radius * 2)
        {
        }


        public override double CalculateSurface()
        {
            double radius = this.Height / 2;
            return (Math.PI * radius * radius);
        }
    }
}
