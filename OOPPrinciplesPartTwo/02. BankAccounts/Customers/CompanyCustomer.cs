namespace _02.BankAccounts
{
    using System;

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
    }
}
