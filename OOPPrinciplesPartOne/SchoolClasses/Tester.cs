using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Tester
    {
        static void Main()
        {
            Class SecondC = new Class("Second C");
            Teacher pesho = new Teacher("Pesho", "Peshev");
            pesho.SetOfDisciplines.Add(new Discipline("Maths for first grade", 8, 4));
            pesho.SetOfDisciplines.Add(new Discipline("Maths for second grade", 8, 4));
       
            Console.WriteLine(pesho.ToString());
            foreach (var discipline in pesho.SetOfDisciplines)
            {
                Console.WriteLine(discipline.ToString());
            }
        }
    }
}
