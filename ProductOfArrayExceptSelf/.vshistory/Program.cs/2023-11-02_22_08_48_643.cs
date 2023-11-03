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
                Console.WriteLine(iterator);
            }
        }
        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];
            var numsList = nums.ToList();
            int len = numsList.Count;
            for (int i = 0; i < len; i++)
            {
                numsList.Remove(numsList[i]);
                result[i] = numsList.Aggregate((x, y) => x * y);
                numsList.Append(numsList[i]);
            }
            return result;
        }
    }
}