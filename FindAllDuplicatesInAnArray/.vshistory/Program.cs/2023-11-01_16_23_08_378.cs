namespace FindAllDuplicatesInAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public IList<int> FindDuplicates(int[] nums)
        {
            HashSet<int> result = new HashSet<int>();
            bool isRepeatedAlready = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (result.Contains(nums[i]))
                {
                    if (isRepeatedAlready)
                    {

                    }
                    isRepeatedAlready = true;
                }
            }
            return null;
        }
    }
}