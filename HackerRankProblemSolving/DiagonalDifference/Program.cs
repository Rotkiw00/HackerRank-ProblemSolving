namespace DiagonalDifference;
class Program
{
    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int diafLeft = 0, diagRight = 0;
        for (int i = 0; i < arr[0].Count; i++)
        {
            diagRight += arr[i][i];
            diafLeft += arr[arr.Count - 1 - i][i];
        }        

        return Math.Abs(diafLeft - diagRight);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

