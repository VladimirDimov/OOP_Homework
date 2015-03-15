namespace FirstBeforeLast
{
    using System;
    using System.Text;
    public class Student
    {
        private string firstName;
        private string lastName;
        private byte age;

        public Student(string firstName, string lastName, byte age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public byte Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age must be bigger than zero");
                }

                this.age = value;
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
                    throw new ArgumentException("Names must start with capital letter");
                }

                this.lastName = value;
            }
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
                    throw new ArgumentException("Names must start with capital letter");
                }

                this.firstName = value;
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendFormat("Student: {0} {1} Age: {2}", this.FirstName, this.LastName, this.Age);
            return builder.ToString();
        }
    }
}
