namespace Data_Types_and_Variables___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine()); //N
            int power1 = power;
            int distance = int.Parse(Console.ReadLine());  //M
            int exhaustion = int.Parse(Console.ReadLine()); //Y
            int count = 0;
            while (power >= distance)
            {
                power -= distance;
                count++;
                if (power1 * 0.5 == power && exhaustion != 0)
                {
                    power /= exhaustion;
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(count);
        }
    }
}