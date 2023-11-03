namespace CountingSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static List<int> CountingSort(List<int> nums)
        {
            var largestNum = nums.Max(i => i);
            var smallestNum = nums.Min(i => i);
            var rangeOfNums = largestNum - smallestNum;
            var positionOfNums = new int[rangeOfNums];
            foreach (var item in nums)
            {
                positionOfNums[item]++;
            }
            for (int i = 1; i < rangeOfNums; i++)
            {
                positionOfNums[i] += positionOfNums[i - 1];
            }
            foreach (var item in positionOfNums)
            {
                Console.WriteLine(item);
            }
            return null;
        }
    }
}