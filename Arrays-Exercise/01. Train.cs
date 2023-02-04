using System.Runtime.Serialization.Formatters;

namespace asdf
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int n = int.Parse(Console.ReadLine());
            int[]Array= new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                Array[i]=int.Parse(Console.ReadLine());
               
                sum += Array[i];
            }
           
            for (int i = 0; i < n; i++)
            {
                if(i == n-1)
                {
                    Console.WriteLine(Array[i]);
                }
                else
                {
                    Console.Write($"{Array[i]} ");
                }
            }
            Console.WriteLine(sum);
        }
    }
}