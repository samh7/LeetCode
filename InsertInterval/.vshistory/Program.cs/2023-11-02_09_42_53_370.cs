namespace InsertInterval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = insert(new int[][]
            {
                new int[] {1,2 },
                new int[] {3,5},
                new int[] {6,7},
                new int[] {8,10},
                new int[] {12,16},

            },
            new int[] { 4, 8 }
            );

            foreach (var item in result)
            {
                foreach (var item1 in item)
                {
                    Console.WriteLine(item1);
                }
                Console.WriteLine("break");
            }
        }
        public static int[][] insert(int[][] intervals, int[] newInterval)
        {
            var result = new List<int[]>();
            for (int i = 0; i < intervals.Length; i++)
            {
                if (newInterval[1] < intervals[i][0])
                {
                    result.Add(newInterval);
                    return new List<int[]>(result).Concat(intervals[i..]).ToArray();
                }
                else if (newInterval[0] > intervals[i][1])
                {
                    result.Add(intervals[i]);
                }
                else
                {
                    newInterval = new int[] { Math.Min(newInterval[0], intervals[i][0]), Math.Min(newInterval[1], intervals[i][1]) }
                    
                }
            }
            result.Add(newInterval);
            return result.ToArray();
        }
    }
}