using System;
using System.Collections.Generic;
using System.Linq;

class ExtractAllMarks
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

        listOfStudents[0].FN = new byte[] { 0, 1, 0, 1, 0, 3, 7, 8, 9 };
        listOfStudents[1].FN = new byte[] { 1, 5, 0, 9, 0, 7, 2, 3, 0 };
        listOfStudents[2].FN = new byte[] { 2, 2, 1, 1, 0, 6, 1, 2, 1 };
        listOfStudents[3].FN = new byte[] { 3, 0, 0, 5, 0, 6, 2, 5, 5 };
        listOfStudents[4].FN = new byte[] { 1, 4, 0, 3, 1, 1, 7, 7, 6 };

        Random rand = new Random();
        foreach (var student in listOfStudents)
        {
            student.GroupNumber = (byte?)rand.Next(1, 3);
            Console.WriteLine(student);
        }

        Console.WriteLine();
        var myQuery =
            from student in listOfStudents
            where student.FN[4] == 0 && student.FN[5] == 6
            select string.Join(", ", student.Marks);
        
        Console.WriteLine("Marks: {0}", string.Join(", ", myQuery));

        Console.WriteLine();
        var myQuery2 = listOfStudents
            .Where(student => student.FN[4] == 0 && student.FN[5] == 6)
            .Select(student => string.Join(", ", student.Marks));

        Console.WriteLine("Marks: {0}", string.Join(", ", myQuery2));
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
            return String.Format("{0} {1}\nTel: {2}, Email: {3}, FN: {4},\nGroup Number: {5}, Marks: {6}", this.FirstName, this.LastName, this.Tel, this.Email,string.Join("",this.FN), this.GroupNumber, string.Join(", ", this.Marks));
        }
    }
}
