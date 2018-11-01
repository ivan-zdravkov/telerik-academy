using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentWorder
{
    class Program
    {
        public static string[] fNames = { "Ivan", "Peter", "Georgi", "Stoyan", "Dimitar", "Vasil", "Kaloyan", "Mihail", "Alexander", "Dimo"};
        public static string[] lNames = { "Ivanov", "Petrov", "Georgiev", "Stoyanov", "Dimitrov", "Vasilev", "Kaloyanchev", "Mihailov", "Aleksandrov", "Dimov" };
        static void Main()
        {
            Random generator = new Random();

            List<Student> studentList = new List<Student>();
            List<Worker> workerList = new List<Worker>();
            int numberOfStudents = 10;
            int numberOfWorkers = 10;

            for (int i = 0; i < numberOfStudents; i++)
            {
                studentList.Add(new Student(fNames[generator.Next(0, 10)], lNames[generator.Next(0,10)], generator.Next(2, 7)));
            }

            for (int i = 0; i < numberOfWorkers; i++)
            {
                workerList.Add(new Worker(fNames[generator.Next(0, 10)], lNames[generator.Next(0, 10)], generator.Next(100, 201), generator.Next(6, 11)));
            }

            List<Human> mergedList = new List<Human>();

            Console.WriteLine("Printing out the students and their grades: ");
            Console.WriteLine(line());
            var orederedStudents = studentList.OrderBy(student => student.Grade);
            foreach (Student student in orederedStudents)
            {
                Console.WriteLine(student.ToString());
                mergedList.Add(student);
            }
            Console.WriteLine();

            Console.WriteLine("Printing out the workers and their salary: ");
            Console.WriteLine(line());
            var orderedWorkers = workerList.OrderBy(worker => -worker.MoneyPerHour());
            foreach (Worker worker in orderedWorkers)
            {
                Console.WriteLine(worker.ToString());
                mergedList.Add(worker);
            }
            Console.WriteLine();

            Console.WriteLine("Printing out all the people's names in lexicographical order: ");
            Console.WriteLine(line());
            var everyone = mergedList.OrderBy(human => human.FName).ThenBy(human => human.LName);
            foreach (var human in everyone)
            {
                Console.WriteLine("{0} {1}", human.FName, human.LName);
            }
            Console.WriteLine();
        }

        static string line ()
        {
            return new String('-', 60);
        }
    }
}
