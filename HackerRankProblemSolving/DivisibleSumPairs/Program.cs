using System.Collections.Generic;

namespace DivisibleSumPairs;
class Program
{
    /*
     * Complete the 'divisibleSumPairs' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER k
     *  3. INTEGER_ARRAY ar
     */

    public static int divisibleSumPairs(int n, int k, List<int> ar)
    {
        int qtyPairs = 0;
        for (int i = 0; i < ar.Count; i++)
        {
            for (int j = ar.Count - 1; j > i; j--)
            {
                int sumPairs = ar[i] + ar[j];
                if (sumPairs % k == 0)
                {
                    qtyPairs++;
                }
            }
        }
        return qtyPairs;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

