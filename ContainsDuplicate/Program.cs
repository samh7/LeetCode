namespace ContainsDuplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContainsDuplicate(new int[] {1,2,3,1}));
        }
        public static bool ContainsDuplicate(int[] nums)
        {
            Array.Sort(nums);
            for(int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    return true;
                }
            }
            return false;
        }
    }
}