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
        public static int[][] Merge(int[][] intervals, int[][] )
        {
            int len1 = -1;
            int len2 = 0;
            //while(len != 0)
            //{
            //}
            return _Merge(intervals);
        }
        public static int[][] Merge(int[][] intervals)
        {
            var intervalsList = intervals.ToList();
            return intervalsList.ToArray();
        }
    }
}




//if (intervalsList[i][0] > intervalsList[i + 1][0])
//{
//    if (intervalsList[i][1] > intervalsList[i + 1][1])
//    {
//        var temp = intervalsList[i];
//        intervalsList[i] = intervalsList[i + 1];
//        intervalsList[i + 1] = temp;
//        continue;
//    }
//    intervalsList[i][0] = intervalsList[i + 1][0];
//    intervalsList[i][1] = intervalsList[i + 1][1];
//    intervalsList.RemoveAt(i + 1);
//    continue;
//}