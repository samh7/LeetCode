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
            for (int i = 0; i < intervals.Length; i++)
            {
                if (intervals[i][0] == newInterval[0] || intervals[i][1] == newInterval[1])
                {

                }

            }
            return null;
        }
    }
}