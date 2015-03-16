namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    class Class
    {
        private string textID;
        private List<Student> students;
        private List<Teacher> teachers;

        //Constructors
        public Class(string id)
        {
            this.TextID = id;
            this.Students = new List<Student>();
            this.Teachers = new List<Teacher>();
        }

        public Class(string id, List<Student> students)
            :this(id)
        {
            this.Students = students;
        }

        public Class(string id, List<Student> students, List<Teacher> teachers)
            :this(id, students)
        {
            this.Teachers = teachers;
        }

        //Properties
        public string TextID
        {
            get
            {
                return this.textID;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Invalid text identifier");
                }

                this.textID = value;
            }
        }

        public List<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }

        public List<Teacher> Teachers
        {
            get { return this.teachers; }
            set { this.teachers = value; }
        }
    }
}
