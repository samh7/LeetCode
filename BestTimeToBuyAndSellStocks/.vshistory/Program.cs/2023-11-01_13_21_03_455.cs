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
                largest = Math.Max(largest, nums[i + 1] - nums[i]);
            }
        }

    }

}