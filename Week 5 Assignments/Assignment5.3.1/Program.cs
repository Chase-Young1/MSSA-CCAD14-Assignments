/* You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.

Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n, return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.

Example 1:

Input: flowerbed = [1, 0, 0, 0, 1], n = 1

Output: true

Example 2:

Input: flowerbed = [1, 0, 0, 0, 1], n = 2

Output: false */

namespace Assignment5._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] flowerbed = { 1, 0, 0, 0, 1 };
            int n1 = 1;
            Console.WriteLine(PlantFlowers(flowerbed, n1));

            int[] flowerbed2 = { 1, 0, 0, 0, 1 };
            int n2 = 2;
            Console.WriteLine(PlantFlowers(flowerbed2, n2));

            int[] flowerbed3 = { 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 1, 0 };
            int n3 = 3;
            Console.WriteLine(PlantFlowers(flowerbed3, n3));

        }
        static bool PlantFlowers(int[] flowerbed, int n)
        {
            int count = 0;

            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0) && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
                {
                    flowerbed[i] = 1;
                    count++;
                }
            }
            return count >= n;
        }
    }
}