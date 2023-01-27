namespace asdf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                int charr = ch + key;
                Console.Write($"{(char)charr}");
            }
        }
    }
}