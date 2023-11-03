using System.Collections;

namespace CombinationSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = _CombinationSum(new int[] {2,3,6,7}, 7);
            foreach(var t in result)
            {
                Console.WriteLine(t);
            }
        }
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            return new List<IList<int>>();
        }
        private static dynamic? _CombinationSum(int[] candidates, int target)
        {
            if (target == 0)
            {
                return new List<int>();
            }
            if (target < 0)
            {
                return null;
            }
            var finalResult = new List<int>();
            foreach (var candidate in candidates)
            {
                var remainder = candidate - target;
                var result = _CombinationSum(candidates, remainder);
                finalResult.Add(candidate);
                if (result != null)
                {
                    return finalResult;
                }
            }
            return null;
        }
    }
}