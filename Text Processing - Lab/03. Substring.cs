using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
         string word = Console.ReadLine();
            string wordToRemove = Console.ReadLine();
            while (wordToRemove.Contains(word))
            {
                int index = wordToRemove.IndexOf(word);
                wordToRemove = wordToRemove.Remove(index, word.Length);
            }
            Console.WriteLine(wordToRemove);
        }
    }
}