using System;
using System.Collections.Generic;
using System.Linq;

class GroupByGroupNumber
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

        listOfStudents[0].Marks.AddRange(new byte[] { 3, 4, 6 });
        listOfStudents[1].Marks.AddRange(new byte[] { 2, 2, 2 });
        listOfStudents[2].Marks.AddRange(new byte[] { 6, 6 });
        listOfStudents[3].Marks.AddRange(new byte[] { 5, 6, 5 });
        listOfStudents[4].Marks.AddRange(new byte[] { 4 });

        Random rand = new Random();
        foreach (var student in listOfStudents)
        {
            student.GroupNumber = (byte?)rand.Next(1, 3);
            Console.WriteLine(student);
        }

        Group[] myGroups = new Group[]
        {
            new Group(1, "Physics"),
            new Group(2, "Mathematics")
        };

        // All Departments
        Console.WriteLine();
        var joinQuerry1 =
            from agroup in myGroups     
            join student in listOfStudents on agroup.GroupNumber equals student.GroupNumber
            select new { StudentName = string.Join(" ", student.FirstName, student.LastName), Department = agroup.DepartmenteName };
        foreach (var element in joinQuerry1)
            Console.WriteLine(element);

        // Just the mathematics department
        Console.WriteLine();
        var joinQuerry =
            from agroup in myGroups
            where agroup.DepartmenteName == "Mathematics"
            join student in listOfStudents on agroup.GroupNumber equals student.GroupNumber
            select new { StudentName = string.Join(" ", student.FirstName, student.LastName), Department = agroup.DepartmenteName };            
        foreach (var element in joinQuerry)
            Console.WriteLine(element);
    }

    class Group
    {
        public byte? GroupNumber { get; set; }
        public string DepartmenteName { get; set; }

        public Group(byte groupNumber, string departmentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmenteName = departmentName;
        }
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
