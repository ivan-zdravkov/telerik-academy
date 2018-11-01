using System;

namespace School
{
    class Discipline : ICommentable
    {
        private string comment;
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int numberOfLectures;
        public int NumberOfLectures
        {
            get { return numberOfLectures; }
            set { numberOfLectures = value; }
        }

        private int numberOfExercices;
        public int NumberOfExercices
        {
            get { return numberOfExercices; }
            set { numberOfExercices = value; }
        }

        public Discipline(string name, int numberOfLectures, int numberOfExercices)
        {
            this.name = name;

            if (numberOfLectures >= 0)
            {
                this.numberOfLectures = numberOfLectures;
            }
            else
            {
                throw new ArgumentException("The number of lectures cannot be a negative number!");
            }

            if (numberOfExercices >= 0)
            {
                this.numberOfExercices = numberOfExercices;
            }
            else
            {
                throw new ArgumentException("The number of lectures cannot be a negative number!");
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
