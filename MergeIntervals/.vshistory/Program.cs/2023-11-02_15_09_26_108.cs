using System.Collections.Immutable;

namespace MergeIntervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t = Merge(Merge(new int[][]
             {


                new int[] {0,1 },
                 new int[] {1 , 5},
                //new int[] {15,18},
             }));
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
            return intervalsList.ToArray();
        }
    }
}
