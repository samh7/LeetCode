using System.Linq;
namespace HardestWorker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] logs = new int[][]
            {
                new int[]{0,1},
                new int[]{1,2},
                new int[]{3,4},
                new int[]{2,5},
                new int[]{5,6},
                new int[]{0,7}
            };
            //HardestWorker(4, logs);

            Console.WriteLine(HardestWorker(1, logs));
        }
        public static int HardestWorker(int n, int[][] logs)
        {
            if (logs.Length == 0) { return logs[0][0]; }
            List<int> keys = new List<int>();
            Dictionary<int, int> numsMap = new Dictionary<int, int>();
            for (int i = 0; i < logs.Length; i++)
            {
                keys.Add(logs[i][0]);
            }
            keys = keys.Distinct().ToList();
            keys.Sort();
                for (int i = 0; i < keys.Count; i++)
            {
                numsMap.Add(keys[i], 0);
            }

            numsMap[logs[0][0]] = logs[0][1];
            for (int i = 1; i < logs.Length; i++)
            {
                numsMap[logs[i][0]] += logs[i][1] - logs[i - 1][1];
            }
            var max = numsMap.Max(x => x.Value);
            
            return numsMap.First(x => x.Value == max).Key;

        }
        public static int ArrayToDictionary(int[][] nums)
        {
            var keys = nums.ToList().Select(x => x[0]).Distinct();
            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }
            //Dictionary<int, int> numsMap = new Dictionary<int, int>();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    keys.Add(nums[i][0]);
            //}
            //keys = keys.Distinct().ToList();
            //for (int i = 0; i < keys.Count; i++)
            //{
            //    numsMap.Add(keys[i], 0);
            //}

            //numsMap[nums[0][0]] = nums[0][1];
            //for (int i = 1; i < nums.Length; i++)
            //{
            //    numsMap[nums[i][0]] += nums[i][1] - nums[i - 1][1];
            //}
            return 0;
            //return numsMap.Last(x => x.Value == numsMap.Max(x => x.Value)).Key;

        }
    }
}






//var map = logs.ToDictionary((x) => $"{x[0]},{x[1]}", (x) => x[1]);
//var keys = map.Keys.ToList();
//var values = map.Values.ToList();

//var timeWorkedList = new List<int>() { values[0] };
////timeWorkedList.Add(values[1] - values[0]);
//for (int i = 0; i < values.Count - 1; i++)
//{
//    timeWorkedList.Add(values[i + 1] - values[i]);
//}
////Console.WriteLine(logs.Length + " =  logs");
////Console.WriteLine(timeWorkedList.Count + " = timeWorked");
//var newLogs = new int[map.Count][];
//for (int i = 0; i < logs.Length; i++)
//{
//    newLogs[i] = new int[] { logs[i][0], 0 };
//}

//var cummulativeWork = 0;
//var longestTime = timeWorkedList.Max(i => i);
//var indexOfLongestTime = timeWorkedList.FindIndex(x => x == longestTime);
////var hardestworker = map[$"{indexOfLongestTime},{longestTime}"];
//foreach (var t in timeWorkedList)
//{
//    Console.WriteLine(t);
//}
//Console.WriteLine("break");
//foreach (var t in map)
//{
//    Console.WriteLine(t.Key);
//}
//Console.WriteLine($"{indexOfLongestTime},{longestTime}");
//Console.WriteLine("break");
//foreach (var t in logs)
//{
//    Console.WriteLine(t[0]);
//}
//Console.WriteLine("breaks");
//return 0;