namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());


            double output = FirstFactorial(num1) / SecondFactorial(num2);

            Console.WriteLine($"{output:f2}");

        }
        static double FirstFactorial(int num1)
        {
            double firstFactorial = 1;
            for (int i = 1; i <= num1; i++)
            {
                firstFactorial *= i;
            }
            return firstFactorial;
        }
        static double SecondFactorial(int num2)
        {
            double secondFactorial = 1;
            for (int i = 1; i <= num2; i++)
            {
                secondFactorial *= i;
            }
            return secondFactorial;
        }
    }
}