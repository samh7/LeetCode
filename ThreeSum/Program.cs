using System.Linq;

namespace ThreeSum;
public class Program
{
    public static void Main(string[] args)
    {
        var result = ThreeSum(new int[] { -1, 0, 1, 2, -1, -4});
        foreach (var i in result)
        {
            foreach (var j in i)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("break!");
        }
        Console.WriteLine(result.Count);
    }
    static IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        List<int[]> result = new();
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i == 0 || nums[i] != nums[i - 1])
            {
                var low = i + 1;
                var high = nums.Length - 1;
                var sum = 0 - nums[i];
                while (low < high)
                {
                    if (nums[low] + nums[high] == sum)
                    {
                        result.Add(new int[] { nums[i], nums[low], nums[high] });
                        while (low < high && nums[low] == nums[low + 1]) low++;
                        while (low < high && nums[high] == nums[high - 1]) high--;
                        low++;
                        high--;
                    }
                    else if (nums[low] + nums[high] > sum)
                    {
                        high--;
                    }
                    else
                    {
                        low++;
                    }
            
                }
            }
        }
        return result.ToArray();
    }


    //public static IList<IList<int>> ThreeSum(int[] nums)
    //{
    //    Array.Sort(nums);
    //    var sums = new List<int[]>();
    //    var numsList = nums.ToList();
    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        numsList.RemoveAt(i);
    //        _ThreeSum(nums[i], numsList, i, sums);
    //        numsList = nums.ToList();
    //    }

    //    return sums.GroupBy(x => string.Join(",", x)).Select(x => x.First().ToArray()).ToArray();
    //}
    //public static void _ThreeSum(int currentNum, List<int> nums, int currentIndex, List<int[]> sums)
    //{
    //    int startIndex = 0, endIndex = nums.Count - 1;
    //    while (startIndex < endIndex)
    //    {
    //        if (nums[startIndex] + nums[endIndex] + currentNum == 0)
    //        {
    //            var sum = new int[] { nums[startIndex], currentNum, nums[endIndex] };
    //            Array.Sort(sum);
    //            sums.Add(sum);
    //        }
    //        startIndex++;
    //        while (startIndex < endIndex && (nums[startIndex] + nums[endIndex] + currentNum) < 0) startIndex++;
    //        while (startIndex < endIndex && (nums[startIndex] + nums[endIndex] + currentNum) > 0) endIndex--;
    //    }
    //    return;
    //}

}