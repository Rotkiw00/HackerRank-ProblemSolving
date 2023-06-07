namespace Staircase;
class Program
{
    /*
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
        for (int i = 0; i < n; i++)
        {
            string space = new string(' ', n - (i + 1));
            string hash = new string('#', i + 1);
            Console.WriteLine(space + hash);
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

