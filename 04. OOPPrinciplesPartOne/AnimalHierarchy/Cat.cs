namespace AnimalHierarchy
{
    using System;

    public class Cat : Animal, ISound
    {
        private const string sound = "Mew!";

        public Cat(string name, possibleSex sex, uint age) 
            : base(name, sex, age)
        {
        }
        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", this.Name, sound);
        }
    }
}
