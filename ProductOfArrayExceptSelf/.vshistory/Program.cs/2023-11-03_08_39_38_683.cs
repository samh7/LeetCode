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
            var outputArray = new List<int>();
            var leftArray = new List<int>();
            var rightArray = new List<int>();
            leftArray.Add(1);
            rightArray.Add(1);

            //for (int i = 1; i < N; i++)
            //{
            //    leftArray[i] = nums[i - 1] * leftArray[i - 1];
            //}
            //foreach(var t in leftArray)
            //{
            //    Console.WriteLine(t);
            //}
            return nums;
        }
    }
}