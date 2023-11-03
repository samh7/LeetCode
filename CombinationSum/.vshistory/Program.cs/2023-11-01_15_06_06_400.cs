using System.Collections;

namespace CombinationSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = _CombinationSum(new int[] { 2, 3, 6, 7 }, 7, 0);
            foreach (var t in result)
            {
                Console.WriteLine(t);
            }
        }
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            return new List<IList<int>>();
        }
        private static dynamic? _CombinationSum(int[] candidates, List<int> temp, int target, int index)
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
            for (int i = index; i < candidates.Length; i++)
            {
                var remainder = target - candidates[i];
                var result = _CombinationSum(candidates, temp, remainder, index);
                temp.Add(candidates[i]);
                if (result != null)
                {
                    continue;
                }
                temp.Remove(candidates[i]);
            }
            return finalResult;
        }
    }
}