namespace ProductOfArrayExceptSelf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[]
            {
                -1,-1,0,-3,3
            };
            var result = ProductExceptSelf(nums);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];
            var numsList = nums.ToList();

            for (int i = 0; i < nums.Length; i++)
            {
                numsList.RemoveAt(i);
                result[i] = numsList.Aggregate((x, y) => x * y);
                numsList = nums.ToList();
            }
            return result;
        }
    }
}