namespace BestTimeToBuyAndSellStocks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
        }
        public static int BuyStocks(int[] nums)
        {
            int largest = int.MinValue;
            int smallestNum = nums[0];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                smallestNum = Math.Min(smallestNum, nums[i]);
                largest = Math.Max(largest, nums[i] - smallestNum);
            }
            return largest;
        }

    }

}