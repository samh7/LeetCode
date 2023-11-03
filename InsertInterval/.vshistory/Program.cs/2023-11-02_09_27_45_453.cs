namespace InsertInterval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            insert(new int[][] { new int[] { 1, 2 }, new int[] { 6, 7 }, new int[] { 8, 9, } }, new int[] { 12, 4 });
        }
        public static int[][] insert(int[][] intervals, int[] newInterval)
        {
            var result = new List<int[]>();
            for(int i = 0; i < intervals.Length; i++)
            {
                if (newInterval[1] > intervals[i][0])
                {

                }
            }
            return null;
        }
    }
}