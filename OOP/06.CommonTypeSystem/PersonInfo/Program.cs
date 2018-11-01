using System;
using System.Collections.Generic;

namespace PersonInfo
{
    class Program
    {
        enum Name { Ivan, Peter, Stoyan, Metodi, Yavor, Grigor, Dimitar, Joro, Kalin, Viktor }
        static Random random = new Random();

        static void Main()
        {
            List<Person> people = new List<Person>();
            int numberOfPeople = 10;

            for (int i = 0; i < numberOfPeople; i++)
            {
                int? age = random.Next(18, 79);
                people.Add(new Person(GenerateName(), ((age % 2 == 0) ? age : null)));
            }

            foreach (Person person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }

        static string GenerateName()
        {
            Array values = Enum.GetValues(typeof(Name));
            Name name = (Name)values.GetValue(random.Next(values.Length));
            return name.ToString();
        }
    }
}
