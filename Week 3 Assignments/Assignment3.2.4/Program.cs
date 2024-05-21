namespace Assignment3._2._4
{
    internal class Program
    {
        static void Main()
        {
            int[] inputArray = { 0, 0, 0, 0 };

            Console.WriteLine("Enter the first number:");
            inputArray[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            inputArray[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            inputArray[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the fourth number:");
            inputArray[3] = Convert.ToInt32(Console.ReadLine());

            double[] outputArray = TotalAverage(inputArray);

            Console.WriteLine($"The average is: {outputArray[0]}");
            Console.WriteLine($"The total is: {outputArray[1]}");
        }
        static double[] TotalAverage(int[] input)
        {
            double total = input[0] + input[1] + input[2] + input[3];
            double average = total / 4;
            double[] outputArray = { average, total };
            return outputArray;
            
        }
    }
}