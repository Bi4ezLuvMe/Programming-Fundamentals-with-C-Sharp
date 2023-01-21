namespace Basic_Syntax_Conditional_Statements_and_Loops_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            double sum = 0;
            int numOfOrders = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfOrders; i++)
            {
                double priceCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int countCapsules = int.Parse(Console.ReadLine());
                sum = ((days * countCapsules) * priceCapsule);
                Console.WriteLine($"The price for the coffee is: ${sum:f2}");
                total += sum;
            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}