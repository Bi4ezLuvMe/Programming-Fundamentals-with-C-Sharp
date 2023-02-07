using System.Globalization;
using System.Linq.Expressions;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string word=Console.ReadLine();
            Console.WriteLine(VowelCount(word));
        }
        static int VowelCount(string word)
        {
            int count = 0;  
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]=='a'|| word[i] == 'o' || word[i] == 'e' || word[i] == 'u' || word[i] == 'y'||word[i] == 'A' || word[i] == 'O' || word[i] == 'E' || word[i] == 'U' || word[i] == 'Y' || word[i] == 'i' || word[i]=='I')
                {
                    count++;
                }
            }
            return count;
        }
    }
}