public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Rob(new int[]{1,2,3,1}));
    }

    public static int Rob(int[] nums)
    {
        int len = nums.Length;
        int[] memo = new int[len + 1];
        memo[0] = 0;
        memo[1] = nums[0];
        for (int i = 1; i < len; i++)
        {
            memo[i + 1] = Math.Max(memo[i], memo[i - 1] + nums[i]);
        }

        return memo[len];
    }
}