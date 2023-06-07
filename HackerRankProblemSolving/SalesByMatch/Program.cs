namespace SalesByMatch;
class Program
{
    /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int sockMerchant(int n, List<int> ar)
    {
        int pairs = 0;
        var socksNum = ar.GroupBy(x => x).Select(x => new { ColorSocs = x.Key, SocsCount = x.Count() });

        foreach (var item in socksNum)
        {
            if (item.SocsCount == 1)
            {
                continue;
            }

            if (item.SocsCount % 2 == 0)
            {
                pairs += item.SocsCount / 2;
            }
            else if ((item.SocsCount - 1) % 2 == 0)
            {
                pairs += (item.SocsCount - 1) / 2;
            }
        }

        return pairs;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

