using System.Collections;

namespace CombinationSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var result = _CombinationSum(new int[] { 2, 3, 6, 7 }, 7, new());
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
        }
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            return new List<IList<int>>();
        }
        private static IList<IList<int>> _CombinationSum(int[] candidates, int target, List<int> finalResult, Hashtable table)
        {
            if (target < 0) return null;
            if (target == 0) return new List<IList<int>>();
            foreach (var candidate in candidates)
            {
                var newCandidates = candidates.ToList();
                newCandidates.RemoveAt(0);
                var result = _CombinationSum(newCandidates.ToArray(), target - candidate, finalResult, table);
                if (result != null)
                {
                    finalResult.Add(candidate);
                }
            }
            return new List<IList<int>>();
        }
    }
}