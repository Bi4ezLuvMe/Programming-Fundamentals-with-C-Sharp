namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Print(n);
        }
        static void Print(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{n} ");
                    if (j == n - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}