using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentSystem
{
    class Program
    {
        enum City { Sofia, Plovdiv, Burgas, Varna, Sliven, Ruse, Pleven, Lovech }
        enum FName { Ivan, Georgi, Todor, Petar, Stoyan, Vlado, Dimo, Tasho }
        enum Name { Ivanov, Georgiev, Todorov, Petrov, Stoyanov, Vladimirov, Dimov, Tashov, Velizarov, Slavov, Turomanov, Toprakchiev, Velev, Draganov }
        static Random random = new Random();
        static void Main()
        {
            Student[] students = new Student[3];
            students[0] = new Student("Ivan", "Ivanov", "Ivanov", "316136616", "3SFHSFH", "426426246246", University.SophiaUniversity, Faculty.Computers, Specialty.SoftwareEngineering);
            students[1] = new Student("Ivan", "Ivanov", "Ivanov", "316136616", "3SFHSFH", "426426246246", University.AgriculturalUniversity, Faculty.Agricultural, Specialty.Agriculture);
            students[2] = new Student("Georgi", "Petrov", "Ivanov", "316113566", "34H315H", "26422621446", University.SophiaUniversity, Faculty.Computers, Specialty.SoftwareEngineering);
            foreach (Student student in students)
            {
                Console.WriteLine(student.ToString());
                Console.WriteLine(new String('-', 60));
            }

            Console.WriteLine("\nFirst is Equal to Second: {0}", students[0].Equals(students[1])); // Different students, but same person, Equals returns true!
            Console.WriteLine("First is Equal to Third: {0}", students[0].Equals(students[2])); // Totally different students, Equal returns false!
            Console.WriteLine("Second is Equal to Third: {0}", students[1].Equals(students[2]));
            Console.WriteLine("First == Second: {0}", students[0] == students[1]);
            Console.WriteLine("First == Third: {0}", students[0] == students[2]);
            Console.WriteLine("Second != Third: {0}", students[1] != students[2]);

            Console.WriteLine("\nGenerating the respective hash codes for the students: ");
            foreach (Student student in students)
            {
                Console.WriteLine(student.GetHashCode());
            }

            Student lastStudent = students[2]; // Shallow clone;
            Console.WriteLine("\nCloning the last student...");
            Student clone = students[2].Clone(); // Deep Clone;

            Console.WriteLine("Changing the Phone and Email of the cloned student...");
            clone.MobilePhone = "08888331122";
            clone.Email = "CloneMail@gmail.com";

            Console.WriteLine("\nThe original student's phone is {0} and his email is {1}", lastStudent.MobilePhone, lastStudent.Email);
            Console.WriteLine("The cloned student's phone is {0} and his email is {1}\n", clone.MobilePhone, clone.Email);
            Console.WriteLine(lastStudent.ToString() + "\n");
            Console.WriteLine(clone.ToString());
            Console.WriteLine("\n\n");

            List<Student> studentList = new List<Student>();
            int numberOfStudents = 10;

            Console.WriteLine("Generating {0} random students: ", numberOfStudents);
            Console.WriteLine(new String('=', 60));
            Console.WriteLine();

            for (int i = 0; i < numberOfStudents; i++)
            {
                studentList.Add(
                    new Student(
                        GenerateFName(), GenerateName(), GenerateName(), 
                        GenerateSSN(), GenerateCity(), GeneratePhoneNumber(),
                        (University)random.Next(0, Enum.GetValues(typeof(University)).Length), // Typecasting a random number [0, EnumSize] to Enum Type!
                        (Faculty)random.Next(0, Enum.GetValues(typeof(Faculty)).Length), // Typecasting a random number [0, EnumSize] to Enum Type!
                        (Specialty)random.Next(0, Enum.GetValues(typeof(Specialty)).Length) // Typecasting a random number [0, EnumSize] to Enum Type!
                    )
                );
            }

            studentList.Add(studentList[0].Clone()); // We are adding a cloned student to the list 
            studentList[studentList.Count - 1].SSN = "9999999999"; // And we change his SSN so we can see if the SSN order works
            studentList.Add(studentList[0].Clone());
            studentList[studentList.Count - 1].SSN = "1000000000"; 

            foreach (Student student in studentList)
            {
                Console.WriteLine(student.ToString());
                Console.WriteLine(new String('-', 60));
            }

            Console.WriteLine("\n\nOrdering the students...\n");
            var orderedStudents = studentList.OrderBy(x => x);

            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.MiddleName + " " + student.LastName + " " + student.SSN);
                Console.WriteLine(new String('-', 60));
            }
        }

        static string GenerateSSN()
        {
            return (random.Next(10000, 99999).ToString() + random.Next(10000, 99999).ToString());
        }

        static string GeneratePhoneNumber()
        {
            return ("08" + random.Next(1000, 9999).ToString() + random.Next(1000, 9999).ToString());
        }

        static string GenerateCity()
        {
            Array values = Enum.GetValues(typeof(City));
            City city = (City)values.GetValue(random.Next(values.Length));
            return city.ToString();
        }

        static string GenerateFName()
        {
            Array values = Enum.GetValues(typeof(FName));
            FName name = (FName)values.GetValue(random.Next(values.Length));
            return name.ToString();
        }

        static string GenerateName()
        {
            Array values = Enum.GetValues(typeof(Name));
            Name name = (Name)values.GetValue(random.Next(values.Length));
            return name.ToString();
        }

    }
}
