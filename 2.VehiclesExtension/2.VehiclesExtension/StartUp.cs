using _2.VehiclesExtension;
using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();
            string[] busInfo = Console.ReadLine().Split();
            Car car = new Car();
            Truck truck = new Truck();
            Bus bus = new Bus();
            if (double.Parse(carInfo[1]) > double.Parse(carInfo[3]))
            {
                car = new Car(0, double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            }
            else
            {
                car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            }
            if (double.Parse(truckInfo[1]) > double.Parse(truckInfo[3]))
            {
                 truck = new Truck(0, double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
            }
            else
            {
                 truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
            }
            if (double.Parse(busInfo[1]) > double.Parse(busInfo[3]))
            {
                 bus = new Bus(0, double.Parse(busInfo[2]), double.Parse(busInfo[3]));
            }
            else
            {
                 bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));
            }
           

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
                    else if (cmd[1] == "Bus")
                    {
                        bus.DriveFull(distance);
                    }


                }
                else if (cmd[0] == "Refuel")
                {
                    double fuel = double.Parse(cmd[2]);
                    if (fuel <= 0)
                    {
                        Console.WriteLine("Fuel must be a positive number");
                    }
                    else
                    {
                        if (cmd[1] == "Car")
                        {
                            car.Refuel(fuel);
                        }
                        else if (cmd[1] == "Truck")
                        {
                            truck.Refuel(fuel);
                        }
                        else if (cmd[1] == "Bus")
                        {
                            bus.Refuel(fuel);
                        }
                    }
                }
                else if (cmd[0] == "DriveEmpty")
                {
                    double distance = double.Parse(cmd[2]);
                    bus.Drive(distance);
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
    }
}
