using System;

namespace DefiningClasses
{
    public class StartUp

    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());
            
            Family family = new Family();
            for (int i = 0; i < count; i++)
            {
                string[] personInfo = Console.ReadLine().Split();
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                Person person = new Person(name, age);
                family.AddMember(person);

            }
            Person oldestPerson = family.GetOldestMember();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}"); 
        }
    }
}
