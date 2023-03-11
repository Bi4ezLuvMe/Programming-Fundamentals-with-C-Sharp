using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            for (int i = 0; i < bannedWords.Length; i++)
            {
                while (text.Contains(bannedWords[i]))
                {
                    text = text.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}