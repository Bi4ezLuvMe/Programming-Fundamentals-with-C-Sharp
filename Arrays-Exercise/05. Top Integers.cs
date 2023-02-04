namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]Array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < Array.Length-1; i++)
            {
                if (Array[i] > Array[i + 1])
                {
                    Console.Write($"{Array[i]} ");
                }
            }
            Console.WriteLine(Array[Array.Length-1]);
        }
    }
}