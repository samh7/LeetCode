namespace ContainerWithMostWater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            //t = t.Reverse().ToArray();
            Console.WriteLine(MaxArea(t));
        }
        public static int MaxArea(int[] height)
        {
            int len = height.Length;
            int end = len - 1;
            int maxArea = -1;
            for (int i = 0; i < len; i++)
            {
                int larger = height[i] > height[end] ? height;
                int smaller = height[i] <
                    height[end] ? height; 
                maxArea = Math.Max(maxArea, Math.Abs((end - i)) * height[end]);
            }
            for (int i = 0; i < len; i++)
            {
                maxArea = Math.Max(maxArea, (end - i) * height[end]);

                end--;

            }
            return maxArea;
        }
    }
}