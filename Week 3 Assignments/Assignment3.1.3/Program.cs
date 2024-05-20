namespace Assignment3._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string.");
            string inputString = Console.ReadLine();

            int spaceCount = CountSpaces(inputString);

            Console.WriteLine($"{inputString} contains {spaceCount} spaces.");
        }
        static int CountSpaces(string s)
        {
            int count = 0;
            foreach (char c in s)
            {
                if (c == ' ')
                {
                    count++;
                }
            }
            return count;
        }
    }
}