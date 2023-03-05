using System.Data;
using System.Numerics;

namespace ConsoleApp16
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
          int n =int.Parse(Console.ReadLine());
            Dictionary<string, string>parking = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] command1 = command.Split();
                if (command1[0] == "register")
                {
                    if (!parking.ContainsKey(command1[1]))
                    {
                        parking.Add(command1[1], command1[2]);
                        Console.WriteLine($"{command1[1]} registered {command1[2]} successfully");
                    }
                    else
                    {
                        foreach(var curr in parking)
                        {
                            if(curr.Key == command1[1]) 
                            {
                                Console.WriteLine($"ERROR: already registered with plate number {curr.Value}");
                            }
                        }
                    }
                }
                else
                {
                    if (!parking.ContainsKey(command1[1]))
                    {
                        Console.WriteLine($"ERROR: user {command1[1]} not found");
                    }
                    else
                    {
                        parking.Remove(command1[1]);
                        Console.WriteLine($"{command1[1]} unregistered successfully");
                    }
                }
            }
            foreach(var curr in parking)
            {
                Console.WriteLine($"{curr.Key} => {curr.Value}");
            }
        }         
    }
}