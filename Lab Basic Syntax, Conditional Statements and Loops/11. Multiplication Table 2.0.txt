using System;
using System.Collections.Concurrent;

namespace Lab_Intro_and_Basic_Syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=int.Parse(Console.ReadLine());
            int start=int.Parse(Console.ReadLine()) ;
            if(start > 10)
            {
                Console.WriteLine($"{num} X {start} = {num*start}");
                return;
            }
            for (int i = start; i <= 10; i++)
            {
                Console.WriteLine($"{num} X {i} = {num*i}");
            }
        }
    }
}