using System;

namespace Animals
{
    class Tomcat : Cat, ISound
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
        public Tomcat(int age, string name, string sex) : base(age, name, sex) 
        { 
            if (!(sex == "male" || sex == "Male" || sex == "M" || sex == "m"))
            {
                throw new ArgumentException("Tomcats can only be male!");
            }
        }

        public string MakeSound()
        {
            return "Miau, miau, miau...";
        }
    }
}
