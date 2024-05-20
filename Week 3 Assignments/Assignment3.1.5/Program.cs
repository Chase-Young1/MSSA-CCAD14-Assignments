namespace Assignment3._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 0, 2, 1, 1, 9, 1, 1 };
            int[] outputArray = ChangeConsecutiveOnes(inputArray);

            Console.WriteLine($"Output: {string.Join(",", outputArray)}");

        }
        static int[] ChangeConsecutiveOnes(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (inputArray[i] == 1 && inputArray[i + 1] == 1)
                {
                    inputArray[i] = 0;
                    inputArray[i + 1] = 0;
                    break;
                }
            }
            return inputArray;
        }
    }
}