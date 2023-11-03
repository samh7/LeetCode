namespace MajorityElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public static int MajorityElement(int[] nums)
        {
            var len = nums.Length;
            var numsList = nums.ToList();
            for (int i = 0; i < len; i++)
            {
                numsList.RemoveAll(x => x == nums[i]);
                if (numsList.Count() < len / 2)
                {

                }
                    numsList = nums.ToList();
            }
            return 0;
        }
    }
}