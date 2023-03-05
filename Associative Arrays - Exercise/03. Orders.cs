using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var check = new Dictionary<string, List<decimal>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();

                string key = input[0];

                if (key.ToLower() == "buy")
                {
                    break;
                }

                decimal price = decimal.Parse(input[1]);
                decimal count = decimal.Parse(input[2]);

                if (!check.ContainsKey(key))
                {
                    check.Add(key, new List<decimal>() { price, count });
                }
                else
                {
                    check[key][0] = price;
                    check[key][1] += count;

                }

            }
            foreach (var product in check)
            {
                Console.WriteLine($"{product.Key} -> {(product.Value[0] * product.Value[1]):f2}");
            }
        }
    }
}