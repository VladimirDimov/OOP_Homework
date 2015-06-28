using System;
using System.Collections.Generic;
using System.Linq;

class StudentGroups
{
    // This is both Problem 9 and 10
    static void Main(string[] args)
    {
        List<Student> listOfStudents = new List<Student>()
        {
            new Student("John", "Smith"),
            new Student("Elvis", "Presley"),
            new Student("Michael", "Jackson"),
            new Student("Bill", "Gates"),
            new Student("Steve", "Jobs")
        };

        Random rand = new Random();

        foreach (var student in listOfStudents)
        {
            student.GroupNumber =(byte?)rand.Next(1, 3);
            Console.WriteLine(student);
        }

        // Problem 9 part
        Console.WriteLine();
        var myQuery =
            from student in listOfStudents
            where student.GroupNumber == 2
            orderby student.FirstName
            select student;
        foreach (var student in myQuery)
            Console.WriteLine(student);

        // Problem 10 part
        Console.WriteLine();
        var myQuery2 = listOfStudents
            .Where(student => student.GroupNumber == 2)
            .OrderBy(student => student.FirstName);
        foreach (var student in myQuery2)
            Console.WriteLine(student);        
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<byte> Marks { get; set; }
        public byte? GroupNumber { get; set; }

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Marks = new List<byte>();
        }
        public override string ToString()
        {
            return String.Format("{0} {1}, Group Number: {2}", this.FirstName, this.LastName, this.GroupNumber);
        }
        }
}
