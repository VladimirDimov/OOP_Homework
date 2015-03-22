//Problem 4. Person class
//=======================
//Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. 
//Override ToString() to display the information of a person and if age is not specified – to say so.
//Write a program to test this functionality.
namespace _4.PersonClass
{
using System;

    class Program
    {
        static void Main()
        {
            // Testing null age
            Console.WriteLine("Testing person with null age:");
            Person pesho = new Person("Pesho Peshev");
            Console.WriteLine(pesho.ToString());

            // Testing non-null age
            Console.WriteLine();
            Console.WriteLine("Testing person with non-null age:");
            Person gosho = new Person("Gosho Goshev", 25);
            Console.WriteLine(gosho.ToString());
        }
    }
}
