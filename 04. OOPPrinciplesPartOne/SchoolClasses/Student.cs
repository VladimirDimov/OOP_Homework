namespace SchoolClasses
{
    using System;

    public class Student : Human
    {
        private uint classNumber;

        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
            this.ClassNumber = 0;
        }

        public Student(string firstName, string lastName, uint classNumber)
            : this(firstName, lastName)
        {
            this.ClassNumber = classNumber;
        }

        public uint ClassNumber
        {
            get 
            {
                return this.classNumber;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid class number");
                }

                this.classNumber = value;
            }
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + "Number: " + this.ClassNumber;
        }
    }
}
