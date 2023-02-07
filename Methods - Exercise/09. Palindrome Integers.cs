namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                int num = int.Parse(command);
                int number = num;
                int a;
                string num1 = string.Empty;
                while (num > 0)
                {
                    a = num % 10;
                    num1 += a;
                    num /= 10;
                }
                int num2 = int.Parse(num1);
                if (num2 == number)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}