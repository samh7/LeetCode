namespace BestTimeToBuyAndSellStocks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 7, 1, 5, 3, 6, 4 };
            var maxProfit = BuyStocks(nums);
            Console.WriteLine(maxProfit);
        }
        public static int BuyStocks(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int largest = int.MinValue;
            int smallestNum = int.MaxValue;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                smallestNum = Math.Min(smallestNum, nums[i]);
                largest = Math.Max(largest, nums[i] - smallestNum);
            }
            return largest;
        }

    }

}