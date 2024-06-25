/* You are a student who has recently taken an exam with your classmates. However, the professor has not yet provided the students with a sorted list of exam scores. 
 To make things easier, you write a program to sort exam scores in ascending order using the selection sort algorithm. 
 This way, you can obtain the sorted list of scores and see how you performed compared to your classmates. 
 Also, you choose selection sort since that is an easy way of implementation. */

namespace Assignment7._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 36, 25, 78, 95, 97, 52, 21, 0};
            SortGrades(array);
            Console.WriteLine("Sorted exam scores: ");
            PrintArray(array);
        }
        static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.WriteLine(num + " ");
            }
        }
        static void SortGrades(int[] array)
        {
            int length = array.Length;

            //Outer loop points to the first unsorted element (keeps track of the seperation of sorted and unsorted parts of the array)
            for (int i = 0; i < length - 1; i++) 
            {

                //Finds minimum element in the unsorted portion of the array
                int minIndex = i;

                for (int j = i + 1; j < length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }                
                }
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }
    }
}
