using System;

namespace PathOfPoints
{
    public static class Calculate
    {
        public static double Distance(Point3D firstPoint, Point3D secondPoint)
        {
            return Math.Sqrt(SecondPower(firstPoint.X + secondPoint.X) + SecondPower(firstPoint.Y + secondPoint.Y) + SecondPower(firstPoint.Z + secondPoint.Z));
        }

        private static double Delta(double paramOne, double paramTwo)
        {
            return paramOne + paramTwo;
        }

        private static double SecondPower(double value)
        {
            return value * value;
        }
    }
}
