using System.Collections.Immutable;

namespace MergeIntervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t = Merge(new int[][]
             {
                new int[] {1,4 },
                new int[] {0,2},
                //new int[] {8,10},
                //new int[] {15,18},
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
            for (int i = 0; i < intervalsList.Count - 1; i++)
            {
                if (intervalsList[i][0] < intervalsList[i + 1][0])
                {
                    if (intervalsList[i][1] < intervalsList[i + 1][0])
                    {
                        continue;
                    }
                    if (intervalsList[i][1] >= intervalsList[i + 1][1])
                    {
                        intervalsList.RemoveAt(i + 1);
                    }
                    else
                    {
                        intervalsList[i][1] = intervalsList[i + 1][1];
                        intervalsList.RemoveAt(i + 1);
                    }

                    continue;
                }

                if (intervalsList[i][0] == intervalsList[i + 1][0])
                {
                    if (intervalsList[i][1] >= intervalsList[i + 1][1])
                    {
                        intervalsList.RemoveAt(i + 1);
                    }
                    else
                    {
                        intervalsList[i][1] = intervalsList[i + 1][1];
                        intervalsList.RemoveAt(i + 1);
                    }
                    continue;
                }
                if (intervalsList[i][0] > intervalsList[i + 1][0])
                {
                    if (intervalsList[i][0] > intervalsList[i + 1][1])
                    {
                        //intervalsList[i][0] = intervalsList[i + 1][0];

                        continue;
                    }
                    if (intervalsList[i][1] > intervalsList[i + 1][1])
                    {
                        var temp = intervalsList[i];
                        intervalsList[i] = intervalsList[i + 1];
                        intervalsList[i + 1] = temp;
                    }
                    else if (intervalsList[i][1] == intervalsList[i + 1][1])
                    {
                        intervalsList[i][0] = intervalsList[i + 1][0];
                        intervalsList.RemoveAt(i + 1);
                    }
                    else
                    {
                        intervalsList[i][0] = intervalsList[i + 1][0];
                        intervalsList[i][1] = intervalsList[i + 1][1];
                        intervalsList.RemoveAt(i + 1);
                    }
                    continue;
                }

            }
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