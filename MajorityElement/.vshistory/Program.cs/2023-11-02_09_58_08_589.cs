namespace MajorityElement
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
            for (int i = 0; i < nums.Length; i++)
            {
                nums.F
                numsList.FindAll
                    RemoveAll(x => x == nums[i]);
                if (numsList.Count() < (nums.Length + 1) / 2)
                {
                    return nums[i];
                }
                numsList = nums.ToList();
            }
            return 0;
        }
    }
}