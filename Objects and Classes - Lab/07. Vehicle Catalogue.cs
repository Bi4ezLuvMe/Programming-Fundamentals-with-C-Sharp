using System.Data;

namespace ConsoleApp16
{
    class Vechicle
    {
        public string brand;
        public string model;
        public int weight;
        public int horsePower;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Vechicle>cars = new List<Vechicle>();
            List<Vechicle>trucks=new List<Vechicle>();
             while (command != "end")
            {
                string[] commandAsAnArray = command.Split("/");
                Vechicle vechicle = new Vechicle();
                if (commandAsAnArray[0] == "Car")
                {
                    string Brand = commandAsAnArray[1];
                    string model = commandAsAnArray[2];
                    int horsePower = int.Parse(commandAsAnArray[3]);
                    vechicle.brand = Brand;
                    vechicle.model = model;
                    vechicle.horsePower = horsePower;
                    cars.Add(vechicle);
                }
                else if (commandAsAnArray[0] == "Truck")
                {
                    string Brand = commandAsAnArray[1];
                    string model = commandAsAnArray[2];
                    int weight = int.Parse(commandAsAnArray[3]);
                    vechicle.brand = Brand;
                    vechicle.model = model;
                    vechicle.weight = weight;
                    trucks.Add(vechicle);
                }
                command = Console.ReadLine();
            }
             if(cars.Count>0) Console.WriteLine("Cars:");
            List<Vechicle> sortedCars = cars.OrderBy(cars => cars.brand).ToList();
            List<Vechicle> sortedtrucks = trucks.OrderBy(trucks => trucks.brand).ToList();
            foreach (Vechicle vechicle in sortedCars) 
            {
                Console.WriteLine($"{vechicle.brand}: {vechicle.model} - {vechicle.horsePower}hp");
            }
           if(trucks.Count>0) Console.WriteLine("Trucks:");
            foreach (Vechicle vechicle in sortedtrucks)
            {
                Console.WriteLine($"{vechicle.brand}: {vechicle.model} - {vechicle.weight}kg");
            }
        }
    }
}