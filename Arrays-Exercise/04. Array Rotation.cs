namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]Array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n =int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int firstElement = Array[0];
                for (int j = 0; j < Array.Length-1; j++)
                {
                    Array[j] = Array[j + 1];
                }
                Array[Array.Length - 1]= firstElement;
            }
            Console.WriteLine(string.Join(" ",Array));
        }
    }
}