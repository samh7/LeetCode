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
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    if (s[i] == '1')
                    {
                        s[i] = '0';
                    }
                    else if (s[i] == '0')
                    {

                    }
                }
            }
            return 0;
        }
    }
}