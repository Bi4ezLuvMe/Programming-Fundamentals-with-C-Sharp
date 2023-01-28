using System.Runtime.Serialization.Formatters;

namespace asdf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split();
            int[] Array1 = input1.Select(int.Parse).ToArray();
            string[] input2 = Console.ReadLine().Split();
            int[] Array2 = input2.Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < input1.Length; i++)
            {
                    if (Array1[i] != Array2[i])
                    {
                        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                        return;
                    }
                    else
                    {
                        sum += Array1[i];
                    }
            }
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}