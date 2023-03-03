using System.Data;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string,List<string>>words = new Dictionary<string,List<string>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();
                if (!words.ContainsKey(key))
                {
                    words.Add(key, new List<string>());
                }
                    words[key].Add(value);
            }
            foreach(var word in words)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ",word.Value)}");
            }
        }
    }
}