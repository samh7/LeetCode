namespace SortColors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public static void SortColors(int[] nums)
        {
            int pivot = nums[0];
            SortColors(nums.TakeWhile(x => x <= pivot).ToArray());
        }
    }
}