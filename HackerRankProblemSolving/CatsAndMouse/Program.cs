namespace CatsAndMouse;
class Program
{
    // Complete the catAndMouse function below.
    static string catAndMouse(int x, int y, int z)
    {
        int dist_a = Math.Abs(z - x);
        int dist_b = Math.Abs(z - y);
        if (dist_a < dist_b)
        {
            return "Cat A";
        }
        else if (dist_b < dist_a)
        {
            return "Cat B";
        }
        else
        {
            return "Mouse C";
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

