using System;
using System.Collections.Concurrent;

namespace Lab_Intro_and_Basic_Syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n= int.Parse(Console.ReadLine());
            int num = 1;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += num;
                Console.WriteLine(num);
                num += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}