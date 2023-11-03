namespace ContainsDuplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public static bool ContainsDuplicate(int[] nums)
        {
            Array.Sort(nums);
            for(int i = 0; i < nums.Length; i++)
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