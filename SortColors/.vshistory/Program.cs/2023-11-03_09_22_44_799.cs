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
        }
        public static void SortColors(int[] nums)
        {

        }
        public static int[] _SortColors(int[] nums)
        {
            if (nums.Length < 2) return nums;
            int pivot = nums[0];
            var numsList = nums.ToList();
            numsList.RemoveAt(0);
            List<int> smaller = new List<int>();
            List<int> larger = new List<int>();
            foreach (var item in numsList)
            {
                if (item < pivot)
                {
                    smala
                }
            }
            return smaller.Concat(new int[] { pivot }).Concat(larger).ToArray();
        }
    }
}