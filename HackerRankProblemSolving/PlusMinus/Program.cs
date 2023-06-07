namespace PlusMinus;
class Program
{
    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int positiveCounter = 0, negativeCounter = 0, zeroCounter = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            switch (arr[i])
            {
                case < 0:
                    negativeCounter++;
                    break;
                case > 0:
                    positiveCounter++;
                    break;
                default:
                    zeroCounter++;
                    break;
            }
        }
        decimal positiveNumsRatio = (decimal)positiveCounter / arr.Count;
        decimal negativeNumsRatio = (decimal)negativeCounter / arr.Count;
        decimal zeroNumsRatio = (decimal)zeroCounter / arr.Count;

        DisplayResult(positiveNumsRatio, negativeNumsRatio, zeroNumsRatio);
    }

    private static void DisplayResult(decimal positiveNumsRatio, decimal negativeNumsRatio, decimal zeroNumsRatio)
    {
        Console.Write($"{Math.Round(positiveNumsRatio, 6)}\n{Math.Round(negativeNumsRatio, 6)}\n{Math.Round(zeroNumsRatio, 6)}");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

