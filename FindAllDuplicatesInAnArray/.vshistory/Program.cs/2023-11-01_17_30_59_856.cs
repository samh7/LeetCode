namespace FindAllDuplicatesInAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = FindDuplicates(new int[] { 100, 2, 5, 10, 9, 1, 1, 4, 3, 7 });
            Heelo(new int[] { 10, 2, 5, 10, 9, 1, 1, 4, 3, 7 });
        }

        public static void Heelo(int[] nums)
        {
            int i = 0;
            while (i < nums.Length)
            {
                if (nums[i] != nums[nums[i] - 1])
                {
                    var temp = nums[i];
                    nums[i] = nums[nums[i] - 1];
                    nums[nums[i] - 1] = temp;
                    i++;
                }
                else
                {
                    i++;
                }
            }
            foreach (var t in nums)
            {
                Console.WriteLine(t);
            }

        }
        public static IList<int> FindDuplicates(int[] nums)
        {

            int len = nums.Length;
            Array.Sort(nums);
            List<int> result = new() { };
            if (len < 3)
            {
                if (len < 2) return new List<int>();
                if (nums[0] == nums[1]) return new List<int> { nums[0] };
            }
            for (int i = 0; i < len - 1; i++)
            {

                if (nums[i] == nums[i + 1])
                {
                    if (len - i == 2)
                    {
                        result.Add(nums[i]);
                        continue;
                    }
                    if (nums[i] != nums[i + 2])
                    {
                        result.Add(nums[i]);
                    }

                }

            }
            return result;
        }
    }
}