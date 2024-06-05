/* Write a program in C# Sharp to print numbers from n to 1 using recursion.
Test Data :
How many numbers to print : 10
Expected Output :
10 9 8 7 6 5 4 3 2 1 */

namespace Assignment5._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxValue = 10;
            int naturalNumber = 1;

            RecursionOfNumbers(naturalNumber, maxValue);
        }
        static void RecursionOfNumbers(int naturalNumber, int maxValue)
        {
            if (maxValue >= naturalNumber)
            {
                Console.WriteLine(maxValue + " ");
                maxValue--;
                RecursionOfNumbers(naturalNumber, maxValue);
            }
        }
    }
}