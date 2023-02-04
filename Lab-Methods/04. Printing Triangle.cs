using System;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintResult(num);
        }
        static void PrintResult(int n)
        {
            int counter = 0;
            while (counter != n)
            {
                for (int i = 1; i <= n; i++)
                    PrintLine(1, i);
                counter += n;
            }
            for (int i = n - 1; i >= 1; i--)
                PrintLine(1, i);
        }
        static void PrintLine(int s, int e)
        {
            for (int i = s; i <= e; i++)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}