using System.Text;

namespace Assignment3._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReturnEvenNumbers());
        }
        static string ReturnEvenNumbers()
        {
            StringBuilder evenNumbers = new StringBuilder();
            for (int x = 2; x < 100; x += 2)
            {
                evenNumbers.Append(x).Append(" ");
            }
            return evenNumbers.ToString();
        }
    }
}