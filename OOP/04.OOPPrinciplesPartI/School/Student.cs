using System;

namespace School
{
    class Student : Person, ICommentable 
    {
        private static bool[] staticClassNumbers = new bool[30];
        private string comment;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int numberInClass;
        public int NumberInClass
        {
            get { return numberInClass; }
            set { numberInClass = value; }
        }

        public Student(string name, int numberInClass) : base(name)
        {
            if (staticClassNumbers[numberInClass] == false)
            {
                this.numberInClass = numberInClass;
                staticClassNumbers[numberInClass] = true;
            }
            else
            {
                throw new ArgumentException("A student must have a unique class number!");
            }
        }

        public void AddComment(string comment)
        {
            this.comment = comment;
        }

        public string GetComment()
        {
            return this.comment;
        }
    }
}
