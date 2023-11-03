namespace SortColors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[]
            {
                12,123,1231,23,24,35,421,23,5,234,3123,1234,23,0,0,0,0,101,101,10,2020,1,1,1,2,2,2,2,23,3,3,3,3,3
            };
            SortColors(nums);
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
            //int[] n = new int[10];
            //n[0] = 1;
        }
        public static void SortColors(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;
        }
        public static void Merge(int[] nums, int start, int middle, int end)
        {
            if (start == end) return;
            if (start + 1 == end) return;
            var startNum = nums[start];
            var secondNum = nums[start + 1];
            if (nums[start] > nums[start + 1])
            {
                nums[start] = nums[start + 1];
                nums[start + 1] = startNum;
                Merge(nums, start + 1, middle, end);
            }
            Merge(nums, start + 1, middle, end);
        }
    }
}