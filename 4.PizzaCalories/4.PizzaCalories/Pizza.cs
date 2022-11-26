
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.PizzaCalories
{
    public class Pizza
    {
        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;

            Toppings = new List<Topping>();
        }
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception($"Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }

        private Dough dough;

        public Dough Dough
        {
            get { return dough; }
            set { dough = value; }
        }

        private List<Topping> toppings;

        public List<Topping> Toppings
        {
            get { return toppings; }
            set { toppings = value; }
        }


        public void AddToppings(Topping topping)
        {
            if (Toppings.Count > 10)
            {
                throw new Exception($"Number of toppings should be in range [0..10].");
            }
            Toppings.Add(topping);
        }

        public double TotalCalories => Dough.DoughCalories() + Toppings.Select(t => t.ToppingCalories).Sum();

        public override string ToString()
        {
            return $"{this.Name} - {TotalCalories:f2} Calories.";
        }
    }
}
