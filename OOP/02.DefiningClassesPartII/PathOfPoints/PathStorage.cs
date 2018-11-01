using System;
using System.Collections.Generic;
using System.IO;

namespace PathOfPoints
{
    public static class PathStorage
    {
        public static void Save(Path pathToSave)
        {
            List<Point3D> list = pathToSave.GetList;

            string outputPath = "../../OutputFile" + ConvertToUnixTimestamp(DateTime.Now) + ".txt";
            StreamWriter writer = new StreamWriter(outputPath);
            using (writer)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    writer.WriteLine("{0} {1} {2}", list[i].X, list[i].Y, list[i].Z);
                }
            }
        }

        public static Path Load(string pathToLoad)
        {
            List<Point3D> list = new List<Point3D>();

            StreamReader reader = new StreamReader(pathToLoad);
            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split();
                    Point3D temp = new Point3D(double.Parse(line[0]), double.Parse(line[1]), double.Parse(line[2]));
                    list.Add(temp);
                }
            }
            return new Path(list);
        }

        private static double ConvertToUnixTimestamp(DateTime date)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            TimeSpan difference = date.ToUniversalTime() - origin;
            return Math.Floor(difference.TotalSeconds);
        }
    }
}
