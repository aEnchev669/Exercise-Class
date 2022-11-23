using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp

    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());
            List<Person> listOfPersons = new List<Person>();

            for (int i = 0; i < count; i++)
            {
                string[] personInfo = Console.ReadLine().Split();
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                Person person = new Person(name, age);

                listOfPersons.Add(person);
            }

            listOfPersons = listOfPersons.OrderBy(p => p.Name).ToList();

            foreach (Person person in listOfPersons)
            {
                if (person.Age > 30)
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }
            }
        }
    }
}
