namespace Basic_Syntax_Conditional_Statements_and_Loops_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int print = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{i} ");
                    if (j == i)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}