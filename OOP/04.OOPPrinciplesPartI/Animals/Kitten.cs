using System;

namespace Animals
{
    class Kitten : Cat, ISound
    {
        public override int Age 
        { 
            get { return age; }
            set { age = value; }
        }

        public override string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string Sex
        {
            get { return base.Sex; }
            set { base.Sex = value; }
        }
        public Kitten(int age, string name, string sex) : base(age, name, sex) 
        { 
            if (!(sex == "female" || sex == "Female" || sex == "F" || sex == "f"))
            {
                throw new ArgumentException("Kittens may only be female!");
            }
        }

        public string MakeSound()
        {
            return "Purr, purr, purr...";
        }
    }
}
