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
            var val2NewInterval = newInterval[0];
            while (index == -1)
            {
                index = intervalList.FindIndex((x, y) => x == );
            }
            var index = 0;
            return null;
        }
    }
}