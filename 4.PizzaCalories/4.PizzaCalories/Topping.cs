using System;
using System.Collections.Generic;
using System.Text;

namespace _4.PizzaCalories
{
    public class Topping
    {
        public Topping(string toppingType, double toppingWeight)
        {
            this.ToppingType = toppingType;
            this.ToppingWeight = toppingWeight;
        }
        Dictionary<string, double> toppingTypes = new Dictionary<string, double>()
        {
            {"meat", 1.2 },
            {"veggies", 0.8 },
            {"cheese", 1.1 },
            {"sauce", 0.9 },
        };

        private string toppingType;

        public string ToppingType
        {
            get { return toppingType; }
            private set 
            {
                if (!toppingTypes.ContainsKey(value.ToLower()))
                {
                    throw new Exception($"Cannot place {value} on top of your pizza.");
                }
                toppingType = value; 
            }
        }

        private double toppingWeight;

        public double ToppingWeight
        {
            get { return toppingWeight; }
           private set 
            {
                if (value < 1 || value > 50)
                {
                    throw new Exception($"{ToppingType} weight should be in the range [1..50].");
                }
                toppingWeight = value;
            }
        }


        public double ToppingCalories => ToppingWeight * 2 * toppingTypes[ToppingType.ToLower()];

    }
}
