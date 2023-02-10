using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int>temp = new List<int>(numbers.Count/2);
            int middleNumber = numbers[numbers.Count/2];
            int a = numbers.Count;
            if(numbers.Count % 2 != 0)
            {
                numbers.RemoveAt(numbers.Count/2);
            }
            for (int i = 0; i < numbers.Count/2; i++)
            {
                temp.Add(numbers.ElementAt(i) + numbers.ElementAt(numbers.Count - 1 - i));
                
            }
            if (a % 2 != 0)
            {
                temp.Add(middleNumber);
            }
            Console.WriteLine(string.Join(" ", temp));
        }
    }
}