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
            foreach (var num in numsList)
            {
                numsList.Remove(num);

            }
        }
    }
}