namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Tester
    {
        static void Main()
        {
            Kitten topcho = new Kitten("Topcho", Animal.possibleSex.Male, 1);
            Kitten puhi = new Kitten("Puhi", Animal.possibleSex.Female, 2);
            topcho.MakeSound();
            
            Tomcat thomas = new Tomcat("Thomas", Animal.possibleSex.Male, 4);
            Tomcat edisson = new Tomcat("Edison", Animal.possibleSex.Male, 8);
            thomas.MakeSound();
            edisson.MakeSound();
            var allCats = new List<Cat>() { topcho, puhi, thomas, edisson };

            Dog bobbi = new Dog("Bobbi", Animal.possibleSex.Male, 3);
            Dog pluto = new Dog("Pluto", Animal.possibleSex.Male, 5);
            var allDogs = new List<Dog>() { bobbi, pluto };
            bobbi.MakeSound();

            Frog tsonka = new Frog("Tsonka", Animal.possibleSex.Female, 1);
            Frog boncho = new Frog("Boncho", Animal.possibleSex.Male, 2);
            var allFrogs = new List<Frog>() { tsonka, boncho };
            tsonka.MakeSound();

            Console.WriteLine("Average age:");
            Console.WriteLine("Cats average age:  {0}", Animal.AverageAge<Cat>(allCats));
            Console.WriteLine("Dogs average age:  {0}", Animal.AverageAge<Dog>(allDogs));
            Console.WriteLine("Frogs average age: {0}", Animal.AverageAge<Frog>(allFrogs));
        }
    }
}
