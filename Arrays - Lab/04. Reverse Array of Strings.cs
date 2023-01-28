namespace asdf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Array = Console.ReadLine().Split().ToArray();
            for (int i = Array.Length-1; i >= 0; i--)
            {
                Console.Write($"{Array[i]} ");
            }
        }
    }
}