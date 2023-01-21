namespace Data_Types_and_Variables___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pound = double.Parse(Console.ReadLine());
            double usd = pound * 1.31;
            Console.WriteLine($"{usd:f3}");
        }
    }
}