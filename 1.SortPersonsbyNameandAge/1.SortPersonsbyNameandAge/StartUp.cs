using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
           int countOfPeople = int.Parse(Console.ReadLine());
            List<Person> list = new List<Person>();
            for (int i = 0; i < countOfPeople; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);

                Person person = new Person(firstName, lastName, age);
                list.Add(person);
            }

            list.OrderBy(p => p.FirstName)
                .ThenBy(p => p.Age)
                .ToList()
                .ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
