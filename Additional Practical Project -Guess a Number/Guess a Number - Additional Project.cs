namespace asdf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomNum = new Random();
            for (int i = 1; i <= 3; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("Difficulty: easy");
                    int computerNumber = randomNum.Next(1, 51);
                    Console.WriteLine("The number will be between 1 and 50, and you'll have 5 tries to guess it!");
                    int input = 0;
                    int count = 0;
                    while (input != computerNumber)
                    {
                        input = int.Parse(Console.ReadLine());
                        count++;
                        if (count == 5)
                        {
                            Console.WriteLine("You ran out of tries!");
                            return;
                        }
                        if (input == computerNumber)
                        {
                            if (count == 1)
                            {
                                Console.WriteLine("You guessed it with 1 try!");
                            }
                            Console.WriteLine($"You guessed it with {count} tries!");
                        }
                        if (input < computerNumber)
                        {
                            Console.WriteLine("Too Low");
                        }
                        else
                        {
                            Console.WriteLine("Too High");
                        }
                    }
                }
                else if (i == 2)
                {
                    Console.WriteLine("Difficulty: medium");
                    int computerNumber = randomNum.Next(1, 101);
                    Console.WriteLine("The number will be between 1 and 100, and you'll have 5 tries to guess it!");
                    int input = 0;
                    int count = 0;
                    while (input != computerNumber)
                    {
                        input = int.Parse(Console.ReadLine());
                        count++;
                        if (count == 5)
                        {
                            Console.WriteLine("You ran out of tries!");
                            return;
                        }
                        if (input == computerNumber)
                        {
                            if (count == 1)
                            {
                                Console.WriteLine("You guessed it with 1 try!");
                            }
                            Console.WriteLine($"You guessed it with {count} tries!");
                        }
                        if (input < computerNumber)
                        {
                            Console.WriteLine("Too Low");
                        }
                        else
                        {
                            Console.WriteLine("Too High");
                        }
                    }

                }
                else if (i == 3)
                {
                    Console.WriteLine("Difficulty: hard");
                    int computerNumber = randomNum.Next(1, 200);
                    Console.WriteLine("The number will be between 1 and 200, and you'll have 5 tries to guess it!");
                    int input = 0;
                    int count = 0;
                    while (input != computerNumber)
                    {
                        input = int.Parse(Console.ReadLine());
                        count++;
                        if (count == 5)
                        {
                            Console.WriteLine("You ran out of tries!");
                            return;
                        }
                        if (input == computerNumber)
                        {
                            if (count == 1)
                            {
                                Console.WriteLine("You guessed it with 1 try!");
                            }
                            Console.WriteLine($"You guessed it with {count} tries!");
                        }
                        if (input < computerNumber)
                        {
                            Console.WriteLine("Too Low");
                        }
                        else
                        {
                            Console.WriteLine("Too High");
                        }
                    }
                }
            }
            Console.WriteLine("Congratulations! You passed all 3 difficulties!");
        }
    }
}