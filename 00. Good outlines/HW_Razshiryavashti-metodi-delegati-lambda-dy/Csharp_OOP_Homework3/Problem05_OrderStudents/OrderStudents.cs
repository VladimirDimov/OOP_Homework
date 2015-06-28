using System;
using System.Linq;

class OrderStudents
{
    static void Main(string[] args)
    {
        Student[] arr = new Student[5]{
            new Student("John", "Smith", 26),
            new Student("Bill", "Presley", 23),
            new Student("Michael", "Jackson", 19),
            new Student("Bill", "Gates", 18),
            new Student("Michael", "Jobs", 27)
        };

        var myQuery = arr
            .OrderBy(student => student.FirstName)
            .ThenBy(student => student.LastName);

        foreach (var student in myQuery)
            Console.WriteLine(student);

        Console.WriteLine();

        var myQuery2 =
            from student in arr
            orderby student.FirstName, student.LastName
            select student;

        foreach (var student in myQuery2)
            Console.WriteLine(student);
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public override string ToString()
        {
            return String.Format("{0} {1}, Age: {2}", this.FirstName, this.LastName, this.Age);
        }
    }
}
