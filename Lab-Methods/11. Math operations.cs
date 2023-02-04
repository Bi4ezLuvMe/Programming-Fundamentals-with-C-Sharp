namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string Operator = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            Output(a,b,Operator);
        }
        static void Output(int a, int b, string Operator)
        {
            switch (Operator)
            {
                case "/":
                    Console.WriteLine(a / b);
                    break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "+":
                    Console.WriteLine(a + b);
                    break;
                case "-":
                    Console.WriteLine(a - b);
                    break;
            }
        }
    }
}