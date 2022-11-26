using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        
        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }
        private string name;
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name cannot be empty");
                }
                name = value;
            }
        }

        private decimal money;

        public decimal Cost
        {
            get { return money; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }
                money = value;
            }
        }

        public override string ToString()
        {
            return name;
        }
    }
}
