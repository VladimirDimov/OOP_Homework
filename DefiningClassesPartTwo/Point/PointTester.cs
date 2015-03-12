
namespace DefiningClassesPartTwo
{
    using System;
    using Point;

    class PointTester
    {
        static void Main()
        {
            Point3D newPoint = new Point3D();
            newPoint.X = 5;
            newPoint.Y = 4;
            newPoint.Z = 8;
            Console.WriteLine("Printing test point ...");
            Console.WriteLine(newPoint.ToString());

            Console.WriteLine();
            Point3D centerOfCoordSystem = Point3D.GetZeroPoint();
            Console.WriteLine("Printing center of coordinate system ...");
            Console.WriteLine(centerOfCoordSystem.ToString());

            //Calculate Distance between newPoint and centerOfCoordSystem
            Console.WriteLine();
            Console.WriteLine("Calculating distance between two points ...");
            Console.WriteLine("Distance = {0:F2}", Distance.GetDistance(newPoint, centerOfCoordSystem));
            
            //define new path
            Path newPath = new Path();
            newPath.AddPoint(centerOfCoordSystem);
            newPath.AddPoint(new Point3D(1, 1, 1));
            newPath.AddPoint(newPoint);

            //test path.ToString
            Console.WriteLine();
            Console.WriteLine("Printing path points ...");
            Console.WriteLine(newPath.ToString());

            //test geting a point from newPath and printing it
            Console.WriteLine();
            Console.WriteLine("Print path point at index [1] ...");
            Console.WriteLine(newPath.GetPathPoint(1).ToString());

            //test file writing
            PathStorage.SavePath(newPath, @"..\..\newPath.txt");
        }
    }
}
