using System;
using System.Text;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder();
            string command = Console.ReadLine();


            while (command != "Beast!")
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                bool isValid = true;
                if (int.Parse(tokens[1]) <= 0)
                {
                    isValid = false;
                }
                if (isValid)
                {
                    if (command == "Cat")
                    {
                        Cat cat = new Cat(tokens[0], int.Parse(tokens[1]), tokens[2]);
                        result.AppendLine(cat.ToString());
                    }
                    else if (command == "Dog")
                    {
                        Dog dog = new Dog(tokens[0], int.Parse(tokens[1]), tokens[2]);
                        result.AppendLine(dog.ToString());
                    }
                    else if (command == "Frog")
                    {
                        Frog frog = new Frog(tokens[0], int.Parse(tokens[1]), tokens[2]);
                        result.AppendLine(frog.ToString());
                    }
                    else if (command == "Tomcat")
                    {
                        Tomcat tomcat = new Tomcat(tokens[0], int.Parse(tokens[1]));
                        result.AppendLine(tomcat.ToString());
                    }
                    else if (command == "Kitten")
                    {
                        Kitten kitten = new Kitten(tokens[0], int.Parse(tokens[1]));
                        result.AppendLine(kitten.ToString());
                    }
                    else
                    {
                        throw new ArgumentException("Invalid input!");
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(result.ToString());
        }
    }
}