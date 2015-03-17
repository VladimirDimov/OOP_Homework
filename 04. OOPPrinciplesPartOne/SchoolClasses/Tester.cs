// Problem 1. School classes
// =========================
// We are given a school. In the school there are classes of students. Each class has a set of teachers. 
// Each teacher teaches a set of disciplines. Students have name and unique class number. 
// Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises. 
// Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments 
// (free text block).
// Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields, define the 
// class hierarchy and create a class diagram with Visual Studio.

namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Tester
    {
        public static void Main()
        {
            // declaring a class
            Class secondC = new Class("Second C");

            // declaring some teachers
            Teacher peshoPeshev = new Teacher("Pesho", "Peshev");
            peshoPeshev.SetOfDisciplines.Add(new Discipline("Maths for first grade", 8, 4));
            peshoPeshev.SetOfDisciplines.Add(new Discipline("Maths for second grade", 8, 4));
            Teacher ivanIvanov = new Teacher("Ivan", "Ivanov");
            ivanIvanov.SetOfDisciplines.Add(new Discipline("Literature for second grade"));
            ivanIvanov.SetOfDisciplines.Add(new Discipline("Literature for third grade"));

            // declaring some students
            Student pPenev = new Student("Pencho", "Penev", 201201);
            Student gGoshev = new Student("Gosho", "Goshev", 201202);

            // Add teachers and students to second C class
            secondC.Teachers.Add(peshoPeshev);
            secondC.Teachers.Add(ivanIvanov);
            secondC.Students.Add(pPenev);
            secondC.Students.Add(gGoshev);

            // Print class info
            Console.WriteLine("Class: {0}", secondC.ToString());
            Console.WriteLine();
            Console.WriteLine("Teachers:");
            foreach (var teacher in secondC.Teachers)
            {
                Console.WriteLine(teacher.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("Students:");
            foreach (var student in secondC.Students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
