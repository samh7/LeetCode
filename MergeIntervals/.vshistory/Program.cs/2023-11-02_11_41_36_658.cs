using System.Collections.Immutable;

namespace MergeIntervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var t = Merge(new int[][]
            {
                new int[] {1,2 },
                new int[] {3,5},
                new int[] {6,7},
                new int[] {12,10},
                new int[] {8,16},
            });
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

            var result = new List<int[]>();
            var intervalsList = intervals.ToList();
            while (0 < intervalsList.Count)
            {
                int[] newInterval = new List<int>(intervalsList[0]).ToArray();
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
                    intervalsList.RemoveAt(0);
                    continue;
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