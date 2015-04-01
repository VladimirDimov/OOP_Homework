namespace SchoolClasses
{
    using System;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human()
        {
            this.FirstName = "Undefined";
            this.LastName = "Undefined";
        }

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
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
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("All names must start with capital letter");
                }

                this.lastName = value;
            }
        }
    }
}
