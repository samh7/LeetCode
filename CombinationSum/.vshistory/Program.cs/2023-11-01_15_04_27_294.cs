using System.Collections;

namespace CombinationSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = _CombinationSum(new int[] { 2, 3, 6, 7 }, 7);
            foreach (var t in result)
            {
                Console.WriteLine(t);
            }
        }
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            return new List<IList<int>>();
        }
        private static dynamic? _CombinationSum(int[] candidates, int target, int index)
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
            for(int i = index; i < candidates.Length; i++) 
            {
                var remainder = target - candidate;
                var result = _CombinationSum(candidates, remainder, index);
                finalResult.Add(candidate);
                if (result != null)
                {
                    continue;
                }
                finalResult.Remove(candidate);
            }
            return finalResult;
        }
    }
}