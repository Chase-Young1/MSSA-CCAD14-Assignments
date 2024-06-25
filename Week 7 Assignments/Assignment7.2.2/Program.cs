/*Given a string s, reverse only all the vowels in the string and return it.

The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.

Example 1:

Input: s = "hello"

Output: "holle"

Example 2:

Input: s = "avacado"

Output: "ovacada"

Example 3: “intelligent”- i , e, i, e

Output: entillegint
*/

namespace Assignment7._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "intelligent";
            string output = ReverseVowels(input);

            Console.WriteLine(output);
        }
        static string ReverseVowels(string input)
        {
            string vowels = "";   //Empty string to store all of the vowels in "input" string       

            //Loops through each character in "input", if it finds a vowel it gets added to the string "vowels"
            for (int i = 0; i < input.Length; i++)
            {
                if ("aeiouAEIOU".IndexOf(input[i]) != -1)
                {
                    vowels += input[i];
                }
            }

            string output = ""; //Empty string to store the output
            int j = vowels.Length - 1; //Keeps track of current position of vowels, from the end of the string

            //Loop through "input" again and if we find a vowel, we take the vowel from position "j" in "vowels" and put it in the "output" string
            for (int i = 0; i < input.Length; i++)
            {
                if ("aeiouAEIOUI".IndexOf(input[i]) != -1)
                {
                    output += vowels[j--];
                }
                else //If it is not a vowel, we just add it to the "output" string
                {
                    output += input[i];
                }
            }
            return output;
        }
    }
}
