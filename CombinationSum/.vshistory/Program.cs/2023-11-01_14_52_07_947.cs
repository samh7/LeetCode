using System.Collections;

namespace CombinationSum
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            return new List<IList<int>>();
        }
        private static List<int>? _CombinationSum(int[] candidates, int target)
        {
            if(target == 0)
            {
                return new List<int>();
            }
            if(target < 0)
            {
                return null;
            }
            foreach (var candidate in candidates)
            {
                var remainder = candidate - target;
                var result = _CombinationSum(candidates, remainder);
            }
            return new();
        }
    }
}