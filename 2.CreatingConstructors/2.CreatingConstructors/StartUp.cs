using System;

namespace DefiningClasses
{
    public class StartUp

    {
        static void Main(string[] args)
        {


            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());


            Person person = new Person();
            Person personWithAge = new Person(age);
            Person personWithAgeNName = new Person(name, age);

            Console.WriteLine($"{person.Name} {person.Age}");
            Console.WriteLine($"{personWithAge.Name} {personWithAge.Age}");
            Console.WriteLine($"{personWithAgeNName.Name} {personWithAgeNName.Age}");

        }
    }
}
