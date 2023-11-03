namespace BestTimeToBuyAndSellStocks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
        }
        public static void BuyStocks(int[] nums)
        {
            int largest = int.MaxValue;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                var firstNum = Math.Min(largest, nums[i]);
                if (nums[i] < firstNum)
                {
                    largest = Math.Max(largest, nums[i + 1] - nums[i]);
                }
            }
        }

    }

}