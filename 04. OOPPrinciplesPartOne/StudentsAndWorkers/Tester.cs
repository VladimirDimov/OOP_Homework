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

            // Initializing a list of 10 workers
            Console.WriteLine();
            Console.WriteLine("Sorted workers by payment per hour:");
            var workers = new List<Worker>();
            workers.Add(new Worker("Gosho", "Tonev", 8, 7));
            workers.Add(new Worker("Toncho", "Goshev", 8, 5));
            workers.Add(new Worker("Mincho", "Penev", 8, 6));
            workers.Add(new Worker("Pencho", "Minev", 8, 4));
            workers.Add(new Worker("Boncho", "Genchev", 8, 9));
            workers.Add(new Worker("Gencho", "Bonev", 8, 10));
            workers.Add(new Worker("Muncho", "Monev", 8, 12));
            workers.Add(new Worker("Pesho", "Gochev", 8, 3));
            workers.Add(new Worker("Gocho", "Peshev", 8, 11));
            workers.Add(new Worker("Kevork", "Kevorkian", 8, 8));

            // sort workers by payment
            var sortedByPayment = workers.OrderByDescending(x => x.MoneyPerHour);
            foreach (var worker in sortedByPayment)
            {
                Console.WriteLine(worker.ToString());
            }

            // Merge students and workers
            Console.WriteLine();
            Console.WriteLine("Merge students and workers and sort them by first and last name ...");
            var studentsAndWorkers =
                students.Select(s => (Human)s).Concat(workers.Select(w => (Human)w)).OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            foreach (var person in studentsAndWorkers)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }
        }
    }
}
