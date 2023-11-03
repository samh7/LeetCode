namespace SortColors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[]
            {
                12,123,1231,23,24,35,421,23,
            };
            var sorted = MergeSort(nums.ToList());
        }
        public static void SortColors(int[] nums)
        {
            var sorted = MergeSort(nums.ToList());
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = sorted[i];
            }
        }

        public static List<int> MergeSort(List<int> nums)
        {
            if (nums.Count < 2) return nums;
            int len = nums.Count;
            int middle = len / 2;
            var split = Split(nums, middle, len);
            return Merge(MergeSort(split[0]), MergeSort(split[1]));

        }
        public static List<int> Merge(List<int> numsLeft, List<int> numsRight)
        {
            if (numsRight.Count == 0) return numsLeft;
            if (numsLeft.Count == 0) return numsRight;
            var firstLeft = numsLeft[0];
            var firstRight = numsRight[0];
            if (firstLeft < firstRight)
            {
                numsLeft.RemoveAt(0);
                return new List<int> { firstLeft }.Concat(Merge(numsLeft, numsRight)).ToList();
            }
            numsRight.RemoveAt(0);
            return new List<int> { firstRight }.Concat(Merge(numsLeft, numsRight)).ToList();
        }
        public static List<List<int>> Split(List<int> nums, int middle, int len)
        {
            return new List<List<int>>
            {
               nums.GetRange(0,middle).ToList(),
               nums.GetRange(middle, (len - middle)).ToList()

            };
        }
    }
}