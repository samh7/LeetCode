namespace InsertInterval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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
                if(val1Intervals < val1NewInterval)
                {
                    val1NewInterval--;
                }
                if (val2Intervals < val2NewInterval)
                {
                    val1NewInterval--;
                }
            }
            var index = 0;
            return null;
        }
    }
}