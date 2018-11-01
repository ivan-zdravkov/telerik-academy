using System;

namespace StudentWorder
{
    abstract class Human
    {
        protected string firstName;
        public string FName { get { return firstName; } }
        
        protected string lastName;

        public string LName { get { return lastName; } }

        public Human(string fName, string lName)
        {
            this.firstName = fName;
            this.lastName = lName;
        }
    }
}
