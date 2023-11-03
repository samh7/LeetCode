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
            _SortColors(ref nums, 0);
        }
        public static void _SortColors(ref int[] nums, int startIndex)
        {
            if (nums.Length < 2) return;
            int pivot = nums[i];
            List<int> smaller = new List<int>();
            List<int> larger = new List<int>();
            for (int i = startIndex; i < nums.Length; i++)
            {
                if (nums[i] < pivot)
                {
                    smaller.Add(nums[i]);
                    continue;
                }
                larger.Add(nums[i]);
            }

            //smaller = _SortColors(smaller).ToList();
            //larger = _SortColors(larger).ToList();
            //return smaller.Concat(new List<int> { pivot }).Concat(larger).ToList();
        }
    }
}