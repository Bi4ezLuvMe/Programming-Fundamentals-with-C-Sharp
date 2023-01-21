using System;
namespace Lab_Intro_and_Basic_Syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
         string country = Console.ReadLine();
            switch(country)
            {
                case "England":
                case "USA": Console.WriteLine("English"); break;
                case "Spain": 
                case "Argentina":
                case "Mexico": Console.WriteLine("Spanish"); break;
               default: Console.WriteLine("unknown");break;
            }
        }
    }
}