using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {

        public Person(string name, decimal money)
        {
            BagOfProducts = new List<Product>();
            Name = name;
            Money = money;
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

        public decimal Money
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

        public List<Product> BagOfProducts { get; set; }

        public void AddPerson(Product product)
        {
            if (Money >= product.Cost)
            {
                BagOfProducts.Add(product);
                Money -= product.Cost;

                Console.WriteLine($"{Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{name} can't afford {product.Name}");
            }
        }
        public override string ToString()
        {
            if (BagOfProducts.Count == 0)
            {
                return $"{Name} - Nothing bought";
            }
            return $"{Name} - {string.Join(", ", BagOfProducts)}";

        }
    }
}
