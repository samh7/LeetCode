namespace FindAllDuplicatesInAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = FindDuplicates(new int[] { 1, 1 });
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        public static IList<int> FindDuplicates(int[] nums)
        {
            Array.Sort(nums);
            List<int> result = new() { };
            if (result.Count == 2) if (nums[0] == nums[1]) return new List<int> { nums[0] };
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] == nums[i + 1] && nums[i] != nums[i + 2])
                {
                    result.Add(nums[i]);
                }
            }
            return result;
        }
    }
}