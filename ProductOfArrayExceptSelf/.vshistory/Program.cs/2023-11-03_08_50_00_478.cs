namespace ProductOfArrayExceptSelf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[]
            {
                4,5,1,8,2

            };
            var result = ProductExceptSelf(nums);
            foreach(var t in result)
            {
                Console.WriteLine(t);
            }
        }
        public static int[] ProductExceptSelf(int[] nums)
        {
            int len = nums.Length;
            var outputList = new List<int>();
            var leftList = new List<int>();
            var rightList = new List<int>();
            leftList.Add(1);
            rightList.Add(1);
            for (int i = 1; i < len; i++)
            {
                leftList.Add(nums[i - 1] * leftList[i - 1]);
                rightList.Add(nums[len - i] * rightList[i - 1]);
            }
            rightList.Reverse();
            for (int i = 0; i < len; i++)
            {
                outputList.Add(leftList[i] * rightList[i]);
            }
            return outputList.ToArray();
        }
    }
}