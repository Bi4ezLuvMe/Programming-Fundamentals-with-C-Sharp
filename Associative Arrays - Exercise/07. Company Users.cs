using System.Collections.Specialized;
using System.Data;
using System.Numerics;

namespace ConsoleApp16
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
          Dictionary<string,List<string>>employees = new Dictionary<string,List<string>>();
            string command = Console.ReadLine();
            while(command != "End")
            {
                string[] commandAsAnArray = command.Split(" -> ");
                string company = commandAsAnArray[0];
                string userID = commandAsAnArray[1];
                if(!employees.ContainsKey(company)) 
                {
                    employees.Add(company,new List<string> { userID});
                }
                else
                {
                    bool isThere = false;
                    foreach (var employee in employees)
                    {
                        foreach (var curr in employee.Value)
                        {
                           if(curr==userID)
                            {
                                isThere= true;
                            }
                        }
                    }
                    if(!isThere)
                    {
                        employees[company].Add(userID);
                    }
                }
                command = Console.ReadLine();
            }
            foreach(var employee in employees)
            {
                Console.WriteLine($"{employee.Key}");
              foreach(var curr in employee.Value) 
                {
                    Console.WriteLine($"-- {curr}");
                }
            }
        }         
    }
}