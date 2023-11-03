namespace SortColors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[]
            {
                12,123,1231,23,24,35,421,23,
            };
            SortColors(nums);
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }

        }
       
    }
}