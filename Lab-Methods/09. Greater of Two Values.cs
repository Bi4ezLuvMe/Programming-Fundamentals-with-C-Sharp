using System.Text;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input=Console.ReadLine();
            Console.WriteLine(Output(input));
        }
        static string Output(string input)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            switch (input)
            {
                case "int":
                    int A=int.Parse(a);
                    int B=int.Parse(b);
                    if (A > B)
                    {
                        return a;
                    }
                    else
                    {
                        return b;
                    }
                case "char":
                    char A1=char.Parse(a);
                    char B1=char.Parse(b);
                    if (A1 > B1)
                    {
                        return a;
                    }
                    else
                    {
                        return b;
                    }
                case "string":
                   int A69= String.Compare(a,b);
                    if (A69 == 1)
                    {
                        return a;
                    }
                    else if (A69 == -1)
                    {
                        return b;
                    }
                    break;
            }
            return "gay";
        }
    }
}