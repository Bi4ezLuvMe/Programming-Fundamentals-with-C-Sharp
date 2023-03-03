using System.Data;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().Select(words=>words.ToLower()).ToArray();
            Dictionary<string , int>count = new Dictionary<string , int>();
            foreach (var word in words)
            {
                if (count.ContainsKey(word))
                {
                    count[word]++;
                }
                else
                {
                    count.Add(word, 1);
                }
            }
            foreach (var counts in count)
            {
                if (counts.Value % 2 != 0)
                {
                    Console.Write($"{counts.Key} ");
                }
            }
        }
    }
}