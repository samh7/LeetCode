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
            //foreach (int i in nums)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(nums.Length + " length");
            SortColors(nums);
            foreach (int i in nums)
            {
                //Console.WriteLine(i);
            }
            Console.WriteLine(nums.Length + " length");
        }
        public static void SortColors(int[] nums)
        {
            var numsList = new List<int>(nums);
            int start = 0;
            int middle = nums.Length / 2;
            int end = nums.Length - 1;
            Merge(nums, start, middle, end);
            if(Compare(nums,numsList) == false)
            {
                //Console.WriteLine("True");
                Merge(nums, start, middle, end);
            }
        }
        public static void Merge(int[] nums, int start, int middle, int end)
        {
            if (start == end) return;
            if (middle == end) return;
            var startNum = nums[start];
            var middleNum = nums[middle];
            if (startNum > middleNum)
            {
                nums[start] = middleNum;
                nums[middle] = startNum;
                Merge(nums, start, middle + 1, end);
            }
            Merge(nums, start + 1, middle, end);
        }
        public static bool Compare(int[] nums1, List<int> nums2)
        {
            if (nums1.Length != nums2.Count) return false;
            for (int i = 0; i < nums1.Length; i++)
            {
                if (nums1[i] != nums2[i]) return false;
            }
            return true;
        }
    }
}