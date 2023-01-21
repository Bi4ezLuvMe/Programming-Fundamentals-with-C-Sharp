namespace Basic_Syntax_Conditional_Statements_and_Loops_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                if (num2 > num3)
                {
                    Console.WriteLine(num1);
                    Console.WriteLine(num2);
                    Console.WriteLine(num3);

                }
                else
                {
                    Console.WriteLine(num1);
                    Console.WriteLine(num3);
                    Console.WriteLine(num2);
                }
            }
            else if (num2 > num1 && num2 > num3)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(num2);
                    Console.WriteLine(num1);
                    Console.WriteLine(num3);
                }
                else
                {
                    Console.WriteLine(num2);
                    Console.WriteLine(num3);
                    Console.WriteLine(num1);
                }
            }
            else
            {
                if (num2 > num1)
                {
                    Console.WriteLine(num3);
                    Console.WriteLine(num2);
                    Console.WriteLine(num1);
                }
                else
                {
                    Console.WriteLine(num3);
                    Console.WriteLine(num1);
                    Console.WriteLine(num2);
                }
            }
        }
    }
}