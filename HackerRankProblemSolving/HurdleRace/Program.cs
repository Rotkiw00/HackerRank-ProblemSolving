namespace HurdleRace;
class Program
{
    /*
     * Complete the 'hurdleRace' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY height
     */

    public static int hurdleRace(int k, List<int> height)
    {
        if (k < height.Max())
        {
            return height.Max() - k;
        }
        else
        {
            return 0;
        }
    }

    static void Main(string[] args)
    {
        //test1
        int t1 = hurdleRace(4, new List<int>() { 1, 6, 3, 5, 2 });

        //test2
        int t2 = hurdleRace(7, new List<int>() { 2, 5, 4, 5, 2 });
    }
}

