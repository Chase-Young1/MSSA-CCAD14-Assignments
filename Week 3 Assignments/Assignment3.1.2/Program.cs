namespace Assignment3._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a valid year.");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsLeapYear(year));
        }
        static bool IsLeapYear(int year)
        {
            return (DateTime.IsLeapYear(year));
        }
    }
}