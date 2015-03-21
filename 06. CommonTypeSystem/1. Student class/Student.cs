namespace _1.Student_class
{
    using System;
    using System.Text;

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int SSN { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Universities University { get; set; }
        public int Course { get; set; }
        public string Speciality { get; set; }
        public Faculties Faculty { get; set; }

        public Student(string firstName, string middleName, string lastName,
            int ssn, string address, string phone, string email, Universities uni,
            int course, string speciality, Faculties faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.University = uni;
            this.Course = course;
            this.Speciality = speciality;
            this.Faculty = faculty;
        }

        public enum Universities
        {
            SU, TU, UACEG
        };

        public enum Faculties
        {
            Math, Physics, Engineering
        };

        public override bool Equals(object obj)
        {
            // Check if obj is a valid student object
            Student student = obj as Student;
            if (student == null)
            {
                return false;
            }
            if (!this.FirstName.Equals(student.FirstName)) return false;
            if (!this.LastName.Equals(student.LastName)) return false;
            if (!this.MiddleName.Equals(student.MiddleName)) return false;
            if (!this.SSN.Equals(student.SSN)) return false;
            if (!this.Address.Equals(student.Address)) return false;
            if (!this.Phone.Equals(student.Phone)) return false;
            if (!this.Email.Equals(student.Email)) return false;
            if (!this.University.Equals(student.University)) return false;
            if (!this.Course.Equals(student.Course)) return false;
            if (!this.Speciality.Equals(student.Speciality)) return false;
            if (!this.Faculty.Equals(student.Faculty)) return false;
            return true;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^
                this.MiddleName.GetHashCode() ^
                this.LastName.GetHashCode();
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendFormat("{0} {1} {2}\n", this.FirstName, this.MiddleName, this.LastName);
            builder.AppendFormat("SSN: {0}, Address: {1}, University: {2}", this.SSN, this.Address, this.University);
            return builder.ToString();
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return firstStudent.Equals(secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !firstStudent.Equals(secondStudent);
        }
    }
}
