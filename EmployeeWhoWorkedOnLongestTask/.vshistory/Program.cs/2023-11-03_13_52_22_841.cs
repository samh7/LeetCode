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
                new int[]{0,6}
            };
            HardestWorker(4, logs);
        }
        public static int HardestWorker(int n, int[][] logs)
        {
            var map = logs.ToDictionary((x) => $"{x[0]},{x[1]}", (x) => x[1]);
            var keys = map.Keys.ToList();
            var values = map.Values.ToList();

            var timeWorkedList = new List<int>() { values[0] };
            timeWorkedList.Add(values[1] - values[0  F]);
            for (int i = 1; i < values.Count - 1; i++)
            {
                timeWorkedList.Add(values[i + 1] - values[i]);
            }
            Console.WriteLine(logs.Length + " =  logs");
            Console.WriteLine(timeWorkedList.Count + " = timeWorked");
            var newLogs = new int[map.Count][];
            for (int i = 0; i < logs.Length; i++)
            {
                newLogs[i] = new int[] { logs[i][0], 0 };
            }
           
            var cummulativeWork = 0;
            var longestTime = timeWorkedList.Max(i => i);
            var indexOfLongestTime = timeWorkedList.FindIndex(x => x == longestTime);
            var hardestworker = map[$"{indexOfLongestTime},{longestTime}"];

            return hardestworker;

        }
        public static Dictionary<int, int> ArrayToDictionary(int[][] nums)
        {
            return null;
        }
    }
}