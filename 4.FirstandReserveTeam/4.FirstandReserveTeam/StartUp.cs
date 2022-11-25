﻿using System;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Person> list = new List<Person>();
            Team team = new Team("SoftUni");
            for (int i = 0; i < count; i++)
            {
                try
                {
                    string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string name = tokens[0];
                    string name2 = tokens[1];
                    int age = int.Parse(tokens[2]);
                    decimal salary = decimal.Parse(tokens[3]);

                    Person person = new Person(name, name2, age, salary);
                    list.Add(person);
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }

            foreach (var person in list)
            {
                team.AddPlayer(person);
            }

            Console.WriteLine(team.ToString());
        }
    }
}
