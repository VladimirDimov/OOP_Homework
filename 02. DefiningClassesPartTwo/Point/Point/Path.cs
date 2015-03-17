namespace DefiningClassesPartTwo.Point
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Path
    {
        private List<Point3D> pathPoints = new List<Point3D>();

        public List<Point3D> PathPoints
        {
            get { return pathPoints; }
        }

        public void AddPoint(Point3D newPoint)
        {
            this.PathPoints.Add(newPoint);
        }

        public void DeletePoint(int index)
        {
            if (0 <= index && index < PathPoints.Count)
            {
                this.PathPoints.RemoveAt(index);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public Point3D GetPathPoint(int index)
        {
            if (0 <= index && index < this.PathPoints.Count)
            {
                return this.PathPoints[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void ClearPath()
        {
            this.PathPoints.Clear();
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            
            builder.Append(string.Join(Environment.NewLine, PathPoints));
            return builder.ToString();
        }
    }
}
