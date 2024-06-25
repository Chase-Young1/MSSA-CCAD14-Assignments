/* Given two strings s and t, return true if t is an anagram of s, and false otherwise.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

Example 1:

Input: s = "anagram", t = "nagaram"

Output: true

Example 2:

Input: s = "rat", t = "car"

Output: false */

namespace Assignment7._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string:");
            string firstString = Console.ReadLine();

            Console.WriteLine("Enter the second string:");
            string secondString = Console.ReadLine();

            bool isAnagram = CheckAnagram(firstString, secondString);

            Console.WriteLine($"Are the strings anagrams? {isAnagram}");
        }
        static bool CheckAnagram(string firstString, string secondString)
        {
            if (firstString.Length != secondString.Length)
            {
                return false;
            }

            char[] firstArray = firstString.ToArray();
            char[] secondArray = secondString.ToArray();

            Array.Sort(firstArray);
            Array.Sort(secondArray);

            return new string(firstArray) == new string(secondArray);
        }
    }
}
