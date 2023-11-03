using System.Collections;

namespace CombinationSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<IList<int>> result = CombinationSum(new int[] { 2, 3, 6, 7 }, 7);
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
            Array.Sort(candidates);
            candidates = candidates.Distinct().ToArray();
             
           var result = new  List<IList<int>>();
            _CombinationSum(candidates,target, result, new(), 0);
            return result;
        }
        private static void _CombinationSum(int[] candidates, int target, IList<IList<int>> result, List<int> temp, int index)
        {
            if (target == 0)
            {
                result.Add(new List<int>(temp));
                return;
            }
            for (int i = index; i < candidates.Length; i++)
            {
                var remainder = target - candidates[i];
                if (remainder >= 0)
                {
                    temp.Add(candidates[i]);
                    _CombinationSum(candidates, remainder, result, temp, i);
                    temp.Remove(candidates[i]);
                }
            }

        }
    }
}