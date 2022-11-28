using _4._Border_Control.Core.Interfaces;
using _4._Border_Control.IO.Interfaces;
using _4._Border_Control.Models;
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
            List<string> ids = new List<string>();
            string cmd;
            while ((cmd = reader.ReadLine()) != "End")
            {

                string[] tokens = cmd.Split(' ');
                string nameOrModel = tokens[0];
                string id = tokens[1];
                if (tokens.Length == 2)
                {
                    Robots robots = new Robots(nameOrModel, id);
                    ids.Add(id);
                }
                else if (tokens.Length == 3)
                {
                    int age = int.Parse(id);
                    string citizenId = tokens[2];
                    Citizen citizen = new Citizen(nameOrModel, age, citizenId);
                    ids.Add(citizenId);
                }
            }

            string endWith = reader.ReadLine();

            foreach (var item in ids)
            {
                if (item.EndsWith(endWith))
                {
                    writer.WriteLine(item);
                }
            }
        }
    }
}
