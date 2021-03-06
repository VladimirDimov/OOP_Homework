﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    public class GSM
    {
        private const decimal Call_Price_Per_Minute = 0.37M;

        private string modelOfGSM;
        private string manufacturerOfGSM;
        private decimal priceOfGSM ;
        private string ownerOfGSM;
        private Batery bateryOfGSM;
        private Display displayOfGSM;
        private List<Call> callHistory = new List<Call>();
        
        public GSM(string model, string manufacturer)
        {
            this.modelOfGSM = model;
            this.manufacturerOfGSM = manufacturer;
            //default values
            this.Price = 0;
            this.Owner = "Not defined";
            this.Batery = new Batery();
            this.Display = new Display();
        }

        public GSM(string model, string manufacturer, decimal price)
            : this(model, manufacturer)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
            : this( model,  manufacturer,  price)
        {
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Batery batery, Display display)
            : this(model, manufacturer, price, owner)
        {
            this.Batery = batery;
            this.Display = display;
        }

        public string Model
        {
            get { return this.modelOfGSM; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("GSM model cannot be null or empty.");
                }
                this.modelOfGSM = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturerOfGSM; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("GSM manufacturer cannot be null or empty");
                }
                this.manufacturerOfGSM = value; 
            }
        }

        public decimal Price
        {
            get { return this.priceOfGSM; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative.");
                }
                this.priceOfGSM = value; 
            }
        }

        public string Owner
        {
            get { return this.ownerOfGSM; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Owner name cannot be null or empty.");
                }
                this.ownerOfGSM = value; 
            }
        }

        public Batery Batery
        {
            get { return this.bateryOfGSM; }
            set { this.bateryOfGSM = value; } //data is validated in Batery.cs
        }

        public Display Display
        {
            get { return this.displayOfGSM; }
            set { this.displayOfGSM = value; } //data is validated in Display.cs        
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append("GSM information:");
            builder.AppendLine();
            builder.Append("Model: " + modelOfGSM);
            builder.AppendLine();
            builder.Append("Manufacturer: " + manufacturerOfGSM);
            builder.AppendLine();
            builder.Append("Price: " + priceOfGSM);
            builder.AppendLine();
            builder.Append("Owner: " + ownerOfGSM);
            builder.AppendLine();
            builder.Append("Batery model: " + bateryOfGSM.Model);
            builder.AppendLine();
            builder.Append("Batery type: " + bateryOfGSM.BateryType);
            builder.AppendLine();
            builder.Append("Batery hours idle: " + bateryOfGSM.HoursIdle);
            builder.AppendLine();
            builder.Append("Batery hours tslk: " + bateryOfGSM.HoursTalk);
            builder.AppendLine();
            builder.Append("Display size: " + displayOfGSM.Width + "x" +  displayOfGSM.Height);
            builder.AppendLine();
            builder.Append("Display number of colors: " + this.displayOfGSM.NumberOfColors);
            builder.AppendLine();

            return builder.ToString();
        }

        public static GSM IPhone4S
        {
            get
            {
                return new GSM("Iphone 4S", "Apple", 850, "Pesho",
                    new Batery("Li-Po 1432 mAh", 200, 14, Batery.Type.LiIon),
                    new Display(640, 960, 16000000));
            }
        }

        public List<Call> CallHistory
        {
            get { return callHistory; }
        }


        public void AddCall(DateTime dateTime, string diledNumber, double duration)
        {
            this.callHistory.Add(new Call(dateTime, diledNumber, duration));
        }

        public void DeleteCall(int startIndex, int endIndex)
        {
            if (startIndex >= 0 && startIndex < callHistory.Count)
            {
                callHistory.RemoveRange(startIndex, endIndex);
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid call index");
            }
        }

        public decimal GetTotalCallPrice()
        {
            decimal totalPrice = 0;
            foreach (var call in this.callHistory)
            {
                totalPrice += (decimal)Math.Ceiling(call.Duration / 60) * Call_Price_Per_Minute;
            }
            return totalPrice;
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public void PrintCalls()
        {
            foreach (var call in this.CallHistory)
            {
                Console.WriteLine("Date: {0}, Time: {1}, Duration: {2} sec", call.Date, call.Time, call.Duration);
            }
        }
    }
}
