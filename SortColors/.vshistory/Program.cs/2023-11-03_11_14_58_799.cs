namespace SortColors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[]
            {
                12,123,1231,23,24,35,421,23,5,234,3123,1234,23,0,0,0,0,101,101,10,2020,1,1,1,2,2,2,2,23,3,3,3,3,3
            };
            //SortColors(nums);
            //var sorted = MergeSort(nums.ToList());
            var splir = Split(nums.ToList(), nums.Length / 2, nums.Length);
            for (int i = 0; i < splir.Count; i++)
            {
                for (int j = 0; j < splir[i].Count; j++)
                {
                    Console.WriteLine($"{i}  sorted => " + splir[i][j] + "nums => " + nums[i][j]);
                }
                Console.WriteLine("break break break break");
            }

        }
        public static void SortColors(int[] nums)
        {
            var numsList = QuickSort(nums.ToList());
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = numsList[i];
            }
        }

        public static List<int> MergeSort(List<int> nums)
        {
            if (nums.Count < 2) return nums;
            int len = nums.Count;
            int middle = len / 2;
            var split = Split(nums, middle, len);
            //return MergeSort(Merge(split[0], split[1]));
            foreach (var t in split)
            {
                foreach (var v in t)
                {
                    Console.WriteLine(v);
                }
                Console.WriteLine("break");
            }
            return new List<int> { middle, len };
        }

        public static List<int> Merge(List<int> numsLeft, List<int> numsRight)
        {
            if (numsRight.Count == 0) return numsLeft;
            if (numsLeft.Count == 0) return numsRight;
            var firstLeft = numsLeft[0];
            var firstRight = numsRight[0];
            if (firstLeft < firstRight)
            {
                numsLeft.RemoveAt(0);
                return new List<int> { firstLeft }.Concat(Merge(numsLeft, numsRight)).ToList();
            }
            numsRight.RemoveAt(0);
            return new List<int> { firstRight }.Concat(Merge(numsLeft, numsRight)).ToList();
        }
        public static List<List<int>> Split(List<int> nums, int middle, int len)
        {
            return new List<List<int>>
            {
               nums.GetRange(0,middle).ToList(),
               nums.GetRange(middle, (len - middle)).ToList()

            };
        }


        public static List<int> QuickSort(List<int> nums)
        {
            if (nums.Count < 2) return nums;
            int pivot = nums[0];
            nums.RemoveAt(0);
            List<int> smaller = new List<int>();
            List<int> larger = new List<int>();
            foreach (var item in nums)
            {
                if (item < pivot)
                {
                    smaller.Add(item);
                    continue;
                }

                larger.Add(item);

            }
            smaller = QuickSort(smaller).ToList();
            larger = QuickSort(larger).ToList();
            return smaller.Concat(new List<int> { pivot }).Concat(larger).ToList();
        }
    }
}