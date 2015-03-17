namespace DefiningClassesPartTwo.Point
{
    using System;

    public class Distance
    {
        public static double GetDistance(Point3D firstPoint, Point3D secondPoint)
        { 
            double xSquareDist = Math.Pow(Math.Abs(firstPoint.X - secondPoint.X), 2);
            double ySquareDist = Math.Pow(Math.Abs(firstPoint.Y - secondPoint.Y),2);
            double zSquareDist = Math.Pow(Math.Abs(firstPoint.Z - secondPoint.Z), 2);

            double distance = Math.Sqrt(xSquareDist + ySquareDist + zSquareDist);

            return distance;
        }
    }
}
