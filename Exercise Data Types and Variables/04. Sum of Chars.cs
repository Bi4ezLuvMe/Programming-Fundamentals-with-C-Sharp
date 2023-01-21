namespace Data_Types_and_Variables___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                char ch=char.Parse(Console.ReadLine()); 
                sum += ch;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}