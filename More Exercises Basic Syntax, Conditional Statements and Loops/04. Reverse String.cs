
namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalString = Console.ReadLine();
            char[] stringArray = originalString.ToCharArray();
            Array.Reverse(stringArray);
            string reverseString = new string(stringArray);
            Console.WriteLine(stringArray);
        }
    }
}