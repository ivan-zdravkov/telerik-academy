using System;
using System.Collections.Generic;

namespace StudentSystem
{
    class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        public string FirstName 
        { 
            get { return this.firstName; } 
        }
        private string middleName;
        public string MiddleName 
        {
            get { return this.middleName;  }
        }
        private string lastName;
        public string LastName 
        {
            get { return this.lastName; }
        }
        public string SSN { get; set; }
        private string permanentAddress;
        public string PermanentAddress 
        {
            get { return this.permanentAddress; }
        }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }
        public Specialty Specialty { get; set; }

        public Student(
            string firstName, string middleName, string lastName,
            string SSN, string permanentAddress, string mobilePhone,
            University university, Faculty faculty, Specialty specialty)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.SSN = SSN;
            this.permanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = this.FirstName[0].ToString() + this.MiddleName[0].ToString() + this.LastName[0].ToString() + "@gmail.com";
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
        }

        public override bool Equals(object param)
        {
            Student student = param as Student;
            if (student == null)
            {
                return false;
            }
            if (!(
                    this.FirstName == student.FirstName &&
                    this.MiddleName == student.MiddleName &&
                    this.LastName == student.LastName &&
                    this.SSN == student.SSN &&
                    this.PermanentAddress == student.PermanentAddress
                ))
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} | {3}{4}******** | {5} | {6} | {7}\n{8} | {9} Faculty | {10}",
                this.FirstName, this.MiddleName, this.LastName,
                this.SSN[0], this.SSN[1],
                this.PermanentAddress, this.MobilePhone, this.Email,
                this.University, this.Faculty, this.Specialty);
        }

        public override int GetHashCode()
        {
            return this.SSN.GetHashCode() ^ this.Specialty.GetHashCode();
        }

        public static bool operator ==(Student first, Student second)
        {
            return Student.Equals(first, second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !(Student.Equals(first, second));
        }

        public Student Clone()
        {
            return new Student
                (this.FirstName, this.MiddleName, this.LastName, 
                this.SSN, this.PermanentAddress, this.MobilePhone, 
                this.University, this.Faculty, this.Specialty);
        }
        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Student other)
        {
            string thisName = this.FirstName + " " + this.MiddleName + " " + this.LastName;
            string otherName = other.FirstName + " " + other.MiddleName + " " + other.LastName;

            if (thisName.CompareTo(otherName) > 0)
            {
                return 1;
            }
            else if (thisName.CompareTo(otherName) < 0)
            {
                return -1;
            }
            else
            {
                if (this.SSN.CompareTo(other.SSN) > 0)
                {
                    return 1;
                }
                else if (this.SSN.CompareTo(other.SSN) < 0)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
