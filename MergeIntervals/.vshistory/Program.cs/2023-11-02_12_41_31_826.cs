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
            var intervalsList = intervals.ToList();
            return null;
        }
    }
}