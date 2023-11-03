namespace MinOperationsToMakeAlternating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public static int MinOperations(string s)
        {
            var sList = s.ToList();
            for (int i = 0; i < sList.Length - 1; i++)
            {
                if (sList[i] == sList[i + 1])
                {
                    if (sList[i] == '1')
                    {
                        sList[i] = '0';
                    }
                    else if (sList[i] == '0')
                    {

                    }
                }
            }
            return 0;
        }
    }
}