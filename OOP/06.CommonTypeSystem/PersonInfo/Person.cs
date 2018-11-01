using System;

namespace PersonInfo
{
    class Person
    {
        private string name;
        private int? age;

        public Person (string name, int? age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            if (this.age == null)
            {
                return String.Format("Name: {0, -10} Age: NOT SPECIFIED", this.name);
            }
            else
            {
                return String.Format("Name: {0, -10} Age: {1}", this.name, this.age);
            }
        }
    }
}
