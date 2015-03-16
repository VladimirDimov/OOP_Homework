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
