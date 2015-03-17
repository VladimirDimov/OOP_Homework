namespace StudentsAndWorkers
{
    using System;

    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName)
            : base(firstName, lastName)
        {
            this.grade = 1;
        }

        public Student(string firstName, string lastName, int grade)
            : this(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid student grade value");
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0,-20} grade: {1}", this.FirstName + " " + this.LastName, this.Grade);
        }
    }
}
