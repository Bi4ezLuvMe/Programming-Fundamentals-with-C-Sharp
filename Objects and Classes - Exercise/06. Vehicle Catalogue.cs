using System.Numerics;

namespace ConsoleApp16
{
    class Vehicle
    {
        public string type;
        public string model;
        public string color;
        public int horsepower;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Vehicle> list = new List<Vehicle>();
            int carCount = 0;
            int truckCount = 0;
            double carHorsePowerSum = 0;
            double truckHorsePowerSum = 0;
            while(command != "End")
            {
                string[] commandAsAnArray = command.Split();
                Vehicle vehicle= new Vehicle();
                vehicle.type = commandAsAnArray[0];
                vehicle.model = commandAsAnArray[1];
                vehicle.color = commandAsAnArray[2];
                vehicle.horsepower = int.Parse(commandAsAnArray[3]);
                if (vehicle.type == "car")
                {
                    carHorsePowerSum += vehicle.horsepower;
                    carCount++;
                }
                else
                {
                    truckHorsePowerSum += vehicle.horsepower;
                    truckCount++;
                }
                list.Add(vehicle);
                command = Console.ReadLine();
            }
            string wantedVehicle=Console.ReadLine();
            while(wantedVehicle != "Close the Catalogue")
            {
                foreach (Vehicle vechicle in list)
                {
                    if (vechicle.model == wantedVehicle)
                    {
                        if (vechicle.type == "car")
                        {
                            Console.WriteLine($"Type: Car");
                        }
                        else
                        {
                            Console.WriteLine($"Type: Truck");
                        }
                        Console.WriteLine($"Model: {vechicle.model}");
                        Console.WriteLine($"Color: {vechicle.color}");
                        Console.WriteLine($"Horsepower: {vechicle.horsepower}");
                    }
                }
                wantedVehicle= Console.ReadLine();
            }
            double carAverage = carHorsePowerSum / carCount;
            double truckAverge = truckHorsePowerSum / truckCount;
            if (carCount > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {carAverage:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            if (truckCount > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {truckAverge:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }         
    }
}