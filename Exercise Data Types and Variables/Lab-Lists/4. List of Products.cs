using System;
using System.Collections.Generic;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Liststring products = new Liststring();
            for (int i = 0; i  n; i++)
            {
                products.Add(Console.ReadLine());
            }
            products.Sort();
            for (int i = 0; i  n; i++)
            {
                Console.WriteLine(${i + 1}.{products[i]});
            }
        }
    }
}