namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 1;
            int count1 = 0;
            int element = 0;
            for (int i = 0; i < Array.Length - 1; i++)
            {
                if (Array[i] == Array[i + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > count1)
                {
                    count1 = count;
                    element = Array[i];
                }
            }
            for (int i = 0; i < count1; i++)
            {
                Console.Write($"{element} ");
            }
        }
    }
}