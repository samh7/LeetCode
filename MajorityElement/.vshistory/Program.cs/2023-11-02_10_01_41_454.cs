﻿namespace MajorityElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MajorityElement(new int[] { 3, 2, 3 }));
        }
        public static int MajorityElement(int[] nums)
        {

            var numsList = nums.ToList();
            while (0 < nums.Length)
            {
                numsList.RemoveAll(x => x == nums[0]);
                if (numsList.Count() < (nums.Length + 1) / 2)
                {
                    return nums[0];
                }
                numsList = nums.ToList();
                numsList.RemoveAt(0);
                nums = numsList.ToArray();
            }

            return 0;
        }
    }
}