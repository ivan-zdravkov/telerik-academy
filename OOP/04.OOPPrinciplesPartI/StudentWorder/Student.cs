using System;

namespace StudentWorder
{
    class Student : Human
    {
        public string FirstName
        {
          get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private double grade;
        public double Grade
        {
          get { return grade; }
          set { grade = value; }
        }

        public Student(string fName, string lName, double grade) : base(fName, lName)
        {
            this.grade = grade;
        }

        public override string ToString()
        {
            return String.Format("{0,12} {1,-12} Grade: {2};", this.FirstName, this.LastName, this.Grade);
        }
    }
}
