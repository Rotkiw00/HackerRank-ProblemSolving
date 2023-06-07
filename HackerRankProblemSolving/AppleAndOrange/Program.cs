using System.Linq;

namespace AppleAndOrange;
class Program
{
    /*
     * Complete the 'countApplesAndOranges' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER s
     *  2. INTEGER t
     *  3. INTEGER a
     *  4. INTEGER b
     *  5. INTEGER_ARRAY apples
     *  6. INTEGER_ARRAY oranges
     */

    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        int howManyApple = 0;
        List<int> newApplesDist = apples.Select(apple => apple + a).ToList();

        foreach (var _ in newApplesDist.Where(apple => s <= apple && apple <= t).Select(apple => new { }))
        {
            howManyApple += 1;
        }

        int howManyOrange = 0;
        List<int> newOrangeDist = oranges.Select(orange => orange + b).ToList();

        foreach (var _ in newOrangeDist.Where(orange => s <= orange && orange <= t).Select(orange => new { }))
        {
            howManyOrange += 1;
        }
        Console.WriteLine($"{howManyApple}\n{howManyOrange}");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

