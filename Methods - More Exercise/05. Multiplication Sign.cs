using System.Numerics;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Sign(num1,num2,num3);
        }
        static void Sign(int num1, int num2, int num3) {
            int count = 0;
            if (num1 < 0)
            {
                count++;
                
            }
            if(num2<0)
            {
                count++;
            }
            if (num3 < 0)
            {
                count++;
            }
             if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                Console.WriteLine("zero");
            }else if (count == 2)
            {
                Console.WriteLine("positive");
            }
            else if (num1 < 0 || num2 < 0 || num3 < 0)
            {
                Console.WriteLine("negative");
            }
            else 
            {
                Console.WriteLine("positive");
            }
        }
    }
}