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
            int start = height[0];
            int end = height[len - 1];
            int maxArea = 0;
            for (int i = 0; i < len; i++)
            {
                maxArea = Math.Max(maxArea, end - start);
            }
            return -1;
        }
    }
}