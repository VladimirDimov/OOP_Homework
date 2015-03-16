namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Discipline
    {
        private string name;
        private uint numberOfLectures;
        private uint numberOfExercises;

        public Discipline()
        {
            this.Name = "Undefined";
            this.numberOfLectures = 0;
            this.NumberOfExercises = 0;
        }

        public Discipline(string name) : this()
        {
            this.Name = name;
        }

        public Discipline(string name, uint numberOfLectures) : this(name)
        {
            this.NumberOfLectures = numberOfLectures;
        }

        public Discipline(string name, uint numberOfLectures, uint numberOfExercises)
            : this(name, numberOfLectures)
        {
            this.NumberOfExercises = numberOfExercises;
        }

        public string Name
        {
            get 
            {
                return this.name;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Invalid discipline null name");
                }

                this.name = value;
            }            
        }

        public uint NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Invalid number of lectures");
                }

                this.numberOfLectures = value;
            }
        }

        public uint NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Invalid number of lectures");
                }

                this.numberOfExercises = value;
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendFormat("{0}, Lectures: {1}, Exercises: {2}", Name, NumberOfLectures, NumberOfExercises);
            return builder.ToString();
        }

    }
}
