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
            while (true)
            {
                string command = Console.ReadLine();
                if (command.Equals("end"))
                {
                    break;
                }
                string[] command1 = command.Split();
                if (command1[0].Equals("Add"))
                {
                    int number = int.Parse(command1[1]);
                    numbers.Add(number);
                }
                else if (command1[0].Equals("Remove"))
                {
                    int number = int.Parse(command1[1]);
                    numbers.Remove(number);
                }
                else if (command1[0].Equals("RemoveAt"))
                {
                    int number = int.Parse(command1[1]);
                    numbers.RemoveAt(number);
                }
                else if (command1[0].Equals("Insert"))
                {
                    int number = int.Parse(command1[1]);
                    int index = int.Parse(command1[2]);
                    numbers.Insert(index, number);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}