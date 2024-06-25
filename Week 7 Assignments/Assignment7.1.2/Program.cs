/* You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.
Return the merged string.

Example 1:
Input: word1 = "abc", word2 = "pqr"
Output: "apbqcr"
Explanation: The merged string will be merged as so:
word1: a b c
word2: p q r
merged: a p b q c r

Example 2:
Input: word1 = "ab", word2 = "pqrs"
Output: "apbqrs"
Explanation: Notice that as word2 is longer, "rs" is appended to the end.
word1: a b
word2: p q r s
merged: a p b q r s */

using System.Text;

namespace Assignment7._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string of lowercase letters.");
            string wordOne = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Please enter a second string of lowercase letters.");
            string wordTwo = Console.ReadLine();
            Console.WriteLine();
            string result = MergeStrings(wordOne, wordTwo);
            Console.WriteLine($"The two strings merged in alternating order:  { result}.");
        }
        static string MergeStrings(string wordOne, string wordTwo)
        {
            string result = "";
            int maxLength = Math.Max(wordOne.Length, wordTwo.Length);

            for (int i = 0; i < maxLength; i++)
            {
                if (i < wordOne.Length)
                {
                    result += wordOne[i];
                }
                if (i < wordTwo.Length)
                {
                    result += wordTwo[i];
                }                            
            }
            return result;
        }
    }
}
