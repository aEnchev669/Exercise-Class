using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {


                List<Person> persons = new List<Person>();
                List<Product> products = new List<Product>();
                string[] input = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < input.Length; i++)
                {
                    string[] nameAndMoney = input[i].Split('=', StringSplitOptions.RemoveEmptyEntries);
                    string name = nameAndMoney[0];
                    int money = int.Parse(nameAndMoney[1]);

                    Person person = new Person(name, money);
                    persons.Add(person);
                }

                input = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < input.Length; i++)
                {
                    string[] productAndCost = input[i].Split('=', StringSplitOptions.RemoveEmptyEntries);
                    string name = productAndCost[0];
                    int money = int.Parse(productAndCost[1]);

                    Product product = new Product(name, money);
                    products.Add(product);
                }

                string cmd = Console.ReadLine();
                while (cmd != "END")
                {
                    string[] tokens = cmd.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string personName = tokens[0];
                    string productName = tokens[1];

                    

                    var people = persons.Find(p => p.Name == personName);
                    people.AddPerson(products.Find(p => p.Name == productName));
                    cmd = Console.ReadLine();
                }
            Console.WriteLine(string.Join(Environment.NewLine, persons));
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }
    }
}
