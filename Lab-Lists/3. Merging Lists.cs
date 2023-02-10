using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int min = Math.Min(list1.Count, list2.Count);
            int max = Math.Max(list1.Count, list2.Count);
            for (int i = 0; i < min; i++)
            {
                result.Add(list1[i]);
                result.Add(list2[i]);
            }
            if (list1.Count > list2.Count)
            {
                for (int i = min; i < max; i++)
                {
                    result.Add(list1[i]);
                }
            }
            else
            {
                for (int i = min; i < max; i++)
                {
                    result.Add(list2[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}