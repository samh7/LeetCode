namespace CountingSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new List<int>()
            {
                2,5,1,0
            };
            CountingSort(nums);

        }

        public static List<int> CountingSort(List<int> nums)
        {
            var largestNum = nums.Max(i => i);
            var smallestNum = nums.Min(i => i);
            var rangeOfNums = largestNum - smallestNum;
            var positionOfNums = new int[rangeOfNums];
            for (int i = 0; i < rangeOfNums; i++)
            {
                positionOfNums[i] = 0;
            }
            foreach (var item in nums)
            {
                Console.WriteLine(item - smallestNum);
            }
            //for (int i = 1; i < rangeOfNums; i++)
            //{
            //    positionOfNums[i] += positionOfNums[i - 1];
            //}
            //foreach (var item in positionOfNums)
            //{
            //    Console.WriteLine(item);
            //}
            return null;
        }
    }
}