/* Given a string s consisting of words and spaces, return the length of the last word in the string. A word is a maximal substring consisting of non-space characters only.

Example 1:

Input: s = "Hello World"
Output: 5
Explanation: The last word is "World" with length 5.
Example 2:

Input: s = " fly me to the moon "
Output: 4
Explanation: The last word is "moon" with length 4. */

namespace Assignment5._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a full sentence.");
            string sentence = Console.ReadLine();
            int length = ReturnLengthOfLastWord(sentence);
            Console.WriteLine($"The length of the last word is {length}.");
        }
        static int ReturnLengthOfLastWord(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
            {
                return 0;
            }

            string[] words = sentence.Split(' ');

            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(words[i]))
                {
                    return words[i].Length;
                }
            }
            return 0;
        }
    }
}