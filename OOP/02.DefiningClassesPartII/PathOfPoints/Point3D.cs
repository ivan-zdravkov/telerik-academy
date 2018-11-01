using System;

namespace PathOfPoints
{
    public struct Point3D
    {
        private double x;
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        private double y;
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        private double z;
        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        private static readonly Point3D pointZero = new Point3D(0, 0, 0);
        public static Point3D PointZero
        {
            get { return pointZero; }
        }

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", this.x, this.y, this.z); 
        }
    }
}
