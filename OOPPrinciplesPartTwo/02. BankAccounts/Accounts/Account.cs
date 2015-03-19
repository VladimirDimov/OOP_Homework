using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.BankAccounts
{
    public abstract class Account
    {
        private const decimal DefaultInterestRate = 0.5m;
        // fields
        private Customer customer;
        private decimal interestRate;
        private decimal balance;
        
        // constructors
        protected Account(Customer customer)
        {
            this.Customer = customer;
            this.balance = 0;
            this.interestRate = DefaultInterestRate;
        }

        protected Account(Customer customer, decimal balance) : this(customer)
        {
            this.balance = balance;
        }

        protected Account(Customer customer, decimal balance, decimal interestRate)
            : this(customer, balance)
        {
            this.InterestRate = interestRate;
        }

        // properties
        public Customer Customer 
        {
            get { return this.customer; }
            set { this.customer = value; }
        }

        public decimal InterestRate 
        {
            get { return this.interestRate; }
            set {this.interestRate = value;}
        }

        public decimal Balance 
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        // abstract methods
        public abstract decimal InterestAmount(int numberOfMonths);
    }
}
