using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.BankAccounts
{
    public class IndividualCustomer : Customer
    {
        // fields
        private string firstName;
        private string lastName;

        // constructors
        public IndividualCustomer(string firstName, string lastName)
            : base()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        //properties
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Names must have at least two letters");
                }

                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("All names must start with capital letter");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Names must have at least two letters");
                }

                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("All names must start with capital letter");
                }

                this.lastName = value;
            }
        }

        // overrides
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(this.GetType().Name);
            builder.AppendFormat("Name: {0} {1}", this.FirstName, this.LastName);
            return builder.ToString();
        }
    }
}
