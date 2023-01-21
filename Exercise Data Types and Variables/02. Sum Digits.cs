namespace Data_Types_and_Variables___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numAsStr=Console.ReadLine();
            int num = int.Parse(numAsStr);
            int sum = 0;
            for (int i = 0; i < numAsStr.Length; i++)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}