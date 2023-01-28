using System.Runtime.Serialization.Formatters;

namespace asdf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] Array = input.Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (Array[i] % 2 == 0)
                {
                    sum += Array[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}