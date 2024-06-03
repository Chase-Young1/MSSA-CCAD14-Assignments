namespace Assignment5._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any integer:");
            int n = int.Parse(Console.ReadLine());
            int sum = SumOfDigits(n);
            Console.WriteLine($"The sum of the digits in {n} is: {sum}.");
        }
        static int SumOfDigits (int n)
        {
            int sum = 0;
            
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
    }
}