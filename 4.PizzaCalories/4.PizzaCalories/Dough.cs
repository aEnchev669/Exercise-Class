using System;
using System.Collections.Generic;
using System.Text;

namespace _4.PizzaCalories
{
    public class Dough
    {

        Dictionary<string, double> doughInfo = new Dictionary<string, double>()
        {
            { "white", 1.5 },
            { "wholegrain", 1.0 },

        };
        Dictionary<string, double> backingTechn = new Dictionary<string, double>()
        {
            { "crispy", 0.9 },
            { "chewy", 1.1 },
            { "homemade", 1.0 },
        };

        private string flourType;

        public string FlourType
        {
            get { return flourType; }
            private set
            {
                if (!doughInfo.ContainsKey(value.ToLower()))
                {
                    throw new Exception("Invalid type of dough.");
                }
                flourType = value;
            }
        }

        private string backingTechnique;

        public string BackingTechnique
        {
            get { return backingTechnique; }
            private set
            {
                if (!backingTechn.ContainsKey(value.ToLower()))
                {
                    throw new Exception("Invalid type of dough.");
                }
                backingTechnique = value;
            }
        }

        private double doughWeight;

        public Dough(string flourType, string backingTechnique, double doughWeigh)
        {
            FlourType = flourType;
            BackingTechnique = backingTechnique;
            DoughWeight = doughWeigh;
        }

        public double DoughWeight
        {
            get { return doughWeight; }
            private set
            {
                if (!(value >= 1 && value <= 200))
                {
                    throw new Exception("Dough weight should be in the range [1..200].");
                }
                doughWeight = value;
            }
        }
        public double DoughCalories() => 2 * doughWeight * doughInfo[FlourType.ToLower()] * backingTechn[BackingTechnique.ToLower()];


    }
}
