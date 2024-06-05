namespace Assignment5._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word to see if it is a palindrome.");
            string word = Console.ReadLine();
            Console.WriteLine(IsPalindrome(word,0,word.Length - 1));
        }
        static bool IsPalindrome(string s, int start, int end)
        {
            if (start >= end)
            {
                return true;
            }
            if (s[start] != s[end])
            {
                return false;
            }
            return IsPalindrome(s, start + 1, end - 1); //Moves first index 1 to the right and the last index 1 to the left
        }
    }
}