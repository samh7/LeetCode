using System.Collections;

namespace CombinationSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = _CombinationSum(new int[] { 2, 3, 6, 7 }, 7, new());
        }
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            return new List<IList<int>>();
        }
        private static List<int>? _CombinationSum(int[] candidates, int target, Hashtable table)
        {
            if (target < 0) return null;
            if (target == 0) return new List<int>();
            var finalResult = new List<int>() { candidates[0] };
            foreach (var candidate in candidates)
            {
                var result = _CombinationSum(candidates, target - candidate, table);
                if (result != null)
                {
                    finalResult.Add(candidate);
                }
            }
            return finalResult;
        }
    }
}