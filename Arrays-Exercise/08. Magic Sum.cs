namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicSum = int.Parse(Console.ReadLine());
            for (int i = 0; i < Array.Length-1; i++)
            {
                for (int j = i+1; j < Array.Length; j++)
                {
                    if (Array[i] + Array[j] == magicSum)
                    {
                        Console.WriteLine($"{Array[i]} {Array[j]}");
                    }
                }
            }
        }
    }
}