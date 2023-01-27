namespace asdf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                int[]Array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int num1 = Array[0];
                int num2 = Array[1];
                if (num1>num2)
                {
                    int sum = 0;
                    while (num1 > 0)
                    {
                        sum += num1 % 10;
                        num1 /= 10;
                    }
                    Console.WriteLine(sum);
                }
                else
                {
                    int sum = 0;
                    while (num2 > 0)
                    {
                        sum += num2 % 10;
                        num2 /= 10;
                    }
                    Console.WriteLine(sum);
                }
            }
        }
    }
}