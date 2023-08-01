namespace ElectronicsShop;
class Program
{
    /*
     * Complete the getMoneySpent function below.
     */
    static int getMoneySpent(int[] keyboards, int[] drives, int b)
    {
        List<int> costs = new();
        foreach (var keyboard in keyboards)
        {
            foreach (var drive in drives)
            {
                costs.Add(keyboard + drive);
            }
        }
        return costs.Where(c => c <= b).DefaultIfEmpty(-1).Max();
    }

    static void Main(string[] args)
    {
        int i = getMoneySpent(new int[] { 4 }, new int[] { 5 }, 5);
        Console.WriteLine(i);
    }
}

