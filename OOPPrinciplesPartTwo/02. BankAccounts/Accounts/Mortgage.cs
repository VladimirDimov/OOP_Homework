namespace _02.BankAccounts
{
    using System;

    public class Mortgage : Account, IDeposit
    {
        // constructors
        public Mortgage(Customer customer)
            : base(customer)
        {
        }

        public Mortgage(Customer customer, decimal balance)
            : base(customer, balance)
        {
        }

        public Mortgage(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        // properties
        public override decimal InterestAmount(int numberOfMonths)
        {
            if (this.Customer is CompanyCustomer)
            {
                if (numberOfMonths <= 12)
                {
                    return this.Balance * numberOfMonths * this.InterestRate * 0.5m;
                }
                else
                {
                    return this.Balance * 12 * this.InterestRate * 0.5m + (numberOfMonths - 12) * this.InterestRate;
                }
            }
            else if (this.Customer is IndividualCustomer)
            {
                if (numberOfMonths <= 6)
                {
                    return this.Balance * numberOfMonths * this.InterestRate * 0.5m;
                }
                else
                {
                    return this.Balance * 6 * this.InterestRate * 0.5m + (numberOfMonths - 6) * this.InterestRate;
                }
            }

            throw new Exception("Invalid customer type");
        }

        public void DepositMoney(decimal amount)
        {
            if (amount < 0)
            {
                throw new InavalidAmountException("Invalid deposite amount");
            }

            this.Balance += amount;
        }
    }
}
