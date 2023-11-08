public class Program
{
    public static void Main(string[] args)
    {
        var nums = new int[][]
        {
            new int[] {1,1},
            new int[] {3,7},
            new int[] {2,12},
            new int[] {7,17},

        };
        Console.WriteLine(HardestWorker(450, nums));

    }


    public static int HardestWorker(int n, int[][] logs)
    {
        int max = logs[0][1];
        int maxId = logs[0][0];
        for (int i = 1; i < logs.Length; i++)
        {
            var maxCp = max;
            var newMax = logs[i][1] - logs[i - 1][1];
            if (newMax > max)
            {
                max = newMax;
                maxId = logs[i][0];
            }
            else if (newMax == max)
            {
                if (logs[i][0] < maxId)
                {
                    maxId = logs[i][0];
                }
            }
        }

        return maxId;
    }

    //Second implementation of hardworker

    //      if (logs.Length == 0 || logs.Max(x => x[0]) >= n) return -1;
    //        if (logs.Length == 1) { return logs[0][0]; }
    //List<int> keys = logs.ToList().DistinctBy(x => x[0]).Select(x => x[0]).ToList();
    //keys.Sort();
    //Dictionary<int, int> numsMap = new Dictionary<int, int>();

    //for (int i = 0; i < keys.Count; i++)
    //{
    //    numsMap.Add(keys[i], 0);
    //}
    //numsMap[logs[0][0]] = logs[0][1];
    //for (int i = 1; i < logs.Length; i++)
    //{
    //    numsMap[logs[i][0]] = Math.Max(numsMap[logs[i][0]], logs[i][1] - logs[i - 1][1]);

    //}
    //var max = numsMap.Max(x => x.Value);
    //return numsMap.First(x => x.Value == max).Key;
}