using System.Collections.Immutable;

namespace MergeIntervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[][]
             {

                new int[] {0,1 },
                 new int[] {1 , 5},
                new int[] {15,18},
                                new int[] {11,18},
                                                new int[] {2,18},
                                                new int[] {3,18},
                                                new int[] {4,18},
                                                new int[] {9,18},
                                                new int[] {10,18},
                                                                new int[] {17,18},
                                                                new int[] {17,18},
             };
            var t = Merge(nums);


            Console.WriteLine(nums.Length);
            Console.WriteLine(t.Length);
            foreach (var item in t)
            {
                foreach (var item1 in item)
                {
                    Console.WriteLine(item1);
                }
                Console.WriteLine("break");
            }
        }

        public static int[][] Merge(int[][] intervals)
        {
            var newIntervals = SortIntervals(intervals);
            for (int i = 0; i < newIntervals.Count - 1; i++)
            {
                while (newIntervals[i][1] >= newIntervals[i + 1][0])
                {
                    if (newIntervals[i][1] > newIntervals[i + 1][1])
                    {
                        newIntervals.RemoveAt(i + 1);
                    }
                    else
                    {
                        newIntervals[i][1] = newIntervals[i + 1][1];
                        newIntervals.RemoveAt(i + 1);
                    }
                }
            }

            return newIntervals.ToArray();
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
    }
}
