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
        private Type bateryType = Type.Undefined;

        public enum Type
        { 
            LiIon, 
            NiMH, 
            NiCd,
            Undefined
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

        public Batery(string model, int hoursIdl, int hoursTalk, Type type)
            : this(model, hoursIdl, hoursTalk)
        {
            this.bateryType = type;
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

        public Type BateryType { get; set; }
    }
}
