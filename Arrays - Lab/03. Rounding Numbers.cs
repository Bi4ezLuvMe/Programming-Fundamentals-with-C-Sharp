namespace asdf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] Array = Console.ReadLine()
                    .Split()
                    .Select(double.Parse)
                    .ToArray();

            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == -0)
                {
                    Console.WriteLine($"{Array[i]} => 0");
                }
                else
                {
                    Console.WriteLine($"{Array[i]} => {Math.Round(Array[i], MidpointRounding.AwayFromZero)}");
                }
            } 
        }
    }
}