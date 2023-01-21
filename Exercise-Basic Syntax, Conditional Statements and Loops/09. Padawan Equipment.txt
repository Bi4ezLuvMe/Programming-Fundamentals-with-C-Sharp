namespace Basic_Syntax_Conditional_Statements_and_Loops_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int numOfStudents = int.Parse(Console.ReadLine());
            double priceLightSaber = double.Parse(Console.ReadLine());
            double priceRobe = double.Parse(Console.ReadLine());
            double priceBelt = double.Parse(Console.ReadLine());
            int freeBelts = numOfStudents / 6;
            double sum = priceLightSaber * (Math.Ceiling(numOfStudents * 1.1)) + priceRobe * numOfStudents + priceBelt * (numOfStudents - freeBelts);
            if (budjet >= sum)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {sum - budjet:f2}lv more.");
            }
        }
    }
}