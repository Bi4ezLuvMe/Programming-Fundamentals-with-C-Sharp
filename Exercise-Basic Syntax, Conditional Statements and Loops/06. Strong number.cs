namespace Basic_Syntax_Conditional_Statements_and_Loops_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int goalSum = num;
            int sum1 = 0;
            int sum = 1;
            int n = 0;
            while (num > 0)
            {
                n = num % 10;
                for (int i = 1; i <= n; i++)
                {
                    sum *= i;

                }
                sum1 += sum;
                sum = 1;
                num /= 10;
            }
            if (sum1 == goalSum) Console.WriteLine("yes");
            if (sum1 != goalSum) Console.WriteLine("no");
        }
    }
}