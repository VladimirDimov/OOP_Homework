namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Teacher : Human
    {
        private List<Discipline> setOfDisciplines = new List<Discipline>();

        public Teacher() : base()
        {
            this.setOfDisciplines = new List<Discipline>();
        }

        public Teacher(string firstName, string lastName) : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Teacher(string firstName, string lastName, List<Discipline> disciplines) : this()            
        {
            this.SetOfDisciplines = disciplines;
        }

        public List<Discipline> SetOfDisciplines
        {
            get
            {
                return this.setOfDisciplines;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Invalid discipline null value");
                }

                this.setOfDisciplines = value;
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendFormat("{0} {1}", this.FirstName, this.LastName);
            return builder.ToString();
        }
    }
}
