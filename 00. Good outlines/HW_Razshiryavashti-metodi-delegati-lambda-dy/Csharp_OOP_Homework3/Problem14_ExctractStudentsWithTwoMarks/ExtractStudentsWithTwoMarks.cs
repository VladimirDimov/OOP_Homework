using System;
using System.Collections.Generic;
using System.Linq;

class ExtractStudentsWithTwoMarks
{
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

        listOfStudents[0].Email = "johny@gmail.com";
        listOfStudents[1].Email = "presley@abv.bg";
        listOfStudents[2].Email = "mj@hotmail.com";
        listOfStudents[3].Email = "boss@microsoft.com";
        listOfStudents[4].Email = "jobs@abv.bg";

        // Phone numbers start with country code followed by regional code and finally number
        // Note: Zeros in regional codes are ignored
        listOfStudents[0].Tel = "3592444333";
        listOfStudents[1].Tel = "25432565497";
        listOfStudents[2].Tel = "359988235544";
        listOfStudents[3].Tel = "3592123456";
        listOfStudents[4].Tel = "5012465764";

        listOfStudents[0].Marks.AddRange(new byte[] { 3, 4, 6, 2 });
        listOfStudents[1].Marks.AddRange(new byte[] { 2, 2, 3 });
        listOfStudents[2].Marks.AddRange(new byte[] { 6, 6 });
        listOfStudents[3].Marks.AddRange(new byte[] { 2, 6, 2 });
        listOfStudents[4].Marks.AddRange(new byte[] { 2, 2, 2 });

        Random rand = new Random();
        foreach (var student in listOfStudents)
        {
            student.GroupNumber = (byte?)rand.Next(1, 3);
            Console.WriteLine(student);
        }

        Console.WriteLine();
        var myQuery =
            from student in listOfStudents
            where student.Marks.HasExactlyTwoElementsOf<byte>(2)
            select new { FullName = string.Join(" ", student.FirstName, student.LastName), Marks = string.Join(", ", student.Marks) };
        foreach (var student in myQuery)
            Console.WriteLine(student);

        Console.WriteLine();
        var myQuery2 = listOfStudents
            .Where(student => student.Marks.HasExactlyTwoElementsOf<byte>(2))
            .Select(student => new { FullName = string.Join(" ", student.FirstName, student.LastName), Marks = string.Join(", ", student.Marks) });
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
            return String.Format("{0} {1}\nTel: {2}, Email: {3}, Group Number: {4}, Marks: {5}", this.FirstName, this.LastName, this.Tel, this.Email, this.GroupNumber, string.Join(", ", this.Marks));
        }
    }
}

static class Extensions
{
    public static bool HasExactlyTwoElementsOf<T>(this IEnumerable<T> collection, T item)
    {
        int counter = 0;
        foreach (var element in collection)
            if (element.Equals(item))
            {
                counter++;
                if (counter == 3) break;
            }

        if (counter == 2)
            return true;
        else
            return false;
    }
}
