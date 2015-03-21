// Problem 1. Student class
// Problem 2. IClonable
// Problem 3. IComparable
namespace _1.Student_class
{
    using System;

    class Program
    {
        static void Main()
        {
            // Problem 1. Student class
            // ========================
            // Define a class Student, which contains data about a student – first, middle and last name, SSN, 
            // permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for
            // the specialties, universities and faculties.
            // Override the standard methods, inherited by System.Object: Equals(), 
            // ToString(), GetHashCode() and operators == and !=.
            // =======================================================================================================
            Console.WriteLine("Problem 1. Student class\n");
            Student pesho = new Student("Pesho", "Peshov", "Peshev", 12345678, "Sofia", "0245678", "pesho@abv.bg",
                Student.Universities.SU, 2, "IT", Student.Faculties.Math);
            Student gosho = new Student("Gosho", "Goshev", "Goshev", 65412345, "Plovdiv", "0245678", "gosho@abv.bg",
                Student.Universities.SU, 2, "IT", Student.Faculties.Math);
            Console.WriteLine(pesho.ToString());
            Console.WriteLine();
            Console.WriteLine(gosho.ToString());
            Console.WriteLine();
            Console.WriteLine("Compare Pesho and Gosho");
            Console.WriteLine(pesho.Equals(gosho));
            Console.WriteLine();
            Console.WriteLine("Pesho's HashCode {0}", pesho.GetHashCode());
            Console.WriteLine("Gosho's HashCode {0}", gosho.GetHashCode());
            Console.WriteLine();
            Console.WriteLine("Pesho == Gosho -> {0}", pesho == gosho);
            Console.WriteLine("Pesho != Gosho -> {0}", pesho != gosho);

            // Problem 2. IClonable
            // ====================
            // Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields 
            // into a new object of type Student.
            // ==========================================================================================================
            Console.WriteLine();
            Console.WriteLine("Problem 2. IClonable");
            Console.WriteLine("Cloning pesho:");
            Student copyOfPesho = (Student)pesho.Clone();
            Console.WriteLine("Print copyOfPesho");
            Console.WriteLine(pesho.ToString());
            Console.WriteLine("pesho == copyOfPesho --> {0}", pesho == copyOfPesho);
            Console.WriteLine("Compare with ReferenceEquals --> {0}", object.ReferenceEquals((object)pesho, (object)copyOfPesho));
            Console.WriteLine();
            Console.WriteLine("Create ReferenceCopyOfPesho:");
            Student referenceCopyOfPesho = pesho;
            Console.WriteLine("pesho == ReferenceCopyOfPesho --> {0}", pesho == copyOfPesho);
            Console.WriteLine("Compare with ReferenceEquals --> {0}", object.ReferenceEquals((object)pesho, (object)referenceCopyOfPesho));

            // Problem 3. IComparable
            // ======================
            // Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) 
            // and by social security number (as second criteria, in increasing order).
            // =====================================================================================================================
            Console.WriteLine();
            Console.WriteLine("Problem 3. IComparable");
            Console.WriteLine("Compare pesho to gosho --> {0}", pesho.CompareTo(gosho));
            Console.WriteLine("Compare pesho to copyOfPesho --> {0}", pesho.CompareTo(copyOfPesho));            
        }
    }
}
