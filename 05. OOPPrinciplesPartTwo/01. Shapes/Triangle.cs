namespace _01.Shapes
{
    using System;

    class Triangle : Shape
    {
        public Triangle(double height, double width)
            : base(height, width)
        { }

        public override double ClaculteSurface()
        {
            return this.Height * this.Width * 0.5d;
        }
    }
}
