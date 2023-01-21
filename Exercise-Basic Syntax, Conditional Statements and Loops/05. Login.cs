namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            string input = Console.ReadLine();
            int count = 1;
            string reversePass = string.Empty;
            for (int i = pass.Length - 1; i >= 0; i--)
            {
                reversePass += pass[i];
            }
            while (!input.Equals(reversePass))
            {
                if (count > 3)
                {
                    Console.WriteLine($"User {pass} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                input = Console.ReadLine();
                count++;
            }
            Console.WriteLine($"User {pass} logged in.");
        }
    }
}