using System.Runtime.Serialization.Formatters;

namespace asdf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            while (nums.Count > 1)
            {
                int[] fakeArray = new int[nums.Count - 1];
                List<int> sum = fakeArray.ToList();
                for (int i = 0; i < nums.Count - 1; i++)
                {
                    sum[i] = nums[i] + nums[i + 1];
                }
                nums = sum;
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}