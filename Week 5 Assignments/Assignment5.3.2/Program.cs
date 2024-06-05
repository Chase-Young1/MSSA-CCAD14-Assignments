/* You are climbing a staircase. It takes n steps to reach the top.

Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?


Example 1:

Input: n = 2

Output: 2

Explanation: There are two ways to climb to the top.

1. 1 step + 1 step

2. 2 steps



Example 2:

Input: n = 3

Output: 3

Explanation: There are three ways to climb to the top.

1. 1 step + 1 step + 1 step

2. 1 step + 2 steps

3. 2 steps + 1 step */

namespace Assignment5._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of steps in a specified staircase.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(ClimbSteps(n));
        }
        static int ClimbSteps(int n)
        {
            if (n < 3) //If n == 0, 1, or 2 then the number of ways to climb is == n
            {
                return n;
            }
            int first = 1;
            int second = 2;
            for (int i = 2; i < n; i++) //Starts at 2 and increments one number at a time until we reach n
            {
                int current = first + second; //Stores sum of first and second numbers throughout the loop
                first = second; //Assigns the second number to the first number when moving forward
                second = current; //Assigns the current number to second as we increment through the loop
            }
            return second;
        }
    }
}