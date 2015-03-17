
namespace DefiningClassesPartTwo.Point
{
    using System;
    using System.Text;

    public struct Point3D
    {
        private double coordX;
        private double coordY;
        private double coordZ;
        private static readonly Point3D O = new Point3D(0,0,0);

        public Point3D(double x, double y, double z):this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double Z
        {
            get { return this.coordZ; }
            set { this.coordZ = value; }
        }

        public double Y
        {
            get { return this.coordY; }
            set { this.coordY = value; }
        }
        
        public double X
        {
            get { return this.coordX; }
            set { this.coordX = value; }
        }

        public static Point3D GetZeroPoint()
        {            
            return O;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendFormat("Point [{0}, {1}, {2}]", this.X, this.Y, this.Z);
            return builder.ToString();
        }
    }
}
