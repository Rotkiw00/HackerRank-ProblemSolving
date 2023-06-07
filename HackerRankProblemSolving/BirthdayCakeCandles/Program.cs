namespace BirthdayCakeCandles;
class Program
{
    /*
     * Complete the 'birthdayCakeCandles' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY candles as parameter.
     */

    public static int birthdayCakeCandles(List<int> candles)
    {
        if (candles.Count == 0)
        {
            return 0;
        }

        int counter = 0;
        for (int i = 0; i < candles.Count; i++)
        {
            if (candles[i] == candles.Max())
            {
                counter += 1;
            }
        }

        return counter;
    }

    static void Main(string[] args)
    {
        int[] nums = { 3, 2, 1, 3 };
        birthdayCakeCandles(nums.ToList());
    }
}

