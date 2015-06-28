using System;
using System.Linq;


class FirstBeforeLast
{
    static void Main(string[] args)
    {
        Student[] arr = new Student[5]{
            new Student("John", "Smith"),
            new Student("Elvis", "Presley"),
            new Student("Michael", "Jackson"),
            new Student("Bill", "Gates"),
            new Student("Steve", "Jobs")
        };

        var myQuery = arr
            .Where(student => student.FirstName.CompareTo(student.LastName) <= 0)
            .OrderBy(student => student.FirstName);

        foreach (var student in myQuery)
            Console.WriteLine(student);

        Console.WriteLine();

        var myQuery2 =
            from student in arr
            where student.FirstName.CompareTo(student.LastName) <= 0
            orderby student.FirstName
            select student;

        foreach (var student in myQuery2)
            Console.WriteLine(student);
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public override string ToString()
        {
            return String.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
