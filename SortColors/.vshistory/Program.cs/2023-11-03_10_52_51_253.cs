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

        }
        public static void SortColors(int[] nums)
        {
            var numsList = QuickSort(nums.ToList());
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = numsList[i];
            }
        }


        public static int[][] Split(List<int> nums)
        {
            int middle = nums.Count / 2;
            return new int[][]
            {
               nums.Take(middle).ToArray()
            ,
            nums.ToArray()

            };
        }


        public static List<int> QuickSort(List<int> nums)
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