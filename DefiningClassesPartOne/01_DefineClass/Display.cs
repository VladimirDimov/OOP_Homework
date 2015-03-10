using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    public class Display
    {
        private string sizeOfDisplay;
        private int numberOfColors;
        
        public string Size
        {
            get { return this.sizeOfDisplay; }
            set { this.sizeOfDisplay = value; }
        }

        public int NumberOfColors
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value; }
        }
        
    }
}
