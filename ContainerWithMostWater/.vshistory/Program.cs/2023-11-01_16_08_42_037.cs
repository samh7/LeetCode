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
            int start = 0;
            int end = len - 1;
            int maxArea = -1;
            while (start < end)
            {
                int valStart = height[start];
                int valEnd = height[end];
                maxArea = Math.Max(maxArea, (end - start) * Math.Min(valEnd, valStart));
                if (valStart < valEnd)
                {
                    start++;
                    continue;
                }

            }
            return maxArea;
        }
    }
}