namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                string newWord = String.Empty;
                for (int j = input.Length - 1; j >= 0; j--)
                {
                    newWord += input[j];
                }
                Console.WriteLine($"{input} = {newWord}");
                input = Console.ReadLine();
            }
        }
    }
}