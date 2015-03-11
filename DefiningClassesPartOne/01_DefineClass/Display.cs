using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    public class Display
    {
        private int displayWidth;
        private int displayHeight;
        private int numberOfColors;

        public Display()
        {
            this.Width = 320;
            this.Height = 240;
            this.NumberOfColors = 65000;
        }

        public Display(int width, int height, int colors)
        {
            this.Width = width;
            this.Height = height;
            this.NumberOfColors = colors;
        }
        public int Width
        {
            get { return this.displayWidth; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Display size cannot be null or empty.");
                }
                this.displayWidth = value;
            }
        }

        public int Height
        {
            get { return this.displayHeight; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Display size cannot be null or empty.");
                }
                this.displayHeight = value;
            }
        }

        public int NumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Display colors number must be greater than zero.");
                }
                this.numberOfColors = value;
            }
        }

    }
}
