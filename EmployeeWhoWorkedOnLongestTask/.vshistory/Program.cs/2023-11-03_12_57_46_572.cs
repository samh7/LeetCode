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
            var map = logs.ToDictionary((x) => x[0], (x) => x[1]);
            var keys = map.Keys;
            var values = map.Values.ToArray()
            //    ;    
            //var timesWorked = new List<int>() { values[0] };
            //for (int i = 0; i < map.Count; i++)
            //{

            //}

                foreach( var x in keys)
            {

            }
            return 0;

        }
        public static Dictionary<int, int> ArrayToDictionary(int[][] nums)
        {
            return null;
        }
    }
}