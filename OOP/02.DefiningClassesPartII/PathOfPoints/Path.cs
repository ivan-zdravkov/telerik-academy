// There are two classes in a single file on purpose!

using System;
using System.Collections.Generic;

namespace PathOfPoints
{
    public class Path
    {
        private List<Point3D> list;
        public List<Point3D> GetList
        {
            get { return list; }
        }

        public Path(List<Point3D> list)
        {
            this.list = list;
        }

        public Path()
        {
            this.list = new List<Point3D>();
        }

        public void AddToPath(Point3D point)
        {
            this.list.Add(point);
        }

        public void RemoveLast()
        {
            this.list.RemoveAt(this.list.Count - 1);
        }

        public void ClearPath()
        {
            this.list.Clear();
        }
    }
}
