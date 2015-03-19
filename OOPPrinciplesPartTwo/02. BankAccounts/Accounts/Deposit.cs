using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.BankAccounts
{
    public class Deposit : Account, IDeposit, IWithDraw
    {
        // constructors
        public Deposit(Customer customer) : base(customer)
        {
        }

        public Deposit(Customer customer, decimal balance)
            : base(customer, balance)
        {
        }

        public Deposit(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal InterestAmount(int numberOfMonths)
        {
            if (0<=this.Balance && this.Balance < 1000)
            {
                return 0m;
            }
            else
            {
                return numberOfMonths * InterestRate;
            }
        }

        public void DepositMoney(decimal amount)
        {
            if (amount < 0)
            {
                throw new InavalidAmountException("Invalid deposite amount");
            }

            this.Balance += amount;
        }

        public void WithdrawMoney(decimal amount)
        {
            if (amount < 0)
            {
                throw new InavalidAmountException("Invalid withdraw amount");
            }
            else if (amount > this.Balance)
            {
                throw new Exception();
            }

            this.Balance -= amount;
        }
    }
}
