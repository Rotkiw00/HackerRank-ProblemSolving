namespace GradingStudents;
class Program
{
    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> newGrades = new();

        foreach (int grade in grades)
        {
            if (grade >= 38 && grade <= 100)
            {
                if (((int)Math.Ceiling((double)grade / 5) * 5) - grade < 3)
                {
                    newGrades.Add((int)Math.Ceiling((double)grade / 5) * 5);
                }
                else if (((int)Math.Ceiling((double)grade / 5) * 5) - grade >= 3)
                {
                    newGrades.Add(grade);
                }
            }
            else
            {
                newGrades.Add(grade);
            }
        }
        return newGrades;
    }

    static void Main(string[] args)
    {
        List<int> ints = new() { 73, 67, 38, 33 };
        List<int> ints1 = gradingStudents(ints);
        Console.WriteLine("Hello, World!");
    }
}

