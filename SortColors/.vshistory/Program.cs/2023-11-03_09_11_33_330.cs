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
            int[] smaller = quickSort(nums.TakeWhile(x => x <= pivot).ToArray());
        }
    }
}