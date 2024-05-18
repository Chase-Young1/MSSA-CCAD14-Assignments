namespace Assignment1._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 2, 4, 6, 8, 10 };
            int length = ints.Length;
            int temp = 0;

            Console.WriteLine("Original Array");
            foreach (int i in ints)
            {
                Console.WriteLine("");
                Console.WriteLine(i);
            }

            for (int i = 0; i < (length / 2); i++)
            {
                temp = ints[i];
                ints[i] = ints[length - i - 1];
                ints[length - i - 1] = temp;
            }

            Console.WriteLine("");
            Console.WriteLine("Reversed Array");
            foreach (int i in ints)
            {
                Console.WriteLine("");
                Console.WriteLine(i);
            }
        }
    }
}