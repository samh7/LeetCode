namespace FindAllDuplicatesInAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = FindDuplicates(new int[] { 10, 2, 5, 10, 9, 1, 1, 4, 3, 7 });
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        public static IList<int> FindDuplicates(int[] nums)
        {
            int len = nums.Length;
            Array.Sort(nums);
            foreach (var item in nums)
            {
                //Console.WriteLine(item);
            }
            List<int> result = new() { };
            if (len < 3)
            {
                if (len < 2) return new List<int>();
                if (nums[0] == nums[1]) return new List<int> { nums[0] };
            }
            for (int i = 0; i < len; i++)
            {
                if (i + 2 < len)
                {
                    if (nums[i] == nums[i + 1])
                    {
                        result.Add(nums[i]);
                    }
                }
            }
            return result;
        }
    }
}