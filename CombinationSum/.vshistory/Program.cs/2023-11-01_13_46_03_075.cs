using System.Collections;

namespace CombinationSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            return new List<IList<int>>();
        }
        private static IList<IList<int>> _CombinationSum(int[] candidates, int target, Hashtable table)
        {
            if (target < 0) return null;
            if (target == 0) return 0;
            return new List<IList<int>>();
        }
    }
}