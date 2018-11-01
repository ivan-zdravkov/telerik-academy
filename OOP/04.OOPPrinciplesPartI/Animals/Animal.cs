using System;

namespace Animals
{
    abstract class Animal
    {
        protected int age;
        public int GetAge { get { return age; } }

        protected string name;
        protected string sex;

        public Animal(int age, string name, string sex)
        {
            if (this.age < 0)
            {
                throw new ArgumentException("The age of the animal must not be negative!");
            }
            else
            {
                this.age = age;
            }

            this.name = name;
            this.sex = sex;
        }
    }
}
