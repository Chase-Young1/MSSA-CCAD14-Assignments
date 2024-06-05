/* Write a program in C# Sharp to print the first n natural number using recursion.
Test Data :
How many numbers to print : 10
Expected Output :
1 2 3 4 5 6 7 8 9 10 */

namespace Assignment5._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int MaxValue = 10;
            int naturalNumber = 1;

            RecursionOfNumbers(naturalNumber, MaxValue);
        }
        static void RecursionOfNumbers(int naturalNumber, int MaxValue)
        {
            if (naturalNumber <= MaxValue)
            {
                Console.WriteLine(naturalNumber + " ");
                naturalNumber++;
                RecursionOfNumbers(naturalNumber, MaxValue);
            }
        }
    }
}