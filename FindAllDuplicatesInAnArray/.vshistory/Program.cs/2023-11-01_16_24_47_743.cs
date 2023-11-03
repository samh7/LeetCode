namespace FindAllDuplicatesInAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = FindDuplicates(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 });
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        public static  IList<int> FindDuplicates(int[] nums)
        {
            HashSet<int> result = new HashSet<int>();
            bool isRepeatedAlready = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (result.Contains(nums[i]))
                {
                    if (isRepeatedAlready)
                    {
                        result.Remove(nums[i]);
                        continue;
                    }
                    result.Add(i);
                    isRepeatedAlready = true;
                }

            }
            return result.ToArray();
        }
    }
}