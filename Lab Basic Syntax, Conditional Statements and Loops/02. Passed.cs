using System;
namespace Lab_Intro_and_Basic_Syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double grade = double.Parse(Console.ReadLine());
          if(grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}