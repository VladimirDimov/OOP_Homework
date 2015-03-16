namespace _09_19
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Tester
    {
        public static void Main()
        {
            // Create sample list of students
            List<Student> allStudents = new List<Student>();
            allStudents.Add(new Student("Anton", "Bonev", 100006, "02/77123456", "anton@mail.bg", new List<int>() { 4, 5, 6 }, 1));
            allStudents.Add(new Student("Boncho", "Antonov", 100104, "02/77458971", "boncho@mail.bg", new List<int>() { 4, 4, 2 }, 1));
            allStudents.Add(new Student("Pesho", "Genchev", 100205, "+359877986532", "pesho@abv.bg", new List<int>() { 4, 3, 3 }, 1));
            allStudents.Add(new Student("Gencho", "Peshev", 100306, "+359877134679", "gencho@mail.bg", new List<int>() { 3, 5, 2 }, 1));
            allStudents.Add(new Student("Pancho", "Tonev", 100408, "+359877748596", "pancho@mail.bg", new List<int>() { 2, 5, 3 }, 2));
            allStudents.Add(new Student("Toncho", "Panev", 100512, "+359877142536", "toncho@abv.bg", new List<int>() { 3, 3, 4 }, 2));
            allStudents.Add(new Student("Pencho", "Georgiev", 100615, "02/77956284", "pencho@mail.bg", new List<int>() { 6, 5 }, 2));
            allStudents.Add(new Student("Georgi", "Penev", 101006, "02/77427553", "joro@abv.bg", new List<int>() { 4, 6 }, 2));

            Console.WriteLine("All students:");
            foreach (var student in allStudents)
            {
                Console.WriteLine(student.ToString());
            }

            // Problem 9. Student groups
            // =========================
            // Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
            // Create a List<Student> with sample students. Select only the students that are from group number 2.
            // Use LINQ query. Order the students by FirstName.
            Console.WriteLine();
            Console.WriteLine("Students from group 2 in order by first name:");
            var groupTwo =
                from student in allStudents
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;
            foreach (var student in groupTwo)
            {
                Console.WriteLine(student.ToString());
            }

            // Problem 10. Student groups extensions
            // =====================================
            // Implement the previous using the same query expressed with extension methods.
            Console.WriteLine();
            Console.WriteLine("Students from group 2 in order by first name (using extension methods):");
            List<Student> sellection = allStudents.SelectGroup(2);
            foreach (var student in sellection)
            {
                Console.WriteLine(student.ToString());
            }

            // Problem 11. Extract students by email
            // =====================================
            // Extract all students that have email in abv.bg.
            // Use string methods and LINQ.
            Console.WriteLine();
            Console.WriteLine("Students with email in abv.bg");
            var studentsByMail = allStudents.FindAll(x => x.Email.EndsWith("@abv.bg"));
            foreach (var stude in studentsByMail)
            {
                Console.WriteLine(stude.ToString());
            }

            // Problem 12. Extract students by phone
            // =====================================
            // Extract all students with phones in Sofia.
            // Use LINQ.
            Console.WriteLine();
            Console.WriteLine("Students with a phone number in Sofia");
            var studentsByPhone = allStudents.FindAll(x => x.Tel.StartsWith("02/"));
            foreach (var student in studentsByPhone)
            {
                Console.WriteLine(student.ToString());
            }

            // Problem 13. Extract students by marks
            // =====================================
            // Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
            // Use LINQ.
            Console.WriteLine();
            Console.WriteLine("Students with atleast one exelent mark:");
            var studentsWithExcelentMark = allStudents.FindAll(x => x.Marks.Any(m => m == 6));

            foreach (var student in studentsWithExcelentMark)
            {
                var extractedStudent = new
                {
                    FullName = string.Format("{0} {1}", student.FirstName, student.LastName),
                    Marks = string.Join(", ", student.Marks)
                };
                Console.WriteLine(extractedStudent.ToString());
            }

            // Problem 14. Extract students with two marks
            // ===========================================
            // Write down a similar program that extracts the students with exactly two marks "2".
            // Use extension methods.
            Console.WriteLine();
            Console.WriteLine("Students with two marks:");
            var studentsWithTwoMarks = allStudents.FindAll(x => x.Marks.Count == 2);
            foreach (var student in studentsWithTwoMarks)
            {
                Console.WriteLine(student.ToString());
            }

            // Problem 15. Extract marks
            // =========================
            // Extract all Marks of the students that enrolled in 2006. 
            // (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
            Console.WriteLine();
            Console.WriteLine("Marks of the students, enrolled in 2006:");
            var studentsMarks = allStudents.FindAll(x => x.FN.ToString().EndsWith("06"))
                .Select(x => x.Marks);
            List<int> marks2006 = new List<int>();
            foreach (var marks in studentsMarks)
            {
                foreach (var mark in marks)
                {
                    marks2006.Add(mark);
                }
            }

            Console.WriteLine(string.Join(", ", marks2006));

            // Problem 17. Longest string
            // ==========================
            // Write a program to return the string with maximum length from an array of strings.
            // Use LINQ.
            Console.WriteLine("Longest student firs name");
            var longestFirstName = allStudents.Select(x => x.FirstName).ToArray().OrderByDescending(x => x.Length).First();
            Console.WriteLine(longestFirstName);

            // Problem 18. Grouped by GroupNumber
            // ==================================
            // Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
            // Use LINQ.
            Console.WriteLine();
            Console.WriteLine("Order by group number (using LINQ):");
            var groups =
                 from student in allStudents
                 group student by student.GroupNumber into newGroup
                 select newGroup;

            foreach (var group in groups)
            {
                Console.WriteLine("Group {0}", group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine(student.FirstName + " " + student.LastName);
                }
            }

            // Problem 19. Grouped by GroupName extensions
            // ===========================================
            // Rewrite the previous using extension methods.
            Console.WriteLine();
            Console.WriteLine("Order by group number (using extension methods):");
            var groupByGroupNumber = allStudents.GroupBy(x => x.GroupNumber); // ByGroup extension method is declared in Students.cs
            foreach (var group in groupByGroupNumber)
            {
                Console.WriteLine("Group " + group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine(student.FirstName + " " + student.LastName);
                }
            }
        }
    }
}