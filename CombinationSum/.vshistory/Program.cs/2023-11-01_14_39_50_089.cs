using System.Collections;

namespace CombinationSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LisT<List<int>> nums = new() { };
            _CombinationSum(new int[] { 2, 3, 6, 7 }, 7, new());
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
        }
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            return new List<IList<int>>();
        }
        private static void _CombinationSum(int[] candidates, int target, List<int> finalResult, ref List<List<int>> Result)
        {
            if (target < 0)
            {
                return;
            }
            if (target == 0)
            {
                Result.Add(finalResult);
                return;
            }
            foreach (var candidate in candidates)
            {
                finalResult.Add(candidate);
                _CombinationSum(candidates, target - candidate, finalResult, ref Result);
            }

        }
    }
}