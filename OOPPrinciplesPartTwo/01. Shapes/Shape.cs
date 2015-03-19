namespace _01.Shapes
{
    using System;

    public abstract class Shape
    {
        private double height;
        private double width;

        public Shape(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid height value");
                }

                this.height = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid width value");
                }

                this.width = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} -> height = {1} width = {2}",
               this.GetType().Name, this.Height, this.Width);
        }

        public abstract double ClaculteSurface();
    }
}
