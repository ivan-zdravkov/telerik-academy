using System;

namespace LINQ
{
    public class Student
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public int Age { set; get; }

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            if (age > 0 && age < 150)
            {
                this.Age = age;
            }
            else
            {
                throw new ArgumentException("A person's age must be [0, 150] years!");
            }
        }

        public override string ToString()
        {
            return String.Format("{0, 12} {1, -12} {2}", this.FirstName, this.LastName, this.Age);
        }
    }
}
