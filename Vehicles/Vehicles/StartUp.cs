using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();

            Car car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            Truck truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] cmd = Console.ReadLine().Split();
                if (cmd[0] == "Drive")
                {
                    double distance = double.Parse(cmd[2]);
                    if (cmd[1] == "Car")
                    {
                        car.Drive(distance);
                    }
                    else if (cmd[1] == "Truck")
                    {
                        truck.Drive(distance);
                    }
                }
                else if (cmd[0] == "Refuel")
                {
                    double fuel = double.Parse(cmd[2]);
                    if (cmd[1] == "Car")
                    {
                        car.Refuel(fuel);
                    }
                    else if (cmd[1] == "Truck")
                    {
                        truck.Refuel(fuel);
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }
    }
}
