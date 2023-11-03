using System.Collections;

namespace CombinationSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> result = new List<List<int>>();
            _CombinationSum(new int[] { 2, 3, 6, 7 }, 7, ref result, new(),0);
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
        private static void _CombinationSum(int[] candidates, int target, ref List<List<int>> result, List<int> temp, int index)
        {
            if (target == 0)
            {
                result.Add(temp);
                return;
            }
            if (target < 0)
            {
                return;
            }
            var finalResult = new List<int>();
            for (int i = index; i < candidates.Length; i++)
            {
                temp.Add(candidates[i]);
                _CombinationSum(candidates, target - candidates[i], ref result, temp, index);
                temp.Remove(candidates[i]);
            }
            //return finalResult;
        }
    }
}