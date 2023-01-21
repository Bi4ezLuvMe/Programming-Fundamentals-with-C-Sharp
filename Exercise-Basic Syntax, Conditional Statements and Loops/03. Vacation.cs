namespace Basic_Syntax__Conditional_Statements_and_Loops_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count=int.Parse(Console.ReadLine());
            string type=Console.ReadLine();
            string day=Console.ReadLine();
            double price = 0;
            double sum = 0;
            if(type.Equals("Students"))
            {
                switch (day)
                {
                    case "Friday":price = 8.45; break;
                    case "Saturday": price = 9.80; break;
                    case "Sunday": price = 10.46; break;
                }
                sum = price * count;
                if (count >= 30)
                {
                    sum *= 0.85;
                }
            }
            else if(type.Equals("Business"))
            {
                if (count >= 100)
                {
                    count -= 10;
                }
                switch (day)
                {
                    case "Friday": price = 10.90; break;
                    case "Saturday": price = 15.60; break;
                    case "Sunday": price = 16; break;
                }
                sum = price * count;
            }
            else if (type.Equals("Regular"))
            {
                switch (day)
                {
                    case "Friday": price = 15; break;
                    case "Saturday": price = 20; break;
                    case "Sunday": price = 22.50; break;
                }
                sum = price * count;
                if (count > 9 && count < 21)
                {
                    sum *= 0.95;
                }
            }
            Console.WriteLine($"Total price: {sum:f2}");
        }
    }
}