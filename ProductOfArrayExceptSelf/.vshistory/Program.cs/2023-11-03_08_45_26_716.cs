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
            var outputArray = new List<int>();
            var leftArray = new List<int>();
            var rightArray = new List<int>();
            leftArray.Add(1);
            rightArray.Add(1);

            for (int i = 1; i < N; i++)
            {
                leftArray.Add(nums[i - 1] * leftArray[i - 1]);
                rightArray.Add(nums[N - i] * rightArray[i - 1]);
            }
            rightArray.Reverse();

            return nums;
        }
    }
}