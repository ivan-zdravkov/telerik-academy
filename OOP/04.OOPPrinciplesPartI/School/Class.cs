using System;
using System.Collections.Generic;

namespace School
{
    class SchoolClass : ICommentable
    {
        private static List<string> staticClassIDs = new List<string>();
        private string comment;

        private string classID;
        public string ClassID
        {
            get { return classID; }
            set { classID = value; }
        }

        private List<Student> students;
        public List<Student> Students
        {
            get { return students; }
        }

        private List<Teacher> teachers;
        public List<Teacher> Teachers
        {
            get { return teachers; }
        }

        SchoolClass (string classID)
        {
            for (int i = 0; i < staticClassIDs.Count; i++)
            {
                if (classID == staticClassIDs[i])
                {
                    throw new ArgumentException("The class ID is not unique!");
                }
            }
            this.classID = classID;
            staticClassIDs.Add(classID);
        }

        SchoolClass (string classID, List<Student> students, List<Teacher> teachers) : this(classID)
        {
            this.students = students;
            this.teachers = teachers;
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
