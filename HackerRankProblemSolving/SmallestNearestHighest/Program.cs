namespace SmallestNearestHighest
{
    // Find and return the smallest value that meet the following requirements:
    /*
       - is odd,
       - is divideable by 3,
       - is greater than input value,
       - has unique digists
       - must be positive
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            int test = GetNextValue(999);
            Console.WriteLine(test);
            Console.ReadLine();
        }

        public static int GetNextValue(int inputNumber)
        {
            int result = inputNumber;
            if (inputNumber > 0)
            {
                while (true)
                {
                    if (IsOdd(result) &&
                        IsDivideableByThree(result) &&
                        HasUniqueDigits(result))
                    {
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


        private static bool IsOdd(int number) => (number % 2 == 1);
        private static bool IsDivideableByThree(int number) => (number % 3 == 0);
        private static bool HasUniqueDigits(int number)
        {
            string tempNumber = number.ToString();
            return tempNumber.ToArray().Distinct().Count() == tempNumber.Length;
        }
    }
}
