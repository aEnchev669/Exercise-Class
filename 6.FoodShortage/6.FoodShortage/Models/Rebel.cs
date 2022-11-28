using _6.FoodShortage.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _6.FoodShortage.Models
{
    public class Rebel : IRebel
    {
        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Group { get; private set; }
    }
}
