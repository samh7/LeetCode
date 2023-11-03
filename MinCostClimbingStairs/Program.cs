public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(MinCostClimbingStairs(new int[] { 10, 15, 20}));
    }

    public static int MinCostClimbingStairs(int[] cost)
    {
        List<int> nums = cost.ToList();
        int start = 0;
        bool skip = false;
        int totalCost = 0;

        while (nums.Count > 2)
        {
            if (!skip)
            {
                if (nums[1] < nums[0])
                {
                    totalCost += nums[1];
                    nums.RemoveAt(0);
                    nums.RemoveAt(0);
                    skip = true;
                }
                else
                {
                    totalCost += nums[0];
                    nums.RemoveAt(0);
                    skip = false;
                }
            }
            else
            {
                totalCost += nums[0];
                nums.RemoveAt(0);
                skip = false;
            }
        }

        return totalCost;
    }
}