using System.Data;
using System.Numerics;

namespace ConsoleApp16
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int>count = new Dictionary<string,int>();
            string command = Console.ReadLine();
            while(command != "stop")
            {
                int resourse = int.Parse(Console.ReadLine());
                if(!count.ContainsKey(command))count.Add(command,resourse);
                else count[command]+=resourse;
                command = Console.ReadLine();   
            }
            foreach(var curr in count)
            {
                Console.WriteLine($"{curr.Key} -> {curr.Value}");
            }
        }         
    }
}