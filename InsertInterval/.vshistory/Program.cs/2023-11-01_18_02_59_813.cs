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
            var intervalsCopy = new List<int[]>(intervals).ToArray();
            return null;
        }
    }
}