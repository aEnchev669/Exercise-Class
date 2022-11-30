using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Raiding
{
    public abstract class BaseHero : IBaseHero
    {
        public BaseHero()
        {

        }
        public BaseHero(string name, int power)
        {
            Name = name;
            Power = power;
        }
        public string Name { get; private set; }
        public int Power { get; private set; }

        public int TotalPower { get; set; }

        public virtual string CastAbility(string type, string name, int power)
        {
            string output = string.Empty;
            if (type == "Druid" || type == "Paladin")
            {
                output = $"{type} - {name} healed for {power}";
            }
            else if (type == "Rogue" || type == "Warrior")
            {
                output = $"{type} - {name} hit for {power} damage";
            }
            TotalPower += power;
            return output;
        }

        
    }
}
