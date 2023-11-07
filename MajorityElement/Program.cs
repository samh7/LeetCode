﻿namespace MajorityElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 }));
        }

        public static int MajorityElement(int[] nums)
        {
            Array.Sort(nums);
            var numsList = nums.ToList();
            int i = 0;
            while (i < numsList.Count)
            {

                var val = numsList[i];
                var endIndex = numsList.LastIndexOf(val);
                if (((endIndex - i) + 1) > (numsList.Count) / 2)
                {
                    return val;
                }
                i = endIndex + 1;
            }
            return 0;
        }

        //slow implementation
        //public static int MajorityElement(int[] nums)
        //{

        //    var numsList = nums.ToList();
        //    while (0 < nums.Length)
        //    {
        //        numsList.RemoveAll(x => x == nums[0]);
        //        if (numsList.Count() < (nums.Length + 1) / 2)
        //        {
        //            return nums[0];
        //        }
        //        numsList = nums.ToList();
        //        numsList.RemoveAt(0);
        //        nums = numsList.ToArray();
        //    }

        //    return 0;
        //}
    }
}