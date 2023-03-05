using System.Data;
using System.Numerics;

namespace ConsoleApp16
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandAsAnArray = command.Split(" : ");
                if (!users.ContainsKey(commandAsAnArray[0]))
                {
                    users.Add(commandAsAnArray[0], new List<string> { commandAsAnArray[1] });
                }
                else
                {
                    users[commandAsAnArray[0]].Add(commandAsAnArray[1]);
                }
                command = Console.ReadLine();
            }
            foreach (var user in users)
            {
                int count = 0;
                foreach (var curr in user.Value)
                {
                    count++;
                }
                Console.WriteLine($"{user.Key}: {count}");
               foreach(var curr in user.Value)
                {
                    Console.WriteLine($"-- {curr}");
                }
            }
        }
    }
}