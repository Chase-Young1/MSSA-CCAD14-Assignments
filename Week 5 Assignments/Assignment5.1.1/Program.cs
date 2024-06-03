namespace Assignment5._1._1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a valid integer");
            string x = Console.ReadLine();

            if (FindPalindrome(x))
            {
                Console.WriteLine($"{x} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{x} is not a palindrome.");
            }
        }

        static bool FindPalindrome(string x)
        {
            bool isPalidrome = false;

            for (int i = 0; i < x.Length / 2; i++)
            {
                if (!(x[i] == x[x.Length - 1 - i]))
                {
                    return false;
                }
            }
            return true;
            
        }
    }
}