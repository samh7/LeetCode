namespace TwoSum;
public class Program
{
    public static void Main(string[] args)
    {
        var r = TwoSum(new int[] { 2, 7, 11, 15 }, 9);
        Console.WriteLine(r[0]);
        Console.WriteLine(r[1]);
    }
    public static int[] TwoSum(int[] nums, int target)
    {
        var numsList = nums.ToList();
        Array.Sort(nums);
        int startIndex = 0, endIndex = nums.Length - 1;
        while (startIndex < endIndex)
        {
            if (nums[startIndex] + nums[endIndex] == target)
            {
                return new int[] { numsList.IndexOf(nums[startIndex]), numsList.LastIndexOf(nums[endIndex]) };
            }
            while (nums[startIndex] + nums[endIndex] < target) startIndex++;
            while (nums[startIndex] + nums[endIndex] > target) endIndex--;
        }
        return new int[] { };
    }
}