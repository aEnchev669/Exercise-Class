using System;

namespace DefiningClasses
{
    public class StartUp

    {
        static void Main(string[] args)
        {

            Person person = new Person();

            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            person.Age = age;
            person.Name = name;

            Console.WriteLine($"{person.Name} {person.Age}");

        }
    }
}
