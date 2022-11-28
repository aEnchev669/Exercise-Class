using _4._Border_Control.Core.Interfaces;
using _4._Border_Control.IO.Interfaces;
using _4._Border_Control.Models;
using _5._Birthday_Celebrations.Models;
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
            List<string> birthDates = new List<string>();
            string cmd;
            while ((cmd = reader.ReadLine()) != "End")
            {

                string[] tokens = cmd.Split(' ');
                string type = tokens[0];
                string nameOrModel = tokens[1];
                string idOrBithdate = tokens[2];
                if (type == "Robot")
                {
                    Robots robots = new Robots(nameOrModel, idOrBithdate);
                }
                else if (type == "Citizen")
                {
                    int age = int.Parse(idOrBithdate);
                    string citizenId = tokens[3];
                    string bithdate = tokens[4];

                    Citizen citizen = new Citizen(nameOrModel, age, citizenId, bithdate);
                    birthDates.Add(bithdate);
                }
                else if (type == "Pet")
                {
                    Pet pet = new Pet(nameOrModel, idOrBithdate);
                    birthDates.Add(idOrBithdate);
                }
            }

            string year = reader.ReadLine();

            foreach (var item in birthDates)
            {
                if (item.EndsWith(year))
                {
                    writer.WriteLine(item);
                }
            }
        }
    }
}
