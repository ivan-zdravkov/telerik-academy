using System;

namespace Animals
{
    abstract class Cat : Animal
    {
        virtual public int Age 
        { 
            get { return age; }
            set { age = value; }
        }

        virtual public string Name
        {
            get { return name; }
            set { name = value; }
        }

        virtual public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public Cat(int age, string name, string sex) : base(age, name, sex) { }
    }
}
