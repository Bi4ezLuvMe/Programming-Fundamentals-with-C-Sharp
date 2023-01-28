namespace asdf
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            int[]Array =new int[n];
            for (int i = 0; i < n; i++)
            {
                Array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = n-1; i >= 0; i--)
            {
                Console.Write($"{Array[i]} ");
            }
        }
    }
}