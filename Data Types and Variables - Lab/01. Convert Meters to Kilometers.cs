namespace Data_Types_and_Variables___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            Console.WriteLine($"{km / 1000.00:f2}");
        }
    }
}