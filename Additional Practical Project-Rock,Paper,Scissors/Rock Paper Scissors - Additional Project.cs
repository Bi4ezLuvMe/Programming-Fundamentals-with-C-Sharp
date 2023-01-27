namespace asdf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Rock = "Rock";
            string Paper = "Paper";
            string Scissors = "Scissors";
            bool isAnother = false;
            do
            {
                Console.Write("Choose [r]ock, [p]aper or [s]cissors:");
                string playerMove = Console.ReadLine();
                bool isInvalid = true;
                string playAgain;
                while (isInvalid.Equals(true))
                {
                    if (playerMove == "r" || playerMove == "rock")
                    {
                        playerMove = Rock;
                        isInvalid = false;
                    }
                    else if (playerMove == "p" || playerMove == "paper")
                    {
                        playerMove = Paper;
                        isInvalid = false;
                    }
                    else if (playerMove == "s" || playerMove == "scissors")
                    {
                        playerMove = Scissors;
                        isInvalid = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please try again.");
                    }
                }
                Random randomNum = new Random();
                int computerInput = randomNum.Next(1, 4);
                string computerMove = String.Empty;
                switch (computerInput)
                {
                    case 1:
                        computerMove = Rock;
                        break;
                    case 2:
                        computerMove = Paper;
                        break;
                    case 3:
                        computerMove = Scissors;
                        break;
                }
                Console.WriteLine($"The computer chose {computerMove}.");
                if ((playerMove == Rock && computerMove == Scissors) || (playerMove == Paper && computerMove == Rock) || (playerMove == Scissors && computerMove == Paper))
                {
                    Console.WriteLine("Congratulations! You win!");
                    Console.Write("If you want to play another game enter /yes/:");
                    playAgain = Console.ReadLine();
                    isAnother = true;
                }
                else if (playerMove.Equals(computerMove))
                {
                    Console.WriteLine("It's a draw!");
                    Console.Write("If you want to play another game enter /yes/:");
                    playAgain = Console.ReadLine();
                    isAnother = true;
                }
                else
                {
                    Console.WriteLine("You lose!");
                    Console.Write("If you want to play another game enter /yes/:");
                    playAgain = Console.ReadLine();
                    isAnother = true;
                }
            } while (isAnother.Equals("True"));
        }
    }
}