using System.Collections;

namespace CombinationSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> result = new List<List<int>>();
            _CombinationSum(new int[] { 2, 3, 6, 7 }, 7,  result, new(), 0);
            foreach (var t in result)
            {
                foreach (var i in t)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("break");
            }
        }
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            return new List<IList<int>>();
        }
        private static void _CombinationSum(int[] candidates, int target, List<IList<int>> result, List<int> temp, int index)
        {
            if (target == 0)
            {
                result.Add(new IList<>());
                return;
            }
            for (int i = index; i < candidates.Length; i++)
            {
                var remainder = target - candidates[i];
                if (remainder >= 0)
                {
                    temp.Add(candidates[i]);
                    _CombinationSum(candidates, remainder,  result, temp, i);
                    temp.Remove(candidates[i]);
                }
            }

        }
    }
}