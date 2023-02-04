using System.Runtime.Serialization.Formatters;

namespace asdf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Array1 = Console.ReadLine().Split();
            string[] Array2 = Console.ReadLine().Split();
            for (int i = 0; i < Array2.Length; i++)
            {
                for (int j = 0; j < Array1.Length; j++)
                {
                    if (Array2[i] == Array1[j])
                    {
                        Console.Write($"{Array2[i]} ");
                    }
                }
            }
        }
    }
}