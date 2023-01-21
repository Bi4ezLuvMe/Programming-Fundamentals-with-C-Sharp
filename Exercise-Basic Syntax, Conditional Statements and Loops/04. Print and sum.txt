namespace Basic_Syntax__Conditional_Statements_and_Loops_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int start=int.Parse(Console.ReadLine());
            int end=int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}