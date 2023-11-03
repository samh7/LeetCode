namespace SortColors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[]
            {
                12,123,1231,23,24,35,421,23,5,234,3123,1234,23,
            };
            SortColors(nums);
        }
        public static void SortColors(int[] nums)
        {
            if(nums.Length < 2) return;
            int pivot = nums[0];
            SortColors(nums.TakeWhile(x => x <= pivot).ToArray());
            SortColors(nums.TakeWhile(x => x > pivot).ToArray());
        }
    }
}