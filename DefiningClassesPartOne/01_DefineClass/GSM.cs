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
        private decimal priceOfGSM;
        private string ownerOfGSM;
        private Batery bateryOfGSM = new Batery();
        private Display displayOfGSM = new Display();

        public GSM()
        { 

        }

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

        public GSM(string model, string manufacturer, decimal price, string owner, Batery batery)
            : this(model, manufacturer, price, owner)
        {
            this.bateryOfGSM = batery;
        }

        public string Model
        {
            get { return this.modelOfGSM; }
            set { this.modelOfGSM = value; }
        }

        public string Manufacturer
        {
            get { return this.manufacturerOfGSM; }
            set { this.manufacturerOfGSM = value; }
        }

        public decimal Price
        {
            get { return this.priceOfGSM; }
            set { this.priceOfGSM = value; }
        }

        public string Owner
        {
            get { return this.ownerOfGSM; }
            set { this.ownerOfGSM = value; }
        }

        public Batery Batery
        {
            get { return this.bateryOfGSM; }
            set { this.bateryOfGSM = value; }
        }

        public Display DisplayProperties
        {
            get { return this.displayOfGSM; }
            set { this.displayOfGSM = value; }
        }
    }
}
