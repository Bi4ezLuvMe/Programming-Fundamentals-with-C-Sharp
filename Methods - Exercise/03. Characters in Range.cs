using System.Globalization;
using System.Linq.Expressions;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            if (b < a)
            {
                char temp = a;
                a = b;
                b = temp;
            }
            PrintChars(a, b);
        }
      static void PrintChars(char a, char b)
        {
            for (int i = (int)a+1; i < (int)b; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}