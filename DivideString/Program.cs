namespace DivideString;

public class Program
{
    public static void Main(string[] args)
    {
        var t = DivideString("aabbccdee");
        foreach (var s in t)
        {
            Console.WriteLine(s);
        }
    }

    public static List<string> DivideString(string str)
    {
        HashSet<string> resultsHashSet = new();
        var resultList = new List<string>();
        int len = str.Length;
        for (int i = 0; i < len - 1; i++)
        {
            char now = str[i];
            resultsHashSet.Add($"{now}");
            int start = i + 1;
            string subStr = $"{now}";
            while (start <= len)
            {
                try
                {
                    var next = str[start];
                    if (now == next)
                    {
                        subStr += next;
                        start++;
                        continue;
                    }
                }
                catch (Exception e)
                {
                }

                resultsHashSet.Add(subStr);
                break;
            }

            i = start - 1;
        }

        return resultsHashSet.ToList();
    }
}