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
                new int[]{5,6}
            };
            HardestWorker(4, logs);
        }
        public static int HardestWorker(int n, int[][] logs)
        {
            var map = logs.ToDictionary((x) => x[0]);
            foreach( var x in map)
            {
                Console.WriteLine($"key => {x.Key[0]}, Value = {x.Value[0]}");
            }
            return 0;

        }
        public static Dictionary<int, int> ArrayToDictionary(int[][] nums)
        {
            return null;
        }
    }
}