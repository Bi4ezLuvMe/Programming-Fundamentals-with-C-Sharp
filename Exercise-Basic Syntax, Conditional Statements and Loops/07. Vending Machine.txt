namespace Basic_Syntax_Conditional_Statements_and_Loops_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string coin1 = Console.ReadLine();
            double coins = double.Parse(coin1);
            double sum = 0;
            if (coin1 == "0.1" || coin1 == "0.2" || coin1 == "0.5" || coin1 == "1" || coin1 == "2")
            {
                sum = coins;
            }
            else
            {
                Console.WriteLine($"Cannot accept {coin1}");
            }
            
            while (coin1 != "Start")
            {
                coin1 = Console.ReadLine();
                if (coin1 == "Start") break;
                if (coin1 == "0.1" || coin1 == "0.2" || coin1 == "0.5" || coin1 == "1" || coin1 == "2")
                {
                    coins = double.Parse(coin1);
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin1}");
                }
            }
            string wantedItem = Console.ReadLine();


            while (wantedItem != "End")
            {
                switch (wantedItem)
                {
                    case "Coke": sum -= 1; if (sum < 0) { Console.WriteLine("Sorry, not enough money"); sum += 1; } else { Console.WriteLine("Purchased coke"); } break;
                    case "Soda":
                        sum -= 0.8; if (sum < 0) { Console.WriteLine("Sorry, not enough money"); sum += 0.8; }
                        else
                        {
                            Console.WriteLine("Purchased soda");
                        }
                        break;
                    case "Crisps":
                        sum -= 1.5; if (sum < 0) { Console.WriteLine("Sorry, not enough money"); sum += 1.5; }
                        else
                        {
                            Console.WriteLine("Purchased crisps");
                        }
                        break;
                    case "Water":
                        sum -= 0.7; if (sum < 0) { Console.WriteLine("Sorry, not enough money"); sum += 0.7; }
                        else
                        {
                            Console.WriteLine("Purchased water");
                        }
                        break;
                    case "Nuts":
                        sum -= 2; if (sum < 0) { Console.WriteLine("Sorry, not enough money"); sum += 2; }
                        else
                        {
                            Console.WriteLine("Purchased nuts");
                        }
                        break;
                    default: Console.WriteLine("Invalid product"); break;
                }
                wantedItem = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}