using System;
using System.Collections.Generic;

namespace _8.CarSalesman
{
    public class Program
    {
        static void Main(string[] args)
        {
            int nLinesForEngine = int.Parse(Console.ReadLine());

            List<Engine> engineList = new List<Engine>();
            List<Car> carList = new List<Car>();

            for (int i = 0; i < nLinesForEngine; i++)
            {
                string[] infoForEngine = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                string model = infoForEngine[0];
                int power = int.Parse(infoForEngine[1]);

                Engine engine = new Engine(model, power);
                if (infoForEngine.Length > 2)
                {
                    int displacement;
                    bool isDigit = int.TryParse(infoForEngine[2], out displacement);
                    if (!isDigit)
                    {
                        string efficiency = infoForEngine[2];
                        engine = new Engine(model, power, efficiency);
                    }
                    else
                    {
                        engine = new Engine(model, power, displacement);
                    }
                    if (infoForEngine.Length == 4)
                    {
                        string efficiency = infoForEngine[3];
                        engine = new Engine(model, power, displacement, efficiency);
                    }
                }
                engineList.Add(engine);
            }

            int nLineForCar = int.Parse(Console.ReadLine());

            for (int i = 0; i < nLineForCar; i++)
            {
                string[] infoForCar = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string model = infoForCar[0];
                string engineModel = infoForCar[1];
                Engine engine = engineList.Find(e => e.Model == engineModel);
                Car car = new Car(model, engine);

                if (infoForCar.Length > 2)
                {
                    int weight;
                    bool isDIgit = int.TryParse(infoForCar[2], out weight);
                    if (!isDIgit)
                    {
                        string color = infoForCar[2];
                        car = new Car(model, engine, color);
                    }
                    else
                    {
                        car = new Car(model, engine, weight);
                    }
                    if (infoForCar.Length == 4)
                    {
                        string color = infoForCar[3];
                        car = new Car(model ,engine, weight, color);
                    }
                }
                carList.Add(car);
            }

            foreach (var car in carList)
            {
                Console.WriteLine(car);
            }
        }
    }
}
