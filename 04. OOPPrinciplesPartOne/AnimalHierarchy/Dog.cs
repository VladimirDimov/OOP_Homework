namespace AnimalHierarchy
{
    using System;

    class Dog : Animal, ISound
    {
        public Dog(string name, possibleSex sex, uint age)
            : base(name, sex, age)
        {
        }

        public void MakeSound()
        {
            Console.WriteLine("{0} says Wof!" , this.Name);
        }
    }
}
