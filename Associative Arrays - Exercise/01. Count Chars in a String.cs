using System.Data;
using System.Numerics;

namespace ConsoleApp16
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
          Dictionary<char,int>count = new Dictionary<char,int>();
            string word = Console.ReadLine();
            string[]wordAsAnArray = word.Split(" ",StringSplitOptions.RemoveEmptyEntries);    
             word = string.Join("",wordAsAnArray);
            for (int i = 0; i < word.Length; i++)
            {
                if (!count.ContainsKey(word[i]))
                {
                    count.Add(word[i], 1);
                }
                else
                {
                    count[word[i]]++;
                }
            }
            foreach(var c in count)
            {
                Console.WriteLine($"{c.Key} -> {c.Value}");
            }
        }         
    }
}