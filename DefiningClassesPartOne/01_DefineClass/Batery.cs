using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    public class Batery
    {
        private string modelOfBatery;
        private double hoursIdleOfBatery;
        private double hoursTalkOfBatery;

        public Batery()
        { 
        }

        public Batery(string model)
        {
            this.modelOfBatery = model;
        }

        public Batery(string model, int hoursIdl)
            : this(model)
        {
            this.hoursIdleOfBatery = hoursIdl;
        }

        public Batery(string model, int hoursIdl, int hoursTalk)
            : this(model, hoursIdl)
        {
            this.hoursTalkOfBatery = hoursTalk;
        }
        
        public string Model
        {
            get { return this.modelOfBatery; }
            set { this.modelOfBatery = value; }
        }

        public double HoursIdle
        {
            get {return this.hoursIdleOfBatery; }
            set { this.hoursIdleOfBatery = value;}
        }

        public double HoursTalk
        {
            get { return this.hoursTalkOfBatery; }
            set { this.hoursTalkOfBatery = value; }
        }
    }
}
