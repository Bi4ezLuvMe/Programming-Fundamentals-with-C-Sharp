using System.Numerics;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int num = int.Parse(Console.ReadLine());
            BigInteger sum = 1;
            for (int i = 2; i <= num; i++)
            {
                sum *= i;
            }
            Console.WriteLine(sum);
        }
    }
}