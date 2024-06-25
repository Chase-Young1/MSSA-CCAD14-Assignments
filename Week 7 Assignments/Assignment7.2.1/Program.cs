/*Implement shell sort on an unsorted array of numbers. Take the array input from user.*/

namespace Assignment7._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] unsortedArray = new int[n];
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < n; i++)
            {
                unsortedArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            ShellSort(unsortedArray);

            Console.WriteLine();
            Console.WriteLine("Sorted array:");
            foreach (int num in unsortedArray)
            {
                Console.WriteLine(num);
            }
        }
        static void ShellSort(int[] numsArray)
        {
            int n = numsArray.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = numsArray[i];
                    int j;
                    for (j = i; j >= gap && numsArray[j - gap] > temp; j -= gap)
                    {
                        numsArray[j] = numsArray[j - gap];
                    }
                    numsArray[j] = temp;
                }
            }
        }
    }
}
