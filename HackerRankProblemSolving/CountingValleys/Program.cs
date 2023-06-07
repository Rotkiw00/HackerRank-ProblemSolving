namespace CountingValleys;
class Program
{
    /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int countingValleys(int steps, string path)
    {
        int valleys = 0;
        int down = 0, up = 0;
        const int SEA_LVL = 0;

        for (int i = 0; i < steps; i++)
        {
            if (path[i] == 'D')
            {
                down -= 1;
            }

            if (path[i] == 'U')
            {
                up += 1;
            }

            if (path[i] == 'U' && down + up == SEA_LVL)
            {
                valleys++;
            }
        }
        return valleys;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

