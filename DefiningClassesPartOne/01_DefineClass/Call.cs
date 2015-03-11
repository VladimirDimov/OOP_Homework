using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    public class Call
    {
        private DateTime dateTime;
        private string dialedNumber;
        private double duration; // in seconds

        public Call(DateTime datetime, string diledNumber, double duration)
        {
            this.dateTime = datetime;
            this.dialedNumber = diledNumber;
            this.duration = duration;
        }

        public double Duration
        {
            set { this.duration = value; }
            get { return this.duration; }
        }

        public string DialedNumber
        {
            get { return this.dialedNumber; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid number.");
                }
                this.dialedNumber = value; 
            }
        }        

        public string Time
        {
            get
            {
                if (this.dateTime != null)
                {
                    return this.dateTime.ToString("HH:mm:ss");
                }
                else
                {
                    throw new ArgumentNullException("Time cannot be null.");
                }
            }
        }

        public string Date
        {
            get
            {
                if (this.dateTime != null)
                {
                    return this.dateTime.ToString("d.MM.yyyy");
                }
                else
                {
                    throw new ArgumentNullException("Time cannot be null.");
                }
            }
        }
    }
}
