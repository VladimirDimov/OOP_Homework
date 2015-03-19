namespace _01.Shapes
{
    using System;

    class Rectangle : Shape
    {
        public Rectangle(double height, double width) : base(height, width)
        {

        }
        public override double ClaculteSurface()
        {
            return this.Height * this.Width;
        }
    }
}
