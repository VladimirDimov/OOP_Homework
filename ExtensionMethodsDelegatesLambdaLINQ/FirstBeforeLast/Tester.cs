namespace FirstBeforeLast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Tester
    {
        private static void Main()
        {
            // Create list of students
            var allStuents = new List<Student>();
            allStuents.Add(new Student("Pesho", "Peshev", 19));
            allStuents.Add(new Student("Boncho", "Goshev", 26));
            allStuents.Add(new Student("Dimo", "Padalski", 45));
            allStuents.Add(new Student("Boncho", "Bonev", 24));
            allStuents.Add(new Student("Minka", "Bonva", 26));

            // Printing list of students
            Console.WriteLine("List of all students:");
            foreach (var student in allStuents)
            {
                Console.WriteLine(student.ToString());
            }

            // Problem 3. First before last
            // ============================
            // Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
            // Use LINQ query operators.
            Console.WriteLine();
            Console.WriteLine("Students which first name is before last name alphabetically:");
            var firstBfLast = FirstBfLast(allStuents);
            foreach (var student in firstBfLast)
            {
                Console.WriteLine(student.ToString());
            }

            // Problem 4. Age range
            // ====================
            // Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
            Console.WriteLine();
            Console.WriteLine("Students whose age is between 18 and 24:");
            var sortedByAge =
                from student in allStuents
                where student.Age >= 18
                where student.Age <= 24
                select student;

            foreach (var student in sortedByAge)
            {
                Console.WriteLine(student.ToString());
            }

            // Problem 5. Order students
            // =========================
            // Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by 
            // first name and last name in descending order.
            // Rewrite the same with LINQ.
            Console.WriteLine();
            Console.WriteLine("Ordered by first and last name (using lambda expressions)):");
            var sortedByName = allStuents.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);
            foreach (var student in sortedByName)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("Ordered by first and last name (using LINQ qury)):");
            var sortedByNameByQURY =
                from student in allStuents
                orderby  student.FirstName descending, student.LastName descending
                select student;

            foreach (var student in sortedByNameByQURY)
            {
                Console.WriteLine(student.ToString());
            }
        }

        private bool SortAge(Student student)
        {
            if (student.Age >= 18 && student.Age <= 24)
            {
                return true;
            }
            return false;
        }

        private static List<Student> FirstBfLast(List<Student> students)
        {
            var firstBfLast =
                from student in students
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            return firstBfLast.ToList<Student>();
        }
    }
}
