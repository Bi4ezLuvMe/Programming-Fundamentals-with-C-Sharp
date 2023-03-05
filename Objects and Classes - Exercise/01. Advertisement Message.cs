using System.Data;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            string[] output = new string[n];
           Random random = new Random();
            string[] phrases = new string[6];
            phrases[0] = "Excellent product.";
            phrases[1] = "Such a great product.";
            phrases[2] = "I always use that product.";
            phrases[3] = "Best product of its category.";
            phrases[4] = "Exceptional product.";
            phrases[5] = "I can't live without this product.";
            for (int i = 0;  i< n; i++)
            {
                int index = random.Next(0, 6);
                output[i] = phrases[index];
            }
            string[]events = new string[6];
            events[0] = "Now I feel good.";
            events[1] = "I have succeeded with this product.";
            events[2] = "Makes miracles. I am happy of the results!";
            events[3] = "I cannot believe but now I feel awesome.";
            events[4] = "Try it yourself, I am very satisfied.";
            events[5] = "I feel great!";
            for (int i = 0; i < n; i++)
            {
                int index = random.Next(0, 6);
                output[i] += " " +events[index];
            }
            string[]authors= new string[8];
            authors[0] = "Diana";
            authors[1] = "Petya";
            authors[2] = "Stella";
            authors[3] = "Elena";
            authors[4] = "Katya";
            authors[5] = "Iva";
            authors[6] = "Annie";
            authors[7] = "Eva"; 
            for (int i = 0; i < n; i++)
            {
                int index = random.Next(0, 8);
                output[i] += " " + authors[index];
            }
            string[]cities= new string[5];
            cities[0] = "Burgas";
            cities[1] = "Sofia";
            cities[2] = "Plovdiv";
            cities[3] = "Varna";
            cities[4] = "Ruse"; 
            for (int i = 0; i < n; i++)
            {
                int index = random.Next(0, 5);
                output[i] += " - " + cities[index]+".";
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join("", output[i]));
            }
        }
    }
}