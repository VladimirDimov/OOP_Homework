namespace _09_19
{
using System;

    class Group
    {
        public Group(int number, string department)
        {
            this.GroupNumber = number;
            this.DepartmentName = department;
        }
        public int GroupNumber { get; set; }
        public string DepartmentName { get; set; }
    }
}
