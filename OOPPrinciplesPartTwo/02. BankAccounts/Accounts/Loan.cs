namespace _02.BankAccounts
{
    using System;

    public class Loan : Account, IDeposit
    {
        // constructors
        public Loan(Customer customer)
            : base(customer)
        {
        }

        public Loan(Customer customer, decimal balance)
            : base(customer, balance)
        {
        }

        public Loan(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        // properties
        public override decimal InterestAmount(int numberOfMonths)
        {
            if (this.Customer is IndividualCustomer)
            {
                if (numberOfMonths <= 3)
                {
                    return 0;
                }
                else
                {
                    return this.Balance * (numberOfMonths - 3) * this.InterestRate;
                }
            }
            else if (this.Customer is CompanyCustomer)
            {
                if (numberOfMonths <= 2)
                {
                    return 0;
                }
                else
                {
                    return this.Balance * (numberOfMonths - 2) * this.InterestRate;
                }
            }

            throw new Exception("Invalid customer type");
        }

        public void DepositMoney(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Invalid deposit value");
            }

            this.Balance += amount;
        }
    }
}
