namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Asdf(input, n));
        }
        static string Asdf(string input, int n)
        {
            string output = String.Empty;
            for (int i = 0; i < n; i++)
            {
                output += input;
            }
            return output;
        }
    }
}