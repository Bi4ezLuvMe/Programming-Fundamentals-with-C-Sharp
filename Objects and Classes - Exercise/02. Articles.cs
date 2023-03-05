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
            string[]input = Console.ReadLine().Split(", ").ToArray();
            article.title = input[0];
            article.content = input[1];
            article.author = input[2];
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] commandAsAnArray = command.Split();
                switch (commandAsAnArray[0])
                {
                    case "Edit:":
                        string newName = String.Empty;
                        for (int j = 1; j < commandAsAnArray.Length; j++)
                        {
                            if (j == 1)
                            {
                                newName += commandAsAnArray[j];
                            }
                            else
                            {
                                newName += " " + commandAsAnArray[j];
                            }
                        }
                        article.content = newName;
                        break;
                    case "ChangeAuthor:":
                        string newName1 = String.Empty;
                        for (int j = 1; j < commandAsAnArray.Length; j++)
                        {
                            if (j == 1)
                            {
                                newName1 += commandAsAnArray[j];
                            }
                            else
                            {
                                newName1 += " " + commandAsAnArray[j];
                            }
                        }
                        article.author = newName1;
                        break;
                    case "Rename:":
                        string newName2 = String.Empty;
                        for (int j = 1; j < commandAsAnArray.Length; j++)
                        {
                            if (j == 1)
                            {
                                newName2 +=  commandAsAnArray[j];
                            }
                            else
                            {
                                newName2 += " " + commandAsAnArray[j];
                            }
                        }
                        article.title = newName2;
                        break;
                }
            }
            Console.WriteLine($"{article.title} - {article.content}: {article.author}");
        }
    }
}