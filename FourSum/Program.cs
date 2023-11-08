using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        //var nums = new int[] { 1, 0, -1, 0, -2, 2, 9, 2, 3, 4, 1, 0, -1, 0, -2, 2, 9, 2, 3, 4, 1, 0, -1, 0, -2, 2, 9, 2, 3, 4, 1, 0, -1, 0, -2, 2, 9, 2, 3, 4, 1, 0, -1, 0, -2, 2, 9, 2, 3, 4, 1, 0, -1, 0, -2, 2, 9, 2, 3, 4, 1, 0, -1, 0, -2, 2, 9, 2, 3, 4, 1, 0, -1, 0, -2, 2, 9, 2, 3, 4, 1, 0, -1, 0, -2, 2, 9, 2, 3, 4, 1, 0, -1, 0, -2, 2, 9, 2, 3, 4, 1, 0, -1, 0, -2, 2, 9, 2, 3, 4, 1, 0, -1, 0, -2, 2, 9, 2, 3, 4, 1, 0, -1, 0, -2, 2, 9, 2, 3, 4, 1, 0, -1, 0, -2, 2, 9, 2, 3, 4, 1, 0, -1, 0, -2, 2, 9, 2, 3, 4, 1, 0, -1, 0, -2, 2, 9, 2, 3, 4, 1, 0, -1, 0, -2, 2, 9, 2, 3, 4, 1, 0, -1, 0, -2, 2, 9, 2, 3, 4, 1, 0, -1, 0, -2, 2, 9, 2, 3, 4, 1, 0, -1, 0, -2, 2, 9, 2, 3, 4, };
        var nums = new int[] { 1000000000, 1000000000, 1000000000, 1000000000 };
        var sums = FourSum(nums, -294967296);
        foreach (var i in sums)
        {
            foreach (var j in i)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("break");
            //}
            decimal num = -294967296;
            num -= 2000000000;

            Console.WriteLine(num + 2000000000);
        }
    }
        public static IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);
            List<int[]> sums = new();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    TwoSum(nums, (decimal)target - nums[i] - nums[j], sums, j + 1, nums.Length - 1, nums[i], nums[j]);
                }

            }
            return sums.GroupBy(x => string.Join(",", x)).Select(x => x.First()).ToArray();
        }
        public static void TwoSum(int[] nums, decimal target, List<int[]> sums, int startIndex, int endIndex, int first, int second)
        {
            var numsList = nums.ToList();
            Array.Sort(nums);
            while (startIndex < endIndex)
            {
                if (startIndex < endIndex && nums[startIndex] + nums[endIndex] == target)
                {
                    sums.Add(new int[] { first, second, nums[startIndex], (nums[endIndex]) });
                    startIndex++;
                    endIndex--;
                }
                while (startIndex < endIndex && nums[startIndex] + nums[endIndex] < target) startIndex++;
                while (startIndex < endIndex && nums[startIndex] + nums[endIndex] > target) endIndex--;
            }

        }
    }