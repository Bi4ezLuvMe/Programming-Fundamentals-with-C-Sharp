namespace Basic_Syntax_Conditional_Statements_and_Loops_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int headsetTrashesh = 0;
            int mouseTrashes = 0;
            int displayTrashes = 0;
            int keyboardTrashes = 0;
            for (int game = 1; game <= lostGamesCount; game++)
            {
                bool keyboard = false;
                if (game % 2 == 0)
                {
                    headsetTrashesh++;
                }
                if (game % 3 == 0)
                {
                    mouseTrashes++;
                }
                if (game % 2 == 0 && game % 3 == 0)
                {
                    keyboardTrashes++;
                    keyboard = true;
                }
                if (keyboard && keyboardTrashes % 2 == 0 && keyboardTrashes != 0)
                {
                    displayTrashes++;
                }
            }
            double totalPrice = mouseTrashes * mousePrice + headsetTrashesh * headsetPrice + displayTrashes * displayPrice + keyboardTrashes * keyboardPrice;
            Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");
        }
    }
}