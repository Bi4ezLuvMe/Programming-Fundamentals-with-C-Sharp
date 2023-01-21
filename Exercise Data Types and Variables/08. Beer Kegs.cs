namespace Data_Types_and_Variables___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string model1 = string.Empty;
            double theBiggest = 0;
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(radius, 2) * height;
                if (volume > theBiggest)
                {
                    model1 = model;
                    theBiggest = volume;
                }
            }
            Console.WriteLine(model1);
        }
    }
}