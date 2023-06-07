namespace SimpleArraySum;
class Program
{
    /*
     * Complete the 'simpleArraySum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY ar as parameter.
     */

    public static int simpleArraySum(List<int> ar)
    {
        int sum = 0;
        for (int i = 0; i < ar.Count; i++)
        {
            if (ar.Count > 0 && ar[i] <= 1000)
            {
                sum += ar[i];
            }
        }
        return sum;
    }

    static void Main(string[] args)
    {
        /*
         * Testing ...
         */
    }
}

