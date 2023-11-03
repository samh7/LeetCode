namespace InsertInterval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            insert(new int[][] { new int[] { 1, 2, 3, 3 }, new int[] { 4, 5, 6, 7 }, new int[] { 8, 9, } }, new int[] { 12, 4 });
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
                if (index == -1)
                {
                    if (intervalList[0][0] > val1NewInterval)
                    {
                        val1NewInterval++;
                    }
                    if (intervalList[0][1] > val2NewInterval)
                    {
                        val2NewInterval++;
                    }

                    if (intervalList[0][0] < val1NewInterval)
                    {
                        val1NewInterval--;
                    }
                    if (intervalList[0][1] < val2NewInterval)
                    {
                        val2NewInterval--;
                    }
                }
            }
            Console.WriteLine(index);
            return null;
        }
    }
}