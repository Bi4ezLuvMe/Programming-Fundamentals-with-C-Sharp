namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Number(input, a, b));

        }
        static int Number(string input, int a, int b)
        {
            if (input.Equals("add"))
            {
                return a + b;
            }
            else if (input.Equals("multiply"))
            {
                return a * b;
            }
            else if (input.Equals("subtract"))
            {
                return a - b;
            }
            return a / b;
        }
    }
}