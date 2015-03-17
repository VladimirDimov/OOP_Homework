using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
     public class Batery
    {
        private string modelOfBatery = "Unknown";
        private double hoursIdleOfBatery;
        private double hoursTalkOfBatery;
        private Type bateryType;

        public enum Type
        { 
            LiIon, 
            NiMH, 
            NiCd,
            Undefined
        }

        public Batery()
        {
            this.Model = "Undefined Model";
            this.HoursIdle = 48;
            this.HoursTalk = 14;
            this.BateryType = Type.Undefined;
        }

        public Batery(string model)
        {
            this.Model = model;
        }

        public Batery(string model, int hoursIdl)
            : this(model)
        {
            this.HoursIdle = hoursIdl;
        }

        public Batery(string model, int hoursIdl, int hoursTalk)
            : this(model, hoursIdl)
        {
            this.HoursTalk = hoursTalk;
        }

        public Batery(string model, int hoursIdl, int hoursTalk, Type type)
            : this(model, hoursIdl, hoursTalk)
        {
            this.BateryType = type;
        }

        public string Model
        {
            get { return this.modelOfBatery; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Batery model cannot be null or empty.");
                }
                this.modelOfBatery = value;
            }
        }

        public double HoursIdle
        {
            get {return this.hoursIdleOfBatery; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Hours idle must be bigger than zero.");
                }
                this.hoursIdleOfBatery = value;
            }
        }

        public double HoursTalk
        {
            get { return this.hoursTalkOfBatery; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Hours talk must be bigger than zero.");
                }
                this.hoursTalkOfBatery = value; 
            }
        }

        public Type BateryType 
        {
            get { return this.bateryType; }
            set { this.bateryType = value; }
        }
    }
}
