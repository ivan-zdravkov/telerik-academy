/* 
   1) Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. 
Implement the ToString() to enable printing a 3D point.
   2) Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. 
Add a static property to return the point O.
   3) Write a static class with a static method to calculate the distance between two points in the 3D space.
   4) Create a class Path to hold a sequence of points in the 3D space. 
Create a static class PathStorage with static methods to save and load paths from a text file. 
Use a file format of your choice.
*/


using System;
using System.Collections.Generic;

namespace PathOfPoints
{
    class Program
    {
        static void Main()
        {
            // To validate distance calculation: http://www.calculatorsoup.com/calculators/geometry-solids/distance-two-points.php
            double distance = Calculate.Distance(Point3D.PointZero, new Point3D(8, 4, 8));
            Console.WriteLine("The distance between the two points is: {0:.000000}\n", distance);

            Path path = new Path();
            path.AddToPath(new Point3D(1, 1, 1));
            path.AddToPath(new Point3D(1, 2, 1));
            path.AddToPath(new Point3D(1, 1, 0));
            path.AddToPath(new Point3D(3, 1, 1));

            PathStorage.Save(path);
            Print(path);

            path.ClearPath();
            Print(path); 

            path = PathStorage.Load("../../OutputFile1380810252.txt");
            Print(path);
            
        }

        static void Print(Path path)
        {
            List<Point3D> list = path.GetList;
            if (list.Count == 0)
            {
                Console.WriteLine("The path is empty!");
            }
            else
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            Console.WriteLine();
        }
    }
}
