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
            int largest = nums[1] - nums[0];
            int smallestNum = nums[0];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                smallestNum = Math.Min(smallestNum, nums[i]);
                largest = Math.Max(largest, nums[i] - smallestNum);
            }
        }

    }

}