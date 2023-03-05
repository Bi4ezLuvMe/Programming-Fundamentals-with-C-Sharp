namespace ConsoleApp16
{
    class Article
    {
        public string title;
        public string content;
        public string author;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Article article = new Article();
            int n = int.Parse(Console.ReadLine());
            string[] titles = new string[n];
            string[] contents = new string[n];
            string[] authors = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ").ToArray();
                article.title = input[0];
                titles[i] = article.title;
                article.content = input[1];
                contents[i] = article.content;
                article.author = input[2];
                authors[i] = article.author;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{titles[i]} - {contents[i]}: {authors[i]}");
            }
           
        }
    }
}