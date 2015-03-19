namespace _02.BankAccounts
{
    using System;
    using System.Text;

    public class CompanyCustomer : Customer
    {
        // fields
        private string companyName;

        // constructors
        public CompanyCustomer(string companyName)
            : base()
        {
            this.CompanyName = companyName;
        }

        //properties
        public string CompanyName
        {
            get
            {
                return this.companyName;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Company name cannot be null");
                }

                this.companyName = value;
            }
        }

        // Overrides
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(this.GetType().Name);
            builder.AppendFormat("Company name: {0}", this.CompanyName);
            return builder.ToString();
        }
    }
}
