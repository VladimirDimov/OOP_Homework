
namespace SchoolClasses
{
    using System;

    public class Student : Human
    {
        private uint classNumber;

        public uint ClassNumber
        {
            get 
            {
                return this.classNumber;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Class number must be bigger than zero");
                }

                this.classNumber = value;
            }
        }
    }
}
