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
            var sorted = _SortColors(nums);
            foreach (int i in sorted)
            {
                Console.WriteLine(i);
            }
            //int[] n = new int[10];
            //n[0] = 1;
        }
        public static void SortColors(int[] nums)
        {

        }
        public static List<int> _SortColors(List<int> nums)
        {
            if (nums.Count < 2) return nums;
            int pivot = nums[0];
            nums.RemoveAt(0);
            List<int> smaller = new List<int>();
            List<int> larger = new List<int>();
            foreach (var item in nums)
            {
                if (item < pivot)
                {
                    smaller.Add(item);
                }
                else
                {
                    larger.Add(item);
                }
            }
            smaller = _SortColors(smaller).ToList();
            larger = _SortColors(larger).ToList();
            return smaller.Concat(new List<int> { pivot }).Concat(larger).ToList();
        }
    }
}