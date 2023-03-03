namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Random random= new Random();
            for (int i = 0; i < input.Length; i++)
            {
                int randomIndex = random.Next(0, input.Length);
                string input1 = input[i];
                input[i] = input[randomIndex];
                input[randomIndex] =input1;
                
            }
            Console.WriteLine(string.Join(Environment.NewLine,input));
        }
    }
}