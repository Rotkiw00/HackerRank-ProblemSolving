namespace MigratoryBirds;
class Program
{
    /*
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
        const int BIRD_TYPES = 5;

        Dictionary<int, int> typesAndSightes = new Dictionary<int, int>();
        for (int i = 1; i <= BIRD_TYPES; i++)
        {
            typesAndSightes.Add(i, arr.Where(x => x.Equals(i)).Count());
        }

        var maxVal = typesAndSightes.Values.Max();
        List<int> maxKeys = new List<int>();
        foreach (var keyVal in typesAndSightes)
        {
            if (maxVal == keyVal.Value)
            {
                maxKeys.Add(keyVal.Key);
            }
        }
        return maxKeys.Min();
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

