namespace Data_Types_and_Variables___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int sum = 0;
            int days = 0;
                while (startingYield >= 100)
                {
                    sum += startingYield;
                    sum -= 26;
                    startingYield -= 10;
                    days++;
                }
                Console.WriteLine(days);
            sum -= 26;
            if (days==0)
            {
                sum += 26;
            }
            Console.WriteLine(sum);
        }
    }
}