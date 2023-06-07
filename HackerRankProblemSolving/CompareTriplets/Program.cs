namespace CompareTriplets;
class Program
{
    /*
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        int pBob = 0;
        int pAlice = 0;
        List<int> points = new List<int>();

        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] > b[i])
            {
                pAlice++;
            }
            else if (a[i] < b[i])
            {
                pBob++;
            }
            else
            {
                continue;
            }
        }
        points.Add(pAlice);
        points.Add(pBob);

        return points;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

