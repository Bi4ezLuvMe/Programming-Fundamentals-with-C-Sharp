namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MiddleChar(input);
        }
        static void MiddleChar(string input)
        {
            char ch = (char)0;
            char ch1 = (char)0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input.Length % 2 == 0)
                {
                    if (i == input.Length / 2 - 1)
                    {
                        ch = input[i];
                    }
                    if (i == input.Length / 2)
                    {
                        ch1 = input[i];
                    }

                }
                else
                {
                    if (i == input.Length / 2)
                    {
                        ch1 = input[i];
                    }
                }
            }
            if (input.Length % 2 == 0)
            {
                Console.Write(ch);
                Console.WriteLine(ch1);
            }
            else
            {
                Console.WriteLine(ch1);
            }
        }
    }
}