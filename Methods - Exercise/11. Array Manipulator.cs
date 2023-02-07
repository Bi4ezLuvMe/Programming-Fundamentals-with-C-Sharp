using System.Globalization;
using System.Linq.Expressions;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string input = string.Empty;

            string[] command;

            while (true)
            {
                input = Console.ReadLine();

                if (input == "end")
                {
                    Console.Write($"[{String.Join(", ", numbers)}]");
                    break;
                }

                command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0] == "exchange")
                {

                    int n = int.Parse(command[1]);

                    if (n >= 0 && n < numbers.Length)
                    {
                        numbers = RotateArrayByGivenN(numbers, n);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command[0] == "max")
                {
                    PrintTheIndexOfTheMaxOddOrEvenNumberInArray(numbers, command[1]);
                }
                else if (command[0] == "min")
                {
                    PrintTheIndexOfTheMinOddOrEvenNumberInArray(numbers, command[1]);
                }
                else if (command[0] == "first")
                {
                    PrintTheFirstNOddOrEvenNumbersInArray(numbers, int.Parse(command[1]), command[2]);
                }
                else if (command[0] == "last")
                {
                    PrintTheLastNOddOrEvenNumbersInArray(numbers, int.Parse(command[1]), command[2]);
                }
            }
        }
        static int[] RotateArrayByGivenN(int[] numbers, int num)
        {
            int[] newarr = new int[numbers.Length];
            int n = num + 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (n >= numbers.Length)
                {
                    n = 0;
                }
                newarr[i] = numbers[n];
                n++;
            }
            return newarr;
        }
        static void PrintTheIndexOfTheMaxOddOrEvenNumberInArray(int[] numbers, string n)
        {
            if (n == "odd")
            {
                if (numbers.Any(x => x % 2 == 1))
                {
                    int maxOdd = numbers.Where(x => x % 2 == 1).Max();

                    var intdexOfMaxOdd = numbers.ToList().LastIndexOf(maxOdd);

                    Console.WriteLine(intdexOfMaxOdd);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            if (n == "even")
            {
                if (numbers.Any(x => x % 2 == 0))
                {
                    int maxEven = numbers.Where(x => x % 2 == 0).Max();

                    var intdexOfMaxEven = numbers.ToList().LastIndexOf(maxEven);

                    Console.WriteLine(intdexOfMaxEven);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }
        static void PrintTheIndexOfTheMinOddOrEvenNumberInArray(int[] numbers, string n)
        {
            if (n == "odd")
            {
                if (numbers.Any(x => x % 2 == 1))
                {
                    int minOdd = numbers.Where(x => x % 2 == 1).Min();

                    var intdexOfMinOdd = numbers.ToList().LastIndexOf(minOdd);

                    Console.WriteLine(intdexOfMinOdd);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            if (n == "even")
            {
                if (numbers.Any(x => x % 2 == 0))
                {
                    int minEven = numbers.Where(x => x % 2 == 0).Min();

                    var intdexOfMinEven = numbers.ToList().LastIndexOf(minEven);

                    Console.WriteLine(intdexOfMinEven);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }
        static void PrintTheFirstNOddOrEvenNumbersInArray(int[] numbers, int n, string oddEven)
        {
            if (n > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            List<int> sequence = new List<int>();

            if (oddEven == "odd")
            {
                if (numbers.Any(x => x % 2 == 1))
                {
                    sequence = numbers.Where(x => x % 2 == 1).ToList();
                }
            }
            else if (oddEven == "even")
            {
                if (numbers.Any(x => x % 2 == 0))
                {
                    sequence = numbers.Where(x => x % 2 == 0).ToList();
                }
            }

            Console.WriteLine($"[{String.Join(", ", sequence.Take(Math.Min(n, sequence.Count)).ToList())}]");
        }
        static void PrintTheLastNOddOrEvenNumbersInArray(int[] numbers, int n, string oddEven)
        {
            if (n > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            List<int> sequence = new List<int>();

            if (oddEven == "odd")
            {
                if (numbers.Any(x => x % 2 == 1))
                {
                    sequence = numbers.Where(x => x % 2 == 1).ToList();
                }
            }
            else if (oddEven == "even")
            {
                if (numbers.Any(x => x % 2 == 0))
                {
                    sequence = numbers.Where(x => x % 2 == 0).ToList();
                }
            }
            Console.WriteLine($"[{String.Join(", ", sequence.TakeLast(Math.Min(n, sequence.Count)).ToList())}]");
        }
    }
}