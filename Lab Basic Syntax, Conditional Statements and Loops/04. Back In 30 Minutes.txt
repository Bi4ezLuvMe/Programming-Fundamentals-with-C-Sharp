using System;
namespace Lab_Intro_and_Basic_Syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine()) + 30;    
            if(minutes >= 60)
            {
                hour++;
                minutes -= 60;

            }
            if(hour>23)
            {
                hour = 0;
            }
            Console.WriteLine($"{hour}:{minutes:d2}");
        }
    }
}