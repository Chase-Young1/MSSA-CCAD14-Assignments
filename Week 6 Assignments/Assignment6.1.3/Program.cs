/*Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Note that you must do this in-place without making a copy of the array.


Example 1:

Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]
Example 2:

Input: nums = [0]
Output: [0]
*/

namespace Assignment6._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the size you would like to make the array.");
            string input = Console.ReadLine();
            int size; //Holds the size of the array

            if (int.TryParse(input, out size)) //Tries to convert the input string to an integer and store it in the variable "size". If successful, code inside the if statement gets executed.
            {
                int[] nums = new int[size];
                Console.WriteLine("Please enter a list of elements for the array.");
                for (int i = 0; i < size; i++) //Creates a loop that iterates "size" times. Allowing the user to input the number of elements they want in the array.
                {
                    if (int.TryParse(Console.ReadLine(), out nums[i]) == false) //Reads a line from the console, and tries to store it in "nums[i]". If it fails it returns the error message below.
                    {
                        Console.WriteLine("Invalid input. Please enter a valid list of elements.");
                        return;
                    }
                }
                MoveAllZeros(nums);
                Console.WriteLine("");
                foreach (int num in nums)
                {
                    Console.WriteLine(num + " ");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
        static void MoveAllZeros(int[] nums)
        {
            int lastNonZeroInteger = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int temp = nums[i];
                    nums[i] = nums[lastNonZeroInteger];
                    nums[lastNonZeroInteger++] = temp;
                }
            }
        }
    }
}
