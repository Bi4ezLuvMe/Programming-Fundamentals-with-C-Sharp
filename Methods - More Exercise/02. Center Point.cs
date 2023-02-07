namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double X1= double.Parse(Console.ReadLine()); 
            double Y1= double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());
            Distance(X1, Y1,X2,Y2 );
        }
       static void Distance(double x1, double y1, double x2, double y2)
        {
            double sum1 = Math.Sqrt(Math.Abs(x1 * x1) + Math.Abs(y1 * y1));
            double sum2 = Math.Sqrt(Math.Abs(x2 * x2) + Math.Abs(y2 * y2));
            if (sum1 > sum2)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else if(sum2 > sum1)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            if (sum1 == sum2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }
    }
}