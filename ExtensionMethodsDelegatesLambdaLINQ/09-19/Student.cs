namespace _09_19
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Student
    {
        public Student(string firstName, string lastName, uint fn, string tel, string email,
            List<int> marks, byte groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public uint FN { get; set; }
        
        public string Tel { get; set; }
        
        public string Email { get; set; }
        
        public List<int> Marks { get; set; }

        public byte GroupNumber { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}, FN: {2}, Tel: {3}, Email: {4}, Marks: {5}, Group {6}",
                this.FirstName, this.LastName, this.FN, this.Tel, this.Email, 
                string.Join(", ", this.Marks), this.GroupNumber);
        }
    }

    public static class Extensions
    { 
        public static List<Student> SelectGroup(this List<Student> collection, byte group)
        {
            var sellection = collection.FindAll(x => x.GroupNumber == 2).OrderBy(x => x.FirstName).ToList<Student>();
            return sellection;
        }       
    }
}
