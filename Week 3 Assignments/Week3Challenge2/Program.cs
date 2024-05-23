namespace Week3Challenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string consisting of both letters and numbers. Then I will return the sum of the numbers.");
            string myString = Console.ReadLine();
            Console.WriteLine($"The sum of the numbers in the provided string is: {ReturnSumOfDigits(myString)}");

        }
        static int ReturnSumOfDigits(string myString)
        {
            int sum = 0;

            foreach (char number in myString)
            {
                if (char.IsNumber(number))
                {
                    sum += Convert.ToInt32(number.ToString());
                }
            }
            return sum;
        }
    }
}