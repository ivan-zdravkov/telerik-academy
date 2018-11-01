using System;
using System.Collections.Generic;

namespace School
{
    class Teacher : Person, ICommentable 
    {
        private string comment;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private List<Discipline> disciplines;
        public List<Discipline> Disciplines
        {
            get { return disciplines; }
        }

        public Teacher(string name, List<Discipline> disciplines) : base(name)
        {
            this.disciplines = disciplines;
        }

        public Teacher(string name) : base(name)
        {
            disciplines = new List<Discipline>();
        }

        public void AddDiscipline(Discipline discipline)
        {
            disciplines.Add(discipline);
        }

        public void RemoveDiscipline(string disciplineName)
        {
            foreach (Discipline discipline in disciplines)
            {
                if (discipline.Name == disciplineName)
                {
                    disciplines.Remove(discipline);
                    return;
                }
                else
                {
                    continue;
                }
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
