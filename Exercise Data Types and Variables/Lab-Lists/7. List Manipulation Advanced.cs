using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool IsChanged = false;
            while (true)
            {
                string command = Console.ReadLine();
                if (command.Equals("end"))
                {
                    break;
                }
                string[] command1 = command.Split();
                if (command1[0].Equals("Contains"))
                {
                    int number = int.Parse(command1[1]);
                    IsChanged= true;
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command1[0].Equals("PrintEven"))
                {
                    Console.WriteLine(string.Join(" ",numbers.Where(x => x%2==0)));
                    IsChanged = true;
                }
                else if (command1[0].Equals("PrintOdd"))
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
                    IsChanged = true;
                }
                else if (command1[0].Equals("GetSum"))
                {
                    int sum =numbers.Sum();
                    Console.WriteLine(sum);
                    IsChanged = true;
                }
                else if (command1[0].Equals("Filter"))
                {
                    IsChanged = true;
                    string condition = command1[1];
                    int number = int.Parse(command1[2]);
                    switch (condition)
                    {
                        case "<": Console.WriteLine(string.Join(" ",numbers.Where(x => x<number)));     break;
                        case "<=": Console.WriteLine(string.Join(" ", numbers.Where(x => x <= number))); break;
                        case ">": Console.WriteLine(string.Join(" ", numbers.Where(x => x > number))); break;
                        case ">=": Console.WriteLine(string.Join(" ", numbers.Where(x => x >= number))); break;
                    }
                }
            }
            if (IsChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}