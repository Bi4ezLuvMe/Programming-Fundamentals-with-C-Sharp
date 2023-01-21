namespace Basic_Syntax_Conditional_Statements_and_Loops_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            double budjet1 = budjet;
            while (true)
            {
                string wantedGame = Console.ReadLine();
                if (wantedGame.Equals("Game Time"))
                {
                    Console.WriteLine($"Total spent: ${budjet1 - budjet:f2}. Remaining: ${budjet1 - (budjet1 - budjet):f2}");
                    return;
                }
                switch (wantedGame)
                {
                    case "OutFall 4":
                        if (budjet >= 39.99)
                        {
                            Console.WriteLine("Bought OutFall 4");
                            budjet -= 39.99;
                        }
                        else if (budjet < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        if (budjet == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                        break;
                    case "CS: OG":
                        if (budjet >= 15.99)
                        {
                            Console.WriteLine("Bought CS: OG");
                            budjet -= 15.99;
                        }
                        else if (budjet < 15.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        if (budjet == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                        break;
                    case "Zplinter Zell":
                        if (budjet >= 19.99)
                        {
                            Console.WriteLine("Bought Zplinter Zell");
                            budjet -= 19.99;
                        }
                        else if (budjet < 19.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        if (budjet == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                        break;
                    case "Honored 2":
                        if (budjet >= 59.99)
                        {
                            Console.WriteLine("Bought Honored 2");
                            budjet -= 59.99;
                        }
                        else if (budjet < 59.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        if (budjet == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                        break;
                    case "RoverWatch":
                        if (budjet >= 29.99)
                        {
                            Console.WriteLine("Bought RoverWatch");
                            budjet -= 29.99;
                        }
                        else if (budjet < 29.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        if (budjet == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (budjet >= 39.99)
                        {
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                            budjet -= 39.99;
                        }
                        else if (budjet < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        if (budjet == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                        break;
                    default: Console.WriteLine("Not Found"); break;
                }
            }
        }
    }
}
