namespace ReverseArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine("The original array is:");
            foreach (int i in array)
            {
                Console.Write($" {i} ");
            }

            ReverseArray(array);
        }
        static void Swap(int[] array, int i, int n)
        {
            int temp = array[i];
            array[i] = array[n - 1 - i];
            array[n - 1 - i] = temp;
        }
        static void ReverseArray(int[] array)
        {
            int n = array.Length;

            //Reverses all elements
            for (int i = 0; i < n / 2; i++)
            {
                Swap(array, i, n);
            }

            //Swaps only the even index elements

            /* for (int i = 0; i < n / 2; i += 2)
            {
                Swap(array, i, n);             
            } */

            Console.WriteLine();
            Console.WriteLine("The reversed array is:");
            foreach (int i in array)
            {
                Console.Write($" {i} ");
            }
        }
    }
}