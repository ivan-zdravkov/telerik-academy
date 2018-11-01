using System;

namespace Animals
{
    class Program
    {
        static void Main()
        {
            Dog[] dogs = 
            {
                new Dog(8, "Sharo", "M"),
                new Dog(4, "Lassy", "F"),
                new Dog(5, "Jorko", "M"),
                new Dog(10, "Bubi", "F"),
                new Dog(1, "Drupy", "M"),
                new Dog(16, "Granny", "M")
            };

            Cat[] cats =
            {
                new Kitten(4, "Puphy", "F"),
                new Kitten(2, "Dolly", "F"),
                new Kitten(10, "Sara", "F"),
                new Kitten(4, "Kleopatra", "F"),
                new Tomcat(10, "Ahil", "M"),
                new Tomcat(5, "Itko", "M"),
                new Tomcat(6, "Boris", "M"),
                new Tomcat(2, "Malcho", "M"),
                new Kitten(1, "Baby", "F"),
                new Kitten(1, "Buba", "F")
            };

            Frog[] frogs =
            {
                new Frog(1, "Nevil", "M"),
                new Frog(2, "Neviana", "F")
            };

            Console.WriteLine("Average age of Dogs is: {0:0.00}", AverageAge(dogs));
            Console.WriteLine("Average age of Cats is: {0:0.00}", AverageAge(cats));
            Console.WriteLine("Average age of Frogs is: {0:0.00}\n", AverageAge(frogs));

            Animal[] animals= new Animal[dogs.Length + cats.Length + frogs.Length];
            int index = 0;
            foreach (Dog dog in dogs)
            {
                animals[index] = dog;
                index++;
            }
            foreach (Cat cat in cats)
            {
                animals[index] = cat;
                index++;
            }
            foreach (Frog frog in frogs)
            {
                animals[index] = frog;
                index++;
            }

            Console.WriteLine("Average age of all the Animals is: {0:0.00}\n", AverageAge(animals));

        }

        static double AverageAge(Animal[] animals)
        {
            double totalAge = 0;
            foreach (Animal animal in animals)
            {

                totalAge += animal.GetAge;
            }
            return totalAge / animals.Length;
        }
    }
}
