namespace HardestWorker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public static int HardestWorker(int n, int[][] logs)
        {
            var map = logs.ToDictionary((x) => x);
            foreach( var x in map)
            {
                Console.WriteLine($"key => {x.Key}, Value = {x.Value}");
            }
            return 0;

        }
        public static Dictionary<int, int> ArrayToDictionary(int[][] nums)
        {
            return null;
        }
    }
}