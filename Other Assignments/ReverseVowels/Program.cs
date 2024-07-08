namespace ReverseVowels
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
                if ("aeiouAEIOU".Contains(input[i]))
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
