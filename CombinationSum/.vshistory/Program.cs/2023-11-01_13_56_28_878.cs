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
        private static List<int>? _CombinationSum(int[] candidates, int target, Hashtable table)
        {
            if (target < 0) return null;
            if (target == 0) return new List<int>();
            var finalResult  = new List<IList<int>>();
            foreach (var candidate in candidates)
            {
                var result = _CombinationSum(candidates, target - candidate, table);
                if (result != null)
                {
                    finalResult.Add();
                }
            }
            return new List<int>();
        }
    }
}