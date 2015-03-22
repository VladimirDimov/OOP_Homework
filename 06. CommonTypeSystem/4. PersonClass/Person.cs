namespace _4.PersonClass
{
    using System;
    using System.Text;

    class Person
    {
        public string Name { get; set; }
        public int? Age { get; set; }

        public Person(string name)
        {
            this.Name = name;
            this.Age = null;
        }

        public Person(string name, int? age) : this(name)
        {
            this.Age = age;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendFormat("{0}, ", this.Name);
            builder.AppendFormat(this.Age != null ? "Age: {0}" : "Unspecified age", this.Age);
            return builder.ToString();
        }
    }
}
