using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Animal
    {
        public enum possibleSex { Male, Female };
        
        private possibleSex sex;

        public Animal(string name, possibleSex sex, uint age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;            
        }

        public string Name { get; set; }

        public uint Age { get; set; }

        public possibleSex Sex
        {
            get { return this.sex; }
            set { this.sex = value; }            
        }

        public static double AverageAge<T>(List<T> animals)
            where T : Animal
        {
            return animals.Average(x => x.Age);        
        }
    }
}
