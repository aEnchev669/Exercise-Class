using _5._Birthday_Celebrations.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5._Birthday_Celebrations.Models
{
    public class Pet : IPet
    {
        public Pet(string name, string bithDate)
        {
            Name = name;
            BithDate = bithDate;
        }

        public string Name { get; private set; }
        public string BithDate { get; private set; }
    }
}
