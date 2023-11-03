namespace ContainerWithMostWater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public static int MaxArea(int[] height)
        {
            int len = height.Length;
            int end = height[len - 1];
            int maxArea = 0;
            //for (int i = 0; i < len; i++)
            //{
            //    maxArea = Math.Max(maxArea, end - start);
            //    end--;
            //}
            for (int i = 0; i < len; i++)
            {
                int start = height[i];
                if (end < start)
                {
                    maxArea = Math.Max(maxArea, end - start);
                    continue;
                }
                end--;
            }
            return -1;
        }
    }
}