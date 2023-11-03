namespace ProductOfArrayExceptSelf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[]
            {
                
            };
            var result = ProductExceptSelf(nums);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
        }
        public static int[] ProductExceptSelf(int[] nums)
        {
            int N = nums.Length;
            int[] outputArray = new int[N];
            int[] leftArray = new int[N];
            int[] rightArray = new int[N];

            leftArray[0] = 1;
            rightArray[0] = 1;
            for (int i = 1; i < N - 1; i++)
            {
                leftArray[i] = nums[i - 1] * leftArray[i - 1];
            }
            foreach(var t in leftArray)
            {
                Console.WriteLine(t);
            }
            return nums;
        }
    }
}