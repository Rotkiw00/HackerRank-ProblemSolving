namespace SubarrayDivision;
class Program
{
    /*
     * Complete the 'birthday' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY s
     *  2. INTEGER d
     *  3. INTEGER m
     */

    public static int birthday(List<int> s, int d, int m)
    {
        int counter = 0;
        for (int i = 0; i < s.Count; i++)
        {
            int sum = 0;
            for (int j = 0; j < m; j++)
            {
                if (i + j < s.Count)
                {
                    sum += s[i + j];
                }
                else { break; }

            }
            if (sum == d)
            {
                counter++;
            }
        }
        return counter;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

