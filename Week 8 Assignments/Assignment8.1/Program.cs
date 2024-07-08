namespace Assignment8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 35, 12, 27, 5, 21 }; //Declares our initial array
            int length = array.Length; //Sets the length of "array" to variable length

            //Calls QuickSort method on array, starting from array[0] to the last element
            QuickSort(array, 0, length - 1);

            Console.WriteLine("Sorted Array:");
            
            /*Iterates through each element in the array, starting from 0 and incrementing
              by 1 each time through the loop until the end*/
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
        }

        static int Partition(int[] array, int low, int high)
        {
            /*Sets the last element in the portion
              we are sorting as the pivot*/
            int pivot = array[high];

            /*"i" will keep track of the border between elements that are less than the 
               pivot and elements that are greater than the pivot*/
            int i = (low - 1); 

            //Iterates over each element in the portion of the array that we are sorting
            for (int j = low; j <= high - 1; j++)
            {
                /*Checks if the current element is smaller than the pivot and if it is
                  it increments i and swaps the index at i with the current element*/
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }
            //Swaps pivot with element at i + 1, placing pivot in its correct postion
            Swap(array, i + 1, high);
            return (i + 1); //Returns the index of the pivot
        }

        static void QuickSort(int[] array, int low, int high)
        {
            /*Checks if low is less than high. If it's not, then there is 1 or 0
              elements so we do nothing. If it is less, we proceed into the if statement*/
            if (low < high)
            {

                /*Calls "Partition" method and assigns the value it returned 
                  to "partitionIndex".*/
                int partitionIndex = Partition(array, low, high);

                //Recursively sorts the elements before and after the pivot point seperately
                QuickSort(array, low, partitionIndex - 1); //Sorts to the left
                QuickSort(array, partitionIndex + 1, high); //Sorts to the right
            }
        }

        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i]; //Temporalily stores element at index i
            array[i] = array[j]; //Replaces element at index i with element at index j
            array[j] = temp; //Replaces the element at index j with the element stored in temp
        }
    }
}
