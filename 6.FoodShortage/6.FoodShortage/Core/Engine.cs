using _4._Border_Control.Core.Interfaces;
using _4._Border_Control.IO.Interfaces;
using _4._Border_Control.Models;
using _6.FoodShortage.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _4._Border_Control.Core
{
    public class Engine : IEngine
    {
        public readonly IReader reader;
        public readonly IWriter writer;


        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            List<string> rebels = new List<string>();
            List<string> citizens = new List<string>();

            List<string> birthDates = new List<string>();
            int totalFood = 0;

            int count = int.Parse(reader.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] tokens = reader.ReadLine().Split();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string idOrGroup = tokens[2];

                if (tokens.Length == 3)
                {
                    Rebel rebel = new Rebel(name, age, idOrGroup);
                    rebels.Add(name);
                }
                else if (tokens.Length == 4)
                {
                    string birthdate = tokens[3];
                    Citizen citizen = new Citizen(name, age, idOrGroup, birthdate);
                    citizens.Add(name);
                }
            }
            string cmd;
            while ((cmd = reader.ReadLine()) != "End")
            {
                if (rebels.Contains(cmd))
                {
                    totalFood += 5;
                }
                else if (citizens.Contains(cmd))
                {
                    totalFood += 10;
                }
            }



            writer.WriteLine(totalFood.ToString());
        }
    }
}
