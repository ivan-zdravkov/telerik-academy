using System;
namespace Animals
{
    class Frog : Animal, ISound
    {
        public int Age 
        { 
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public Frog(int age, string name, string sex) : base(age, name, sex) { }

        public string MakeSound()
        {
            return "Wreck, wreck, wreck...";
        }
    }
}
