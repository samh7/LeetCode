namespace InsertInterval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            insert(new int[][] {new int[] {1,2,3,3}, new int[] {4,5,6,7}, new int[] {8,9,} }, new int[] {12,4});
        }
        public static int[][] insert(int[][] intervals, int[] newInterval)
        {
            var index = -1;
            var intervalList = intervals.ToList();
            var val1NewInterval = newInterval[0];
            var val2NewInterval = newInterval[1];
            while (index == -1)
            {
                index = intervalList.FindIndex((x) => x[0] == val1NewInterval
                || x[1] == val2NewInterval);
                var val1Intervals = intervalList[0][0];
                var val2Intervals = intervalList[0][1];
                if (val1Intervals < val1NewInterval)
                {
                    val1NewInterval--;
                }
                if (val2Intervals < val2NewInterval)
                {
                    val2NewInterval--;
                }
                if (val1Intervals > val1NewInterval)
                {
                    val1NewInterval++;
                }
                if (val2Intervals > val2NewInterval)
                {
                    val2NewInterval++;
                }
                intervalList.RemoveAt(0);
            }
            Console.WriteLine(index);
            return null;
        }
    }
}