namespace ClimbingTheLeaderboard;

class Program
{
    static void Main(string[] args)
    {
        var test = climbingLeaderboard_betterPerformance(
            new List<int>() { 100, 90, 90, 80, 75, 60 },
            new List<int>() { 50, 65, 77, 90, 102 }
            );

        Console.WriteLine("Debug");
    }

    /*
     * Complete the 'climbingLeaderboard' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY ranked
     *  2. INTEGER_ARRAY player
     */

    public static List<int> climbingLeaderboard_worstPerformance(List<int> ranked, List<int> player)
    {
        List<int> leaderboard = new();

        foreach (int pointsInRound in player)
        {
            ranked.Add(pointsInRound);
            ranked.Sort((x,y) => y.CompareTo(x));

            int playerRank = 1;
            for (int i = 1; i < ranked.Count; i++)
            {
                if (ranked[0] == pointsInRound) break;

                if (ranked[i] != ranked[i - 1])
                {
                    playerRank++;
                }

                if (ranked[i] == pointsInRound) break;
            }

            leaderboard.Add(playerRank);
            ranked.Remove(pointsInRound);
        }


        return leaderboard;
    }

    public static List<int> climbingLeaderboard_betterPerformance(List<int> ranked, List<int> player)
    {
        List<int> leaderboard = new List<int>();

        ranked = ranked.Distinct().ToList();
        int index = ranked.Count - 1;

        foreach (int pointsInRound in player)
        {
            while (index >= 0 && pointsInRound >= ranked[index])
            {
                index--;
            }

            int playerRank = index + 2;
            leaderboard.Add(playerRank);
        }

        return leaderboard;
    }

}