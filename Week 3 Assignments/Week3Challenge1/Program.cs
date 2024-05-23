namespace Week3Challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a word to check if it is a palindrome: ");
            string myWord = Console.ReadLine();

            if (TestPalindrome(myWord))
            {
                Console.WriteLine($"{myWord} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{myWord} is not a palindrome.");
            }

        }
        static bool TestPalindrome(string palindrome)
        {
            bool isPalindrome = false;
            for (int i = 0; i < palindrome.Length / 2; i++)
            {
                if (!(palindrome[i] == palindrome[palindrome.Length - 1 - i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}