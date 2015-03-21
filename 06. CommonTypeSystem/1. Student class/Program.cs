// Problem 1. Student class
// ========================
// Define a class Student, which contains data about a student – first, middle and last name, SSN, 
// permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for
// the specialties, universities and faculties.
// Override the standard methods, inherited by System.Object: Equals(), 
// ToString(), GetHashCode() and operators == and !=.
namespace _1.Student_class
{
using System;

    class Program
    {
        static void Main()
        {
            Student pesho = new Student("Pesho", "Peshov", "Peshev", 12345678, "Sofia", "0245678", "pesho@abv.bg",
                Student.Universities.SU, 2, "IT", Student.Faculties.Math);
            Student gosho = new Student("Pesho", "Peshov", "Peshev", 12345678, "Sofia", "0245678", "pesho@abv.bg",
    Student.Universities.SU, 2, "IT", Student.Faculties.Math);
            Console.WriteLine(pesho.ToString());
            Console.WriteLine();
            Console.WriteLine(gosho.ToString());
            Console.WriteLine();
            Console.WriteLine("Compare Pesho and Gosho");
            Console.WriteLine(pesho.Equals(gosho));
            Console.WriteLine();
            Console.WriteLine("Pesho's HashCode {0}", pesho.GetHashCode());
            Console.WriteLine();
            Console.WriteLine("Pesho == Gosho -> {0}", pesho == gosho);
            
        }
    }
}
