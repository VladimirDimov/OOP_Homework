// Problem 2. Students and workers
// ===============================
// Define abstract class Human with first name and last name. Define new class Student which is derived from Human and 
// has new field – grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and 
// method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy.
// Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
// Initialize a list of 10 workers and sort them by money per hour in descending order.
// Merge the lists and sort them by first name and last name.
namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Tester
    {
        static void Main()
        {
            // Initializing list of 10 students
            var students = new List<Student>();
            students.Add(new Student("Pesho", "Stanchev", 5));
            students.Add(new Student("Gosho", "Peshev", 7));
            students.Add(new Student("Ivan", "Ivanov", 5));
            students.Add(new Student("Dimo", "Padalski", 8));
            students.Add(new Student("Mincho", "Praznikov", 5));
            students.Add(new Student("Mitko", "Berbatov", 6));
            students.Add(new Student("Pesho", "Goshev", 8));
            students.Add(new Student("Bonka", "Toneva", 4));
            students.Add(new Student("Minka", "Mineva", 5));
            students.Add(new Student("Kamen", "Donev", 12));

            //Print all students
            Console.WriteLine("All students:");
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }

            // Sorting students by grade in ascending order
            Console.WriteLine();
            Console.WriteLine("Students ordered by grade:");
            var sortedByGrade = students.OrderBy(x => x.Grade).ThenBy(x => x.FirstName)
                .ThenBy(x => x.LastName);
            foreach (var student in sortedByGrade)
            {
                Console.WriteLine(student.ToString());
            }

        }
    }
}
