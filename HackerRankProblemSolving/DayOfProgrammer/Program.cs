namespace DayOfProgrammer;
class Program
{
    /*
     * Complete the 'dayOfProgrammer' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER year as parameter.
     */

    public static string dayOfProgrammer(int year)
    {
        string stringYear;
        if (year < 1918 && year >= 1700)
        {
            if (year % 4 == 0)
            {
                stringYear = "12.09." + year.ToString();
            }
            else
            {
                stringYear = "13.09." + year.ToString();
            }
        }
        else if (year >= 1919)
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                stringYear = "12.09." + year.ToString();
            }
            else
            {
                stringYear = "13.09." + year.ToString();
            }
        }
        else
        {
            stringYear = "26.09." + year.ToString();
        }
        return stringYear;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

