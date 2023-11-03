namespace MergeIntervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public static int[][] Merge(int[][] intervals)
        {
            Array.Sort(intervals);
            var result = new List<int[]>();
            var intervalsList = intervals.ToList();
            int[] newInterval = new List<int>(intervalsList[0]).ToArray();
            while (0 < intervalsList.Count)
            {

                if (newInterval[1] < intervalsList[0][0])
                {
                    result.Add(newInterval);
                    return new List<int[]>(result).Concat(intervalsList).ToArray();
                }
                else if (newInterval[0] > intervalsList[0][1])
                {
                    result.Add(intervalsList[0]);
                }
                else
                {
                    newInterval = new int[] { Math.Min(newInterval[0], intervalsList[0][0]), Math.Max(newInterval[1], intervalsList[0][1]) };
                }
                result.Add(newInterval);

            }

            //for (int i = 0; i < len; i++)
            //{
            //    if (newInterval[1] < intervalsList[i][0])
            //    {
            //        result.Add(newInterval);
            //        return new List<int[]>(result).Concat(intervalsList[i..]).ToArray();
            //    }
            //    else if (newInterval[0] > intervalsList[i][1])
            //    {
            //        result.Add(intervalsList[i]);
            //    }
            //    else
            //    {
            //        newInterval = new int[] { Math.Min(newInterval[0], intervalsList[i][0]), Math.Max(newInterval[1], intervalsList[i][1]) };
            //    }
            //    result.Add(newInterval);
            //}
            return result.ToArray();
        }
    }
}