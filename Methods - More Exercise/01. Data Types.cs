namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string type =Console.ReadLine();
            Print(type);
        }
        static void Print(string type)
        {
            if (type == "int")
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(num * 2);
            }
            else if (type == "real")
            {
                double num = double.Parse(Console.ReadLine());
                Console.WriteLine($"{num * 1.5:f2}");
            }
            else if (type == "string")
            {
                string input = Console.ReadLine();
                Console.WriteLine($"${input}$");
            }
        }
    }
}