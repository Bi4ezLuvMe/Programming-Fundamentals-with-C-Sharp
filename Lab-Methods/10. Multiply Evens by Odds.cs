using System.Text;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int number=int.Parse(Console.ReadLine());
            Console.WriteLine(EvenSum(number)*OddSum(number));
        }
       static int EvenSum(int number)
        {
            int num = 0;
            int sum = 0;
            while (Math.Abs(number) > 0)
            {
                num = number % 10;
                if(num%2== 0)
                {
                    sum += num;
                }
                number /= 10;
            }
            return sum;
        }
        static int OddSum(int number)
        {
            int num = 0;
            int sum = 0;
            while (Math.Abs(number) > 0)
            {
                num = number % 10;
                if (num % 2 != 0)
                {
                    sum += num;
                }
                number /= 10;
            }
            return sum;
        }
    }
}