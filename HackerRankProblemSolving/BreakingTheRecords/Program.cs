namespace BreakingTheRecords;
class Program
{
    /*
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */
    public static List<int> breakingRecords(List<int> scores)
    {
        int highest = scores[0];
        int howManyHighest = 0;
        int lowest = scores[0];
        int howManyLowest = 0;

        for (int i = 0; i < scores.Count; i++)
        {
            if (highest < scores[i])
            {
                highest = scores[i];
                howManyHighest += 1;
            }

            if (lowest > scores[i])
            {
                lowest = scores[i];
                howManyLowest += 1;
            }
        }
        return new List<int>() { howManyHighest, howManyLowest };
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

