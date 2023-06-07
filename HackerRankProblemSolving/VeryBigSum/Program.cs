using System;
using System.Collections.Generic;

namespace VeryBigSum;
class Program
{
    /*
     * Complete the 'aVeryBigSum' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER_ARRAY ar as parameter.
     */

    public static long aVeryBigSum(List<long> ar)
    {
        long bigSum = 0;
        if (1 <= ar.Count && ar.Count <= 10)
        {
            for (int i = 0; i < ar.Count; i++)
            {
                bigSum += ar[i];
            }
        }
        else
        {
            throw new Exception("It is bad");
        }
        return bigSum;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

