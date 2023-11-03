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
            int end = height[len - 1;
            int maxArea = 0;
            for (int i = 0; i < len; i++)
            {
                int start = height[i];
                if (height[end] < height[start])
                {
                    maxArea = Math.Max(maxArea, (end - i) * height[end]);
                    continue;
                }
                end--;
            }
            return maxArea;
        }
    }
}