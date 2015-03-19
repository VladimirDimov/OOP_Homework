namespace _01.Shapes
{
    using System;

    class Circle : Shape
    {
        public Circle(double radius) : base(radius, radius)
        {
        }
        
        public override double ClaculteSurface()
        {
            return Math.PI * this.Height * this.Height;
        }
    }
}
