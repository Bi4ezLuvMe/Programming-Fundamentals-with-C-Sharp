namespace Data_Types_and_Variables___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            if (numOfPeople % capacity == 0)
            {
                Console.WriteLine($"{numOfPeople / capacity}");
            }
            else
            {
                Console.WriteLine($"{(numOfPeople / capacity) + 1}");
            }
        }
    }
}