namespace Assignment3._2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetIndex(new int[] { 1, 5, 3 }, 5)); //First array
            Console.WriteLine(GetIndex(new int[] { 9, 8, 3 }, 3)); //Second array
            Console.WriteLine(GetIndex(new int[] { 1, 2, 3 }, 4)); //Third array
        }
        static int GetIndex(int[] inputArray, int index)
        {
            for (int i = 0; i < inputArray.Length; i++) //Loops through the given array to find the index of a given item
            {
                if (inputArray[i] == index) //Says if the index equals the item we are searching for, it returns that index
                {
                    return i; //If the item is found, return the index
                }
            }
            return -1; //If the item is not found, return -1
        }
    }
}
