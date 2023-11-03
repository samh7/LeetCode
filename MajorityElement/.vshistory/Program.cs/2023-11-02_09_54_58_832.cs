namespace MajorityElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MajorityElement(new int[] {3,2,3}));
        }
        public static int MajorityElement(int[] nums)
        {
            var len = nums.Length;
            var numsList = nums.ToList();
            for (int i = 0; i < len; i++)
            {
                numsList.RemoveAll(x => x == nums[i]);
                Console.WriteLine(numsList.Count);
                if (numsList.Count() < len / 2)
                {
                    return nums[i];
                }
                numsList = nums.ToList();
            }
            return 0;
        }
    }
}