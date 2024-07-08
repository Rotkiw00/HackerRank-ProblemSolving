// Find and return the smallest value that meet the following requirements:
/*
   - is odd,
   - is divideable by 3,
   - is greater than input value,
   - has unique digists
   - must be positive
*/
namespace SmallestNearestNumber
class Program
{

    static void Main(string[] args)
    {

        int test = GetNextValue(12);
    }


    public int GetNextValue(int inputNumber)
    {
        int result = inputNumber;
        if (inputNumber < 0)
        {
            while (true)
            {


                if (result % 3 == 0 && result % 2 == 1 result > inputNumber){
                    return result;
                }
                result++;
            }


        }
        else
        {
            return 3;
        }
    }


    private bool IsOdd(int number) => (number % 2 == 1);
    private bool IsDivideableByThree(int number) => (number % 3 == 0);
    private bool HasUniqueDigits(int number)
    {
        string tempNumber = number.ToString();
        return false;
    }
}
