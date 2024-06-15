/*Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

You must write an algorithm that runs in O(n) time and without using the division operation.



Example 1:

Input: nums = [1,2,3,4]
Output: [24,12,8,6]
Example 2:

Input: nums = [-1,1,0,-3,3]
Output: [0,0,9,0,0]
*/

namespace Assignment6._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 4 };
            int[] result1 = ProductOfElements(nums1);

            int[] nums2 = { -1, 1, 0, -3, 3 };
            int[] result2 = ProductOfElements(nums2);

            Console.WriteLine(string.Join(", ", result1));
            Console.WriteLine(string.Join(", ", result2));
        }
        static int[] ProductOfElements(int[] nums)
        {
            int length = nums.Length;
            int[] outputArray = new int[length];
            int[] left = new int[length];
            int[] right = new int[length];

            //Make the left array. "left[0] is 1 since there are no elements to the left of the first element in the array. 
            left[0] = 1;
            for (int i = 1; i < length; i++)
            {
                left[i] = nums[i - 1] * left[i - 1]; //nums[i - 1] is the element to the left of "i". left[i - 1] is the product of all numbers to the left of "i - 1".
            }
            
            //Make the right array. "right[length - 1] is 1 because there are no elements to the right of the last element in the array.
            right[length - 1] = 1;
            for (int i = length - 2; i >= 0; i--)
            {
                right[i] = nums[i + 1] * right[i + 1]; //nums[i + 1] is the element to the right of "i". right[i + 1] is the product of all numbers to the right of "i + 1".
            }
            for (int i = 0; i < length; i++)
            {
                outputArray[i] = left[i] * right[i]; //Takes the product of "left[i] * right[i]" for every "i" and then stores it in "outputArray".
            }
            return outputArray;
        }
    }
}
