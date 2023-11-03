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
            var sorred = QuickSort(nums.ToList());
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
        }
        public static void SortColors(int[] nums)
        {
            var numsList = QuickSort(nums.ToList());
        }
        public static  List<int> QuickSort(List<int> nums)
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
                    continue;
                }

                larger.Add(item);

            }
            smaller = QuickSort(smaller).ToList();
            larger = QuickSort(larger).ToList();
            return smaller.Concat(new List<int> { pivot }).Concat(larger).ToList();
        }
    }
}