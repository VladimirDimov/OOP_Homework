using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    public class GSM
    {
        private string modelOfGSM;
        private string manufacturerOfGSM;
        private decimal priceOfGSM ;
        private string ownerOfGSM;
        private Batery bateryOfGSM;
        private Display displayOfGSM;

        public GSM(string model, string manufacturer)
        {
            this.modelOfGSM = model;
            this.manufacturerOfGSM = manufacturer;
        }

        public GSM(string model, string manufacturer, decimal price)
            : this(model, manufacturer)
        {
            this.priceOfGSM = price;
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
            : this( model,  manufacturer,  price)
        {
            this.ownerOfGSM = owner;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Batery batery, Display display)
            : this(model, manufacturer, price, owner)
        {
            this.bateryOfGSM = batery;
            this.displayOfGSM = display;
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

        public Display DisplayProperties
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
    }
}
