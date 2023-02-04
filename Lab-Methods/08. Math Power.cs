namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double Base = double.Parse(Console.ReadLine());
           int power =int.Parse(Console.ReadLine());
            Console.WriteLine(Pow(Base,power));
        }
        static double Pow(double Base, int Power)
        {
            return Math.Pow(Base, Power);
        }
    }
}