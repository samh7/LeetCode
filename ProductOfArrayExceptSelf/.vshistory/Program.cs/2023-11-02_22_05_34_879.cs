namespace ProductOfArrayExceptSelf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];
            var numsList = nums.ToList();
            int len = numsList.Count;
            for (int i = 0; i < len; i++)
            {
                numsList.Remove(num);
                result
            }
            return result;
        }
    }
}