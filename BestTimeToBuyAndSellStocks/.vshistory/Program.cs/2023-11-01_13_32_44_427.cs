namespace BestTimeToBuyAndSellStocks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 7, 1, 5, 3, 6, 4 };
            var maxProfit = MaxProfit(nums);
            Console.WriteLine(maxProfit);
        }
        public static int MaxProfit(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int maxProfit = int.MinValue;
            int smallestNum = int.MaxValue;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                smallestNum = Math.Min(smallestNum, nums[i]);
                maxProfit = Math.Max(maxProfit, nums[i] - smallestNum);
            }
            return maxProfit;
        }

    }

}