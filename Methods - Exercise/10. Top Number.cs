namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int number = 0;
            bool Is1Odd = false;
            int temp = 0;
            for (int i = 1; i <= num; i++)
            {
                number = i;
                while (number > 0)
                {
                    sum += number % 10;
                    temp = number % 10;
                    if (temp % 2 != 0)
                    {
                        Is1Odd = true;
                    }
                    temp = 0;
                    number /= 10;
                }
                if (sum % 8 == 0 && Is1Odd)
                {
                    Console.WriteLine(i);
                }
                Is1Odd = false;
                sum = 0;
            }
        }
    }
}