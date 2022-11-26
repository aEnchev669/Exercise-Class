
using System;

namespace _4.PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaInfo = Console.ReadLine().Split();
                string[] doughInfo = Console.ReadLine().Split();

                Dough dough = new Dough(doughInfo[1], doughInfo[2], double.Parse(doughInfo[3]));
                Pizza pizza = new Pizza(pizzaInfo[1], dough);
                string cmd;
                while ((cmd = Console.ReadLine()) != "END")
                {


                    string[] tokens = cmd.Split();
                    string toppType = tokens[1];
                    double toppWeight = double.Parse(tokens[2]);

                    Topping topping = new Topping(toppType, toppWeight);
                    pizza.AddToppings(topping);

                }
                Console.WriteLine(pizza);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
