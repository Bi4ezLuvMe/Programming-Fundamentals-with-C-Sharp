namespace asdf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                
                if(input == "(")
                {
                    count1++;
                  
                }else if(input == ")")
                {
                    count2++;
                    if (count1 - count2 != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
            }
            if (count1 == count2)
            {
                Console.WriteLine("BALANCED");
            }
            else if(count1 !=count2)
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}