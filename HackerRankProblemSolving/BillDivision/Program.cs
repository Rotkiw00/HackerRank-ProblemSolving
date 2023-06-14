namespace BillDivision;
class Program
{
    /*
     * Complete the 'bonAppetit' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY bill
     *  2. INTEGER k
     *  3. INTEGER b
     */

    public static void bonAppetit(List<int> bill, int k, int b)
    {
        // Shorter solution
        int billSum = bill.Sum() - bill[k];

        /* Longer solution */
        //int billSum = 0;
        //for (int i = 0; i < bill.Count; i++)
        //{
        //    if (k == i) { continue; }
        //    billSum += bill[i];
        //}

        int splitBill = billSum / 2;
        if (splitBill == b) { Console.WriteLine("Bon Appetit"); }
        else { Console.WriteLine(b - splitBill); }
    }

    static void Main(string[] args)
    {
        List<int> ints = new List<int>()
        {
            3,10,2,9
        };
        bonAppetit(ints, 1, 12);
    }
}

