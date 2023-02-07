namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[3];
            nums[0] = int.Parse(Console.ReadLine());
            nums[1] = int.Parse(Console.ReadLine());
            nums[2] = int.Parse(Console.ReadLine());

            Console.WriteLine(Subtract(nums));
        }
        static int Sum(int[] nums)
        {
            return nums[0] + nums[1];
        }
        static int Subtract(int[] nums)
        {
            return Sum(nums) - nums[2];
        }
    }
}