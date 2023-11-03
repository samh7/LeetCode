namespace MergeIntervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public static int[][] Merge(int[][] intervals, int[] newInterval)
        {
            var result = new List<int[]>();
            int len = intervals.Length;
            for (int i = 0; i < len; i++)
            {
                if (newInterval[1] < intervals[i][0])
                {
                    result.Add(newInterval);
                    return new List<int[]>(result).Concat(intervals[i..]).ToArray();
                }
            }
            return null;
        }
    }
}