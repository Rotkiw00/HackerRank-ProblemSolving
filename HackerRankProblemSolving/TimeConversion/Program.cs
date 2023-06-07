using System;

namespace TimeConversion;
class Program
{
    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        string time = s.Substring(0, s.Length - 2);
        string hours = time[..2];
        string amPM = s.Substring(s.Length - 2, 2);
        string newTime = string.Empty;

        if (amPM == "AM")
        {
            if (hours == "12")
            {
                hours = "00";
                newTime = string.Concat(hours, time.AsSpan(2, time.Length - 2));
                return newTime;
            }
            return time;
        }
        else if (amPM == "PM")
        {
            int hoursInt = int.Parse(hours);
            hoursInt += 12;
            newTime = string.Concat(hoursInt.ToString(), time.AsSpan(2, time.Length - 2));
            string hoursNewTime = newTime[..2];

            if (hoursNewTime == "24")
            {
                hoursNewTime = "12";
                newTime = string.Concat(hoursNewTime, time.AsSpan(2, time.Length - 2));
                return newTime;
            }
        }
        return newTime;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

