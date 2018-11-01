using System;

namespace Shapes
{
    public abstract class Shape
    {
        private double width;
        public double Width
        {
            get { return width; }
        }

        private double height;
        public double Height
        {
            get { return height; }
        }

        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public abstract double CalculateSurface();
    }
}
