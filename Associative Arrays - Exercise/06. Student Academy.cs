using System.Data;
using System.Numerics;

namespace ConsoleApp16
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
          Dictionary<string,double>students = new Dictionary<string,double>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if(!students.ContainsKey(name))students.Add(name, grade);
                else
                {
                    double average = 0;
                    foreach(var curr in students)
                    {
                        if(curr.Key==name)average = curr.Value;
                    }
                    average += grade;
                    average /= 2;
                    students[name] = average;
                }
            }
            foreach (var curr in students)
            {
                if (curr.Value >= 4.50)
                {
                    Console.WriteLine($"{curr.Key} -> {curr.Value:f2}");
                }
            }
        }         
    }
}