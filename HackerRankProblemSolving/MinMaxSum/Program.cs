namespace MinMaxSum;
class Program
{
    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<long> arr)
    {
        long minSum = 0, maxSum = 0;
        if (arr.Count > 0)
        {
            long[] arrr = arr.ToArray();
            Array.Sort(arrr);
                        
            for (int i = 1; i < arrr.Length; i++)
            {
                minSum += arrr[i - 1];
                maxSum += arrr[i];
            }
        }

        Console.Write($"{minSum} {maxSum}");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

