using System.Data;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[]numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            SortedDictionary<int, int>count = new SortedDictionary<int, int>();
            foreach (int number in numbers)
            {
                if (count.ContainsKey(number))
                {
                    count[number]++;
                }
                else
                {
                    count.Add(number, 1);
                }
            }
            foreach(var (Key,Value) in count) 
            {
                Console.WriteLine($"{Key} -> {Value}");
            }
        }
    }
}