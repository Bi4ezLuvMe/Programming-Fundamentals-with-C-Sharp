using System.Numerics;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            string[] typeList = new string[n];
            string[] name = new string[n];
            string[] time = new string[n];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputAsArray = input.Split('_');
                typeList[i] = inputAsArray[0];
                name[i] = inputAsArray[1];
                time[i] = inputAsArray[2];
              
            }
            string type = Console.ReadLine();
            if (type == "all")
            {
                Console.WriteLine(string.Join(Environment.NewLine,name));
                return;
            }
            for (int i = 0; i < n; i++)
            {
                if (type == typeList[i]) 
                {
                    Console.WriteLine(name[i]);
                }
            }
        }
    }
}