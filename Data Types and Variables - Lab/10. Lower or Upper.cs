namespace Data_Types_and_Variables___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
           char ch = char.Parse(Console.ReadLine());
            bool isLower = char.IsLower(ch);
            if(isLower )
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}