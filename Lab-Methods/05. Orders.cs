namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wantedItem = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Price(wantedItem, quantity):f2}");
        }
        static double Price(string wantedItem, int quantity)
        {
            switch (wantedItem)
            {
                case "coffee": return quantity * 1.50;
                case "water": return quantity * 1;
                case "coke": return quantity * 1.4;
                case "snacks": return quantity * 2;
            }
            return (0);
        }
    }
}