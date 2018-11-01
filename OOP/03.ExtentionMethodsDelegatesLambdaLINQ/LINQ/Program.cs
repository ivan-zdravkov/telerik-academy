// 3. Write a method that from a given array of students finds all students whose first name is before its last name alphabetically. Use LINQ query operators.

// 4. Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

// 5. Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. Rewrite the same with LINQ.

using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            Student[] students = 
            {
                new Student("Ivan", "Ivanov", 16),
                new Student("Ivan", "Angelov", 17),
                new Student("Asparuh", "Dimitrov", 18),
                new Student("Krum", "Savov", 19),
                new Student("Spas", "Gospodinov", 20),
                new Student("Georgi", "Zarchev", 28),
                new Student("Julian", "Penev", 24),
                new Student("Velizar", "Topuzakov", 30),
                new Student("Kristiyan", "Manolev", 22),
                new Student("Jivodar", "Stoyanov", 20)
            };

            FindFirstNameBeforeLastName(students);

            FindStudentsRange(students, 18, 24);

            SortStudentsLambda(students);

            SortStudentsLINQ(students);


        }

        private static void FindFirstNameBeforeLastName(Student[] students)
        {
            var firstBeforeLastStudents =
                from student in students
                where (student.FirstName.CompareTo(student.LastName) == -1)
                orderby student.FirstName
                select student;

            Console.WriteLine("Printing all of the students, whose first name comes before their second name: ");
            Console.WriteLine(new String('-', 80));
            foreach (Student student in firstBeforeLastStudents)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("\n");
        }

        private static void FindStudentsRange(Student[] students, int lowerRange, int upperRange)
        {
            var rangeOfStudents =
                from student in students
                where (student.Age >= lowerRange && student.Age <= upperRange)
                orderby student.Age
                select student;

            Console.WriteLine("Printing all the students whose age is [{0}, {1}]: ", lowerRange, upperRange);
            Console.WriteLine(new String('-', 80));
            foreach (Student student in rangeOfStudents)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("\n");
        }

        private static void SortStudentsLambda(Student[] students)
        {
            var sortedStudents = students.OrderBy(student => student.FirstName).ThenBy(student => student.LastName);

            Console.WriteLine("Sorting the students by their FirstName/SecondName using Lambda function");
            Console.WriteLine(new String('-', 80));
            foreach (Student student in sortedStudents)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("\n");
        }

        private static void SortStudentsLINQ(Student[] students)
        {
            var sortedStudents =
                from student in students
                orderby student.FirstName, student.LastName
                select student;

            Console.WriteLine("Sorting the students by their FirstName/SecondName using LINQ");
            Console.WriteLine(new String('-', 80));
            foreach (Student student in sortedStudents)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("\n");
        }
    }
}
