using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const double DEFAULT_COFFEE_MILLILITERS = 50;
        private const decimal DEFAULT_PRICE = 3.50m;
        public double Caffeine { get; set; }
        public Coffee(string name, double caffeine) : base(name, DEFAULT_PRICE, DEFAULT_COFFEE_MILLILITERS )
        {
            Caffeine = caffeine;
        }
    }
}
