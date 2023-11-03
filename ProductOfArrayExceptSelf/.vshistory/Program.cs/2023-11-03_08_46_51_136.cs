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
        }
        public static int[] ProductExceptSelf(int[] nums)
        {
            int N = nums.Length;
            var outputList = new List<int>();
            var leftList = new List<int>();
            var rightArray = new List<int>();
            leftList.Add(1);
            rightArray.Add(1);
            for (int i = 1; i < N; i++)
            {
                leftList.Add(nums[i - 1] * leftList[i - 1]);
                rightArray.Add(nums[N - i] * rightArray[i - 1]);
            }
            rightArray.Reverse();
            for (int i = 0; i < N; i++)
            {
                outputList.Add(leftList[i] * rightArray[i]);
            }
            return outputList.ToArray();
        }
    }
}