namespace _1.Student_class
{
    using System;
    using System.Text;

    class Student : ICloneable, IComparable
    {
        #region Fields
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
        #endregion

        #region Constructors
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
        #endregion

        #region Enumerations
        public enum Universities
        {
            SU, TU, UACEG
        };

        public enum Faculties
        {
            Math, Physics, Engineering
        };    
        #endregion

        #region Overrides
        public override bool Equals(object obj)
        {            
            Student student = obj as Student;
            // Check if student is valid Student object
            if ((object)student == null)
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
        #endregion

        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName,
            this.SSN, this.Address, this.Phone, this.Email, this.University,
            this.Course, this.Speciality, this.Faculty);
        }
        
        public int CompareTo(object obj)
        {
            Student student = obj as Student;
            if (student == null)
            {
                throw new InvalidCastException("Invalid Student object");
            }

            string thisName = string.Format("{0} {1} {2}", this.FirstName, this.MiddleName, this.LastName);
            string studentName = string.Format("{0} {1} {2}", student.FirstName, student.MiddleName, student.LastName);
            if (thisName.CompareTo(studentName) != 0)
            {
                return thisName.CompareTo(studentName);
            }
            else if (this.SSN != student.SSN)
            {
                return this.SSN.CompareTo(student.SSN);
            }

            return 0;
        }
    }
}
