using System.Collections.Immutable;

namespace MergeIntervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[][]
             {

                new int[] {2,3 },
                 new int[] {4,5},
                new int[] {6,7},
                new int[] {8,9},
                new int[] {1,10},
             };
            var t = Merge(nums);
            if (t != null)
            {
                foreach (var item in t)
                {
                    if (item != null)
                    {
                        foreach (var item1 in item)
                        {
                            Console.WriteLine(item1);
                        }
                        Console.WriteLine("break");
                    }
                }
            }
        }

        public static int[][] Merge(int[][] intervals)
        {
            var sortedIntevals = SortIntervals(intervals);

            return sortedIntevals.ToArray();
        }

        public static List<int[]> SortIntervals(int[][] intervals)
        {
            var intervalsDict = new Dictionary<int, int>();
            List<int> keys = new List<int>();
            for (int i = 0; i < intervals.Length; i++)
            {
                if (intervalsDict.ContainsKey(intervals[i][0]))
                {
                    var valueAtI = intervalsDict[intervals[i][0]];
                    if (valueAtI < intervals[i][1])
                    {
                        intervalsDict[intervals[i][0]] = intervals[i][1];
                    }
                    continue;
                }
                keys.Add(intervals[i][0]);
                intervalsDict.Add(intervals[i][0], intervals[i][1]);
            }

            keys.Sort();
            var intervalsList = new List<int[]>();
            int j = 0;
            while (j < keys.Count)
            {
                int val;
                var isAdded = intervalsDict.TryGetValue(keys[j], out val);
                if (isAdded)
                {
                    intervalsList.Add(new int[] { keys[j], val });
                }
                keys.RemoveAt(j);
            }

            return intervalsList;
        }

        //public static List<int> GetDuplicates(int[][] nums)
        //{
        //    var result = new List<int>();

        //    foreach (var item in nums)
        //    {
        //        if (item[0] == item[1])
        //        {
        //            result.Add(item[1]);
        //        }
        //    }
        //    return result;
        //}


    }
}






