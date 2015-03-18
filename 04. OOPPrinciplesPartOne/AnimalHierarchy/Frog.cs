namespace AnimalHierarchy
{
    using System;

    class Frog : Animal , ISound
    {
        public Frog(string name, possibleSex sex, uint age)
            :base(name, sex, age)
        {
        }

        public void MakeSound()
        {
            Console.WriteLine("{0} says qwack!", this.Name);
        }
    }
}
