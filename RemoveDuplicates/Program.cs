namespace RemoveDuplicates;

public class Program
{
    public static void Main(string[] args)
    {
        var t = RemoveDuplicates(new int[] { 1,1,2,2,3});
        foreach (var i in t)
        {
            Console.WriteLine(i);
        }
    }

    public static int[] RemoveDuplicates(int[] nums)
    {
        int total = 0;
        int currentNumber = int.MinValue;
        foreach (var x in nums)
        {
            if (currentNumber != x)
            {
                // Console.WriteLine(currentNumber);
                total++;
                nums[total - 1] = x;
            }
            currentNumber = x;
        }

        return nums;
    }
}