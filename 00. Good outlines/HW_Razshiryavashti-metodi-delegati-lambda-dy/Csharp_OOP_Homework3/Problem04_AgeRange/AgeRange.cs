using System;
using System.Linq;

class AgeRange
{
    static void Main(string[] args)
    {
        Student[] arr = new Student[5]{
            new Student("John", "Smith", 26),
            new Student("Elvis", "Presley", 23),
            new Student("Michael", "Jackson", 19),
            new Student("Bill", "Gates", 18),
            new Student("Steve", "Jobs", 27)
        };

        var myQuery = arr
            .Where(student => (18 <= student.Age) && (student.Age <= 24))
            .Select(student => new { FirstName = student.FirstName, LastName = student.LastName });

        foreach (var studentNames in myQuery)
            Console.WriteLine(studentNames);

        Console.WriteLine();

        var myQuery2 =
            from student in arr
            where (18 <= student.Age) && (student.Age <= 24)
            select new { FirstName = student.FirstName, LastName = student.LastName };

        foreach (var studentNames in myQuery2)
            Console.WriteLine(studentNames);
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
